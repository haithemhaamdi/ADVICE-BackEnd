﻿using System;
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

namespace PersonnelASPnetCoreAPI.Controllers
{
    /// <summary>
    /// Le[Produces] filtre précédent :
    ///Force toutes les actions du contrôleur à retourner des réponses au format JSON.
    ///Si d’autres formateurs sont configurés et que le client spécifie un format différent, JSON est retourné
    /// </summary>
    /// 
    [Authorize]
    [ApiController]
    [Route("api/BulletinsPaie")]
    [Produces("application/json")]
    public class BulletinsPaieController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        //Interrogate the DB directly (without going through a stored procedure)[0]
        private readonly IBulletin_PaieRepository<BULLETIN_PAIE> _bulletin_PaieRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        private readonly ILogger _logger;
        private readonly ILogger<BulletinsPaieController> _loggerController;


        public BulletinsPaieController
            (
            ARTIPERSONNEL_SOC001Context context,
            IRepositoryWrapper repositoryWrapper,
            IBulletin_PaieRepository<BULLETIN_PAIE> repo,
            IMapper mapper,
            ILoggerManager loggerManager,
            ILogger<BulletinsPaieController> logger,
            ILoggerFactory loggerfactory
            )
        {
            // Context ARTIPERSONNEL_SOC001Context [1]
            _context = context;
            // Repository IRepositoryWrapper [2]
            _repositoryWrapper = repositoryWrapper ??
                throw new ArgumentNullException(nameof(repositoryWrapper));

            // Repository IBulletinPaieRepository (PS)[4]
            _bulletin_PaieRepo = repo ??
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
            logger.LogInformation("created BulletinsPaieController");
            _logger = loggerfactory.CreateLogger("PersonnelASPnetCoreApiApplication.Controllers");

        }
        #endregion

        [Authorize(Roles = Role.Admin)]
        [HttpGet()]
        public ActionResult<IEnumerable<BULLETIN_PAIEdto>> Get()
        {
            var BulletinsPaieFromRepo = _bulletin_PaieRepo.GetAllBulletinPaiesPS();
            return Ok(_mapper.Map<IEnumerable<BulletinPaieResponseDto>>(BulletinsPaieFromRepo));
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet("{numeroBulletin}")]
        public IActionResult Get(string numeroBulletin)
        {
            var BulletinPaieFromRepo = _bulletin_PaieRepo.GetBulletinPaiePSbyNumero(numeroBulletin);
            if (BulletinPaieFromRepo == null)
            {
                _logger.LogError($"Bulletin Paie with numero: {numeroBulletin}, hasn't been found in db.");
                return NotFound();
            }
            return Ok(_mapper.Map<BulletinPaieResponseDto>(BulletinPaieFromRepo));
            //a ferifier dans BulletinPaieResponseDto et regarder le mapping 
            //return Ok(BulletinPaieFromRepo);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost]
        public IActionResult Post([FromBody]AddBulletinPaieDto addBulletinPaieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var preBulletinPaie = _mapper.Map<BULLETIN_PAIE>(addBulletinPaieDto);
            try
            {
                _bulletin_PaieRepo.CreateBulletinPaiePSAsync(preBulletinPaie);
                //var saveBulletinPaie = await _bulletin_PaieRepo.SaveAsync(preBulletinPaie);
                var userResponse = _mapper.Map<BulletinPaieResponseDto>(preBulletinPaie);
                return StatusCode(201, new { userResponse });
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{numeroBulletin}")]
        public async Task<IActionResult> Put([FromRoute]string numeroBulletin, [FromBody]EditBulletinPaieDto editBulletinPaie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new BULLETIN_PAIE());
            }
            if (numeroBulletin != editBulletinPaie.NumeroBulletin)
            {
                return BadRequest();
            }
            var preBulletinPaie = _mapper.Map<BULLETIN_PAIE>(editBulletinPaie);

            _bulletin_PaieRepo.UpdateBulletinPaiePS(preBulletinPaie);
            //await _bulletin_PaieRepo.SaveAsync(preBulletinPaie);
            return NoContent();
        }

        [Authorize(Roles = Role.Admin)]
        [HttpDelete("{numeroBulletin}")]
        public async Task<IActionResult> Delete([FromRoute]string numeroBulletin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _bulletin_PaieRepo.GetBulletinPaiePSbyNumero(numeroBulletin);
            //    _userService.Delete(id);

            if (numeroBulletin == null)
            {
                _logger.LogError($"Bulletin Paie with Numero: {numeroBulletin}, hasn't been found in db.");
            }

            _bulletin_PaieRepo.DeleteBulletinPaiePS(numeroBulletin);
            return Ok(user);
        }


        //[HttpGet("{NumeroBulletin}")]
        //public IActionResult Get(string NumeroBulletin, string CodeRubrique)
        //{
        //    var codeRubrique = "RUBC04";
        //    var BulletinPaieDetailsFromRepo = _bulletin_PaieRepo.GetBulletinPaieDetailsPS(NumeroBulletin, codeRubrique);
        //    if (BulletinPaieDetailsFromRepo == null)
        //    {
        //        _logger.LogError($"Details Bulletin Paie with Number: {NumeroBulletin}, hasn't been found in db.");
        //        return NotFound();
        //    }
        //    return Ok(_mapper.Map<BulletinPaieDetailDto>(BulletinPaieDetailsFromRepo));
        //}
    }
}