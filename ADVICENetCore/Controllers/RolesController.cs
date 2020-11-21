using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ADVICEDto.DTO;
using ADVICEData;
using ADVICEData.Infrastructure;
using ADVICEData.IRepositoriesDAL;
using ADVICEData.RepositoriesDAL;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADVICEDto.ROLE_Dto;
using Microsoft.AspNetCore.Authorization;
using ADVICEData.Logger;
using ADVICEService.ServiceManagmentInterface;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ADVICENetCore.Controllers
{

    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repository;
        private readonly IRoleRepository _roleRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly AppSettings _appSettings;


        public RolesController(
            IRepositoryWrapper repository,
            IRoleRepository repo, 
            ARTIPERSONNEL_SOC001Context context,
            IOptions<AppSettings> appSettings,
            IMapper mapper,
            ILoggerManager Nlogger,
            ILogger<RolesController> logger)
        {
            logger.LogInformation("created UsersController");
            _logger = Nlogger;

            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            _context = context;
            _roleRepo = repo ??
                throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ??
                throw new ArgumentException(nameof(mapper));

            /* Used to authenticate */
            _appSettings = appSettings.Value;
        }
        #endregion

        // GET: api/Roles
        [Authorize(Roles = Role.Admin)]
        [HttpGet()]
        public ActionResult<IEnumerable<ROLEdto>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var roles = _roleRepo.GetAllRolesPS();
            return Ok(_mapper.Map<IEnumerable<RoleResponseDto>>(roles));
        }

        // GET: api/Roles
        [AllowAnonymous]
        [HttpGet("{codeEmploye}")]
        public async Task<IActionResult> Get([FromRoute]string codeEmploye)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var role = await _roleRepo.GetRoleByUserCodePS(codeEmploye);
            if (role == null)
            {
                _logger.LogError($"Role with code employe: {codeEmploye}, hasn't been found in db.");

                return NotFound();
            }
            return Ok(_mapper.Map<RoleUserResponseDto>(role));
        }
    }
}
