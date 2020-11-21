using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ADVICEDomaine.Entities;
using ADVICEData.Infrastructure;
using ADVICEData.IRepositoriesDAL;
using ADVICEData.Logger;
using ADVICEDto.USER_Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ADVICEDto.DTO;
using ADVICEDomaine.Models;
using Microsoft.EntityFrameworkCore;
using ADVICEService.ServiceManagmentInterface;
using ADVICEData;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using ADVICEData.Helper;
using System.Linq;
using ADVICEDto.ROLE_Dto;
using System.Net;
using System.Net.NetworkInformation;
using ADVICEDto.CONNECTIONS_HISTORY_Dto;
using Microsoft.AspNetCore.Http;

namespace ADVICE.NetCore.Controllers
{

    [Authorize]
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repository;
        private readonly IUserRepository<USER> _userRepo;
        private readonly IConnectionHistoryRepository<CONNECTIONS_HISTORY> _connHistoryRepo;

        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly AppSettings _appSettings;
        private IUSERService _userService;
        private readonly IRoleRepository _roleRepo;



        public UsersController(
            ARTIPERSONNEL_SOC001Context context,
            IUSERService userService,
            IRoleRepository roleRepo,
            IOptions<AppSettings> appSettings,
            IRepositoryWrapper repository,
            IUserRepository<USER> repo,
            IConnectionHistoryRepository<CONNECTIONS_HISTORY> connHistory_repo,
            IMapper mapper,
            ILoggerManager Nlogger,
            ILogger<UsersController> logger)
        {
            logger.LogInformation("created UsersController");
            _logger = Nlogger;

            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            _context = context;
            _userRepo = repo ??
                throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ??
                throw new ArgumentException(nameof(mapper));

            _connHistoryRepo = connHistory_repo;
            /* Used to authenticate */
            _roleRepo = roleRepo;
            _userService = userService;
            _appSettings = appSettings.Value;

        }
        #endregion

        #region C R U D Operation
        // GET: api/Users
        [Authorize(Roles = Role.Admin)]
        [HttpGet()]
        public ActionResult<IEnumerable<USER>> Get()
        {
            #region
            //var UsersFromRepo = _repository.USERRepo.GetAllWithRefernces();

            //DbSet<USER> _user = _context.USER;
            //_user.Include(c => c.CodeEmployeNavigation).Load();
            //_user.Include(c => c.CodeRoleNavigation).Load();
            #endregion
            var UsersFromRepo = _userRepo.GetAllUsersPS();
            return Ok(_mapper.Map<IEnumerable<UserResponseDto>>(UsersFromRepo));
        }

        // GET: api/Users/5
        [Authorize(Roles = Role.AdministratorOrUser)]
        [HttpGet("{codeEmploye}")]
        public async Task<IActionResult> Get([FromRoute]string codeEmploye)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // only allow admins to access other user records
            var currentUserId = User.Identity.Name;
            if (codeEmploye != currentUserId && !User.IsInRole(Role.Admin))
                return Forbid();

