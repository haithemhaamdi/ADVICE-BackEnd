using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.Logger;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Data.RepositoriesDAL;
using PersonnelASPnetCore.Dto.DTO;
using PersonnelASPnetCore.Dto.BULLETIN_PAIE_Dto;
using Microsoft.AspNetCore.Authorization;
using PersonnelASPnetCore.Dto.ROLE_Dto;
using PersonnelASPnetCore.Dto.BULLETIN_PAIE_DETAIL_Dto;

namespace PersonnelASPnetCoreAPI.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class BulletinsPaieDetailsController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        //Interrogate the DB directly (without going through a stored procedure)[0]
        private readonly IBulletinPaieDetailRepository<BULLETIN_PAIE_DETAIL> _bulletinPaieDetailRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        private readonly ILogger _logger;
        private readonly ILogger<BulletinsPaieDetailsController> _loggerController;


        public BulletinsPaieDetailsController
            (
            ARTIPERSONNEL_SOC001Context context,
            IRepositoryWrapper repositoryWrapper,
            IBulletinPaieDetailRepository<BULLETIN_PAIE_DETAIL> repo,
            IMapper mapper,
            ILoggerManager loggerManager,
            ILogger<BulletinsPaieDetailsController> logger,
            ILoggerFactory loggerfactory
            )
        {
            // Context ARTIPERSONNEL_SOC001Context [1]
            _context = context;
            // Repository IRepositoryWrapper [2]
            _repositoryWrapper = repositoryWrapper ??
                throw new ArgumentNullException(nameof(repositoryWrapper));
            // Repository IBulletinPaieRepository (PS)[4]
            _bulletinPaieDetailRepo = repo ??
                throw new ArgumentNullException(nameof(repo));
            // IMapper : Interface AutoMapper.IMapper[5]
            _mapper = mapper ??
                throw new ArgumentException(nameof(mapper));
            // ILoggerManager : Interface namespace PersonnelASPnetCore.Data.Logger.ILoggerManager [6]
            _loggerManager = loggerManager ??
                throw new ArgumentException(nameof(loggerManager));
            // ILogger<T_Controller> : Microsoft.Extensions.Logging [7]
            // Microsoft.Extensions.Logging.Abstractions, Version=3.1.8.0
            _loggerController = logger;
            logger.LogInformation("created BulletinsPaieDtailsController");
            _logger = loggerfactory.CreateLogger("PersonnelASPnetCoreApiApplication.Controllers");

        }
        #endregion

        // GET: api/BulletinsPaieDetails
        [Authorize(Roles = Role.Admin)]
        [HttpGet()]
        public ActionResult<IEnumerable<BULLETIN_PAIE_DETAIL>> Get()
        {
            var BulletinsPaieDetailFromRepo = _bulletinPaieDetailRepo.GetAllBulletinPaieDetailsPS();
            return Ok(_mapper.Map<IEnumerable<BulletinPaieDetailResponseDto>>(BulletinsPaieDetailFromRepo));
            //return Ok(BulletinsPaieDetailFromRepo);
        }


        // GET: api/BulletinsPaieDetails/5
        [Authorize(Roles = Role.Admin)]
        [HttpGet("{NumeroBulletin}")]
        public ActionResult<IEnumerable<BULLETIN_PAIE_DETAIL>> Get([FromRoute]string NumeroBulletin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            #region à compléter
            //// only allow admins to access other user records
            //var currentUserId = User.Identity.Name;
            //if (recupérer le matricule de l'employe qui correspond à cette bulletin de paie 
            //    si c'est le mm utilisateur qui est connecté on l'affiche son BP Detail si non 'No Data'
            //    != currentUserId && !User.IsInRole(Role.Admin))
            //    return Forbid();
            #endregion

            var bulletinsPaieDetails = _bulletinPaieDetailRepo.GetALLBulletinPaieDetailPSbyNumeroBulletin(NumeroBulletin);
            if (bulletinsPaieDetails == null)
            {
                _logger.LogError($"Bulletin Paie's Detail with id: {NumeroBulletin}, hasn't been found in db.");
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<BulletinPaieDetailResponseDto>>(bulletinsPaieDetails));

        }
    }
}