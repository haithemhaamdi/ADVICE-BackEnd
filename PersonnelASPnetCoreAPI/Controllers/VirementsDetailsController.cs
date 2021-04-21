using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonnelASPnetCore.Dto.DTO;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Data.Logger;
using PersonnelASPnetCore.Data.Profiles;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.BULLETIN_PAIE_Dto;
using Microsoft.EntityFrameworkCore;
using PersonnelASPnetCore.Data;
using Microsoft.AspNetCore.Authorization;
using PersonnelASPnetCore.Dto.ROLE_Dto;
using PersonnelASPnetCore.Dto.VIREMENT_DETAIL_Dto;

namespace PersonnelASPnetCoreAPI.Controllers
{
    /// <summary>
    /// Le[Produces] filtre précédent :
    ///Force toutes les actions du contrôleur à retourner des réponses au format JSON.
    ///Si d’autres formateurs sont configurés et que le client spécifie un format différent, JSON est retourné
    /// </summary>
    /// 
    [Authorize]
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class VirementsDetailsController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        //Interrogate the DB directly (without going through a stored procedure)[0]
        private readonly IVirementDetailRepository<VIREMENT_DETAIL> _virement_DetailRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        private readonly ILogger _logger;
        private readonly ILogger<VirementsDetailsController> _loggerController;
        public VirementsDetailsController
    (
    ARTIPERSONNEL_SOC001Context context,
    IRepositoryWrapper repositoryWrapper,
    IVirementDetailRepository<VIREMENT_DETAIL> repo,
    IMapper mapper,
    ILoggerManager loggerManager,
    ILogger<VirementsDetailsController> logger,
    ILoggerFactory loggerfactory
    )
        {
            // Context ARTIPERSONNEL_SOC001Context [1]
            _context = context;
            // Repository IRepositoryWrapper [2]
            _repositoryWrapper = repositoryWrapper ??
                throw new ArgumentNullException(nameof(repositoryWrapper));

            // Repository IBulletinPaieRepository (PS)[4]
            _virement_DetailRepo = repo ??
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
            logger.LogInformation("created VirementsDetailsController");
            _logger = loggerfactory.CreateLogger("PersonnelASPnetCoreApiApplication.Controllers");

        }
        #endregion
        [Authorize(Roles = Role.Admin)]
        [HttpGet()]
        public ActionResult<IEnumerable<VIREMENT_DETAIL>> Get()
        {
            var BulletinsPaieDetailFromRepo = _virement_DetailRepo.GetAllVIREMENT_DETAILsPS();
            return Ok(_mapper.Map<IEnumerable<VirementDetailResponseDto>>(BulletinsPaieDetailFromRepo));
            //return Ok(BulletinsPaieDetailFromRepo);
        }


        // GET: api/BulletinsPaie/5
        [Authorize(Roles = Role.Admin)]
        [HttpGet("{NumeroBulletin}")]
        public async Task<IActionResult> Get([FromRoute]string NumeroBulletin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var virementDetail = await _virement_DetailRepo.GetVIREMENT_DETAILsPSbyNumeroBulletin(NumeroBulletin);
            if (virementDetail == null)
            {
                _logger.LogError($"Bulletin Paie's Detail with id: {NumeroBulletin}, hasn't been found in db.");
                return NotFound();
            }
            return Ok(virementDetail);
        }
    }

}