            var user = await _userRepo.GetUserPSbyID(codeEmploye);
            if (user == null)
            {
                _logger.LogError($"User with id: {codeEmploye}, hasn't been found in db.");
                return NotFound();
            }
            return Ok(user);
        }

        // POST: api/Users
        [Authorize(Roles = Role.Admin)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddUserDto addUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            #region For ALL USER REGISTRATION
            var dateNow = DateTime.Now;
            addUserDto.connections = 0;
            addUserDto.status = false;
            addUserDto.macAddress = "127.0.0.1";
            addUserDto.createDate = dateNow;
            addUserDto.modifyDate = dateNow;

            #endregion

            var preUser = _mapper.Map<USER>(addUserDto);
            var SM = addUserDto.username;
            addUserDto.login = SM;

            try
            {
                await _userRepo.CreateUserPSAsync(preUser, preUser.Password);
                var saveUser = await _userRepo.SaveAsync(preUser);
                var userResponse = _mapper.Map<UserResponseDto>(saveUser);

                //return CreatedAtAction("Get", new { codeEmploye = user.CodeUser }, user);
                //return Ok();
                return StatusCode(201, new { userResponse });
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        // PUT: api/Users/5
        [Authorize(Roles = Role.User)]
        [HttpPut("{codeEmploye}")]
        public async Task<IActionResult> Put([FromRoute]string codeEmploye, [FromBody]EditUserDto editUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (codeEmploye != editUserDto.CodeEmploye)
            {
                return BadRequest();
            }
            try
            {
                var preUser = _mapper.Map<USER>(editUserDto);
                _userRepo.UpdateUserPS(preUser);
                await _userRepo.SaveAsync(preUser);
                return NoContent();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE: api/Users/5
        [Authorize(Roles = Role.Admin)]
        [HttpDelete("{codeEmploye}")]
        public async Task<IActionResult> Delete([FromRoute]string codeEmploye)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _userRepo.GetUserPSbyID(codeEmploye);
            //    _userService.Delete(id);

            if (codeEmploye == null)
            {
                _logger.LogError($"User with id: {codeEmploye}, hasn't been found in db.");
            }

            _userRepo.DeleteUserPS(codeEmploye);
            return Ok(user);
        }
        #endregion

        #region UserExists
        private bool UserExists(string codeEmploye)
        {
            return _context.USER.Any(e => e.CodeEmploye == codeEmploye);
        }
        #endregion

        #region Policy
        [HttpGet]
        [Route("GetUserData")]
        [Authorize(Policy = Policies.User)]
        public IActionResult GetUserData()
        {
            return Ok("This is a response from user method");
        }

        [HttpGet]
        [Route("GetAdminData")]
        [Authorize(Policy = Policies.Admin)]
        public IActionResult GetAdminData()
        {
            return Ok("This is a response from Admin method");
        }
        #endregion

        #region USER AUTHETIFICATE

        // POST: api/Users/authenticate
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateRequestDto model)
        {

            var user = _userRepo.Authenticate(model.username, Helper.base64Encode(model.password), GetIpAddress(), model.message, model.isAuthenticated);
            if (user == null)
            {
                model.isAuthenticated = false;
                //model.message = $"Incorrect Credentials for user {model.username}.";
                //return BadRequest(new { message = "Username or password is incorrect" });
                return BadRequest(model.message);
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var _role = _roleRepo.GetRoleByUserCodePS(user.CodeEmploye).Result.Name;
            _userRepo.IncrementConnectionPS(user.CodeEmploye, user.Connections);
            _userRepo.ChecKActiveToken(model.RevokeAll = false);

            setTokenCookie(user.RefreshToken);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.CodeEmploye.ToString()),
                    new Claim(ClaimTypes.Role, _role.ToString())
                }),
                Expires = DateTime.Now.AddMinutes(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            model.isAuthenticated = true;
            //model.message = "Authenticate Successfully";

            try
            {
                UserTokenDto _userTokenDto = new UserTokenDto();
                var preUsertoSaveToken = _mapper.Map<USER>(_userTokenDto);
                user.Token = tokenString;
                _userTokenDto.CodeEmploye = user.CodeEmploye;
                _userTokenDto.Token = tokenString;
                _userRepo.UpdateUserTokenPS(preUsertoSaveToken, _userTokenDto.CodeEmploye, _userTokenDto.Token);
                _userRepo.SaveAsync(preUsertoSaveToken);
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }

            //Alimenter la table connexion_history
            AddConnectionHistoryDto addConnectionHistoryDto = new AddConnectionHistoryDto();
            var dateDate = DateTime.Now;
            int result = 2000000000 + (dateDate.Month * 1000000) + (dateDate.Day * 10000) + (dateDate.Hour * 100) + (dateDate.Minute * 1);
            addConnectionHistoryDto.Id = result;
            addConnectionHistoryDto.CodeEmploye = user.CodeEmploye;
            addConnectionHistoryDto.Username = user.Username;
            addConnectionHistoryDto.FirstName = user.FirstName;
            addConnectionHistoryDto.LastName = user.LastName;
            addConnectionHistoryDto.Role = _role;
            addConnectionHistoryDto.Connections = user.Connections + 1;
            addConnectionHistoryDto.SignInDate = dateDate;
            addConnectionHistoryDto.SignOutDate = dateDate;
            addConnectionHistoryDto.Hostname = Dns.GetHostName();
            addConnectionHistoryDto.MacAddress = GetMACAddress();
            addConnectionHistoryDto.IpAddress = GetIpAddress();


            var preConnectionHistory = _mapper.Map<CONNECTIONS_HISTORY>(addConnectionHistoryDto);

            _connHistoryRepo.ConnectionHistoryPSAsync(preConnectionHistory);
            _connHistoryRepo.SaveAsync(preConnectionHistory);

            // return basic user info and authentication token
            return Ok(new
            {
                Id = user.CodeEmploye,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = _role,
                Token = tokenString,
                AuthData = user.AuthData
            });
        }

        // POST: api/Users/register
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]AddUserDto addUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            #region For ALL USER REGISTRATION
            var dateNow = DateTime.Now;
            addUserDto.connections = 0;
            addUserDto.status = false;
            addUserDto.codeRole = "R001";
            addUserDto.createDate = dateNow;
            addUserDto.modifyDate = dateNow;
            addUserDto.macAddress = GetMACAddress().ToString();
            addUserDto.IpAddress = GetIpAddress().ToString();


            #endregion

            var preUser = _mapper.Map<USER>(addUserDto);

            try
            {
                await _userRepo.CreateUserPSAsync(preUser, preUser.Password);
                var saveUser = await _userRepo.SaveAsync(preUser);
                var userResponse = _mapper.Map<UserResponseDto>(saveUser);

                //return CreatedAtAction("Get", new { codeEmploye = user.CodeUser }, user);
                //return Ok();
                return StatusCode(201, new { userResponse });
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("logout")]
        public IActionResult Logout([FromBody]LogOutDto logOutDto)
        {
            _userRepo.ChecKActiveToken(logOutDto.RevokeAll = true);
            _userRepo.RevokeToken(logOutDto.Token, GetIpAddress());
            HttpContext.Session.Clear();
            return Ok();
        }

        private string GetIpAddress()
        {
            //if (Request.Headers.ContainsKey("X-Forwarded-For"))
            //    return Request.Headers["X-Forwarded-For"];
            //else
            //    return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();

            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            Console.WriteLine(addr[addr.Length - 1].ToString());
            var AdresseIP = addr[addr.Length - 1].ToString();
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            else
            //    if (addr[0].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            //{
            //    Console.WriteLine("ipv4 :" + addr[3].ToString()); //ipv4
            //    return addr[0].ToString();
            //}
            //else
            {
                Console.WriteLine("ipv4 :" + addr[addr.Length - 1].ToString()); //ipv4
                return addr[addr.Length - 1].ToString();
            }
        }

        private string GetMACAddress()
        {
            var macAddr =
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

            return macAddr.ToString();
        }

        #endregion

        #region REFRESH TOKEN

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public IActionResult RefreshToken([FromBody] RefreshTokenRequestDto model)
        {
            if(model.Token != null)
            {
                var response = _userRepo.RefreshToken(model.Token, GetIpAddress());

                if (response == null)
                    return Unauthorized(new { message = "Invalid token" });

                setTokenCookie(response.RefreshToken);
                return Ok(response);
            }
            else
            {
                var _refreshToken = Request.Cookies["refreshToken"];
                var response = _userRepo.RefreshToken(_refreshToken, GetIpAddress());

                if (response == null)
                    return Unauthorized(new { message = "Invalid token" });

                setTokenCookie(response.RefreshToken);
                return Ok(response);
            }
        }

        [AllowAnonymous]
        [HttpPost("revoke-token")]
        public IActionResult RevokeToken([FromBody] RevokeTokenRequestDto model)
        {
            // accept token from request body or cookie
            var token = model.Token ?? Request.Cookies["refreshToken"];

            if (string.IsNullOrEmpty(token))
                return BadRequest(new { message = "Token is required" });

            var response = _userRepo.RevokeToken(token, GetIpAddress());

            if (!response)
                return NotFound(new { message = "Token not found" });

            return Ok(new { message = "Token revoked" });
        }

        [HttpGet("{id}/refreshTokens")]
        [AllowAnonymous]
        public IActionResult GetRefreshTokens(string id)
        {
            var user = _userRepo.GetUserPSbyID(id);
            if (user == null) return NotFound();

            return Ok(user.Result.REFRESH_TOKEN);
        }

        private void setTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.Now.AddMinutes(2)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }

        [AllowAnonymous]
        [HttpGet("token")]
        public string GetToken(string username)
        {
            var token = _userRepo.GetActiveRefreshToken(username,true);
            return token.ToString();
        }

        #endregion

    }
}
