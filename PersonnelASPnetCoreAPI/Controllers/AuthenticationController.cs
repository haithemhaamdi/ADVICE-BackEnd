using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using PersonnelASPnetCore.Data;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Data.Logger;

using System.Security.Claims;
using Newtonsoft.Json;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Data.Helper;

namespace PersonnelASPnetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repository;
        private readonly IUserRepository<USER> _userRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly IConfiguration _config;

        public AuthenticationController(IConfiguration config, ILoggerManager Nlogger, IRepositoryWrapper repository, IUserRepository<USER> repo, ARTIPERSONNEL_SOC001Context context, IMapper mapper, ILogger<AuthenticationController> logger)
        {
            _config = config;

            logger.LogInformation("created UsersController");
            _logger = Nlogger;

            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            _context = context;
            _userRepo = repo ??
                throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ??
                throw new ArgumentException(nameof(mapper));
        }
        #endregion

        /// <summary>
        /// /Changer la methode Post pour passer deux paramétres d'entrés {username} , {password}
        /// https://jasonwatmore.com/post/2019/10/14/aspnet-core-3-simple-api-for-authentication-registration-and-user-management
        /// https://github.com/cornflourblue/angular-8-basic-authentication-example
        /// https://github.com/cornflourblue/aspnet-core-3-basic-authentication-api
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        // POST: api/Authentication
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromRoute]string login, string password)
        {
            IActionResult response = Unauthorized();
            USER user = AuthenticateUser(login, password);
            if (user != null)
            {
                var tokenString = GenerateJWTToken(user);
                //var tokenString = GenerateJSONWebToken(user);     
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }
            return response;
        }



        USER AuthenticateUser(string userLogin, string userpassword)
        {
            var appUsers = _userRepo.GetAllUsersPS();

            //sachant que le mot de passe est chiffré , il faur le déchiffré et l'utilisé
            USER user = appUsers.SingleOrDefault(x => x.Login == userLogin && x.Password == Helper.base64Encode(userpassword));
            return user;
        }


        string GenerateJWTToken(USER userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.NameId, userInfo.CodeEmploye!=null?userInfo.CodeEmploye.ToString():Guid.Empty.ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, userInfo.CodeEmployeNavigation.MatriculeSecuriteSociale!=null?userInfo.CodeEmployeNavigation.MatriculeSecuriteSociale:string.Empty),
                    new Claim(JwtRegisteredClaimNames.Email, userInfo.CodeEmployeNavigation.AdresseMail!=null?userInfo.CodeEmployeNavigation.AdresseMail:string.Empty),
                    new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.CodeEmployeNavigation.NomEmploye!=null?userInfo.CodeEmployeNavigation.NomEmploye.ToString():Guid.Empty.ToString()),
                    new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.CodeEmployeNavigation.MatriculeEmploye!=null?userInfo.CodeEmployeNavigation.MatriculeEmploye.ToString():Guid.Empty.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("role",userInfo.CodeRole)
                };
            //if (roles != null)
            //    foreach (var role in roles)
            //        claims.Add(new Claim("role", role));

            // Create the JWT security token and encode it.
            var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: credentials
            );

            //var encodedJwt = new JwtSecurityTokenHandler().WriteToken(token);

            //// Serialize and return the response
            //var response = new
            //{
            //    access_token = encodedJwt,
            //    expires_in = (int)_jwtOptions.ValidFor.TotalSeconds
            //};

            //var json = JsonConvert.SerializeObject(response, _serializerSettings);
            //return new OkObjectResult(json);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private string GenerateJSONWebToken(USER userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(5),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}