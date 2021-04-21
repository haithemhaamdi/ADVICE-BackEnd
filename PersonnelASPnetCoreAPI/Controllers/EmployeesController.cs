using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonnelASPnetCore.Dto.DTO;
using PersonnelASPnetCore.Data;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Data.Logger;
using PersonnelASPnetCore.Data.RepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonnelASPnetCore.Dto.EMPLOYE_Dto;
using Microsoft.AspNetCore.Authorization;
using PersonnelASPnetCore.Dto.ROLE_Dto;

namespace PersonnelASPnetCoreAPI.Controllers
{
    //[Authorize]
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repository;
        private readonly IEmployeRepository<EMPLOYE> _employeRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        private readonly ILogger __logger;
        private readonly ILogger<EmployeesController> _loggerController;

        public EmployeesController(IRepositoryWrapper repository, IEmployeRepository<EMPLOYE> repo, ARTIPERSONNEL_SOC001Context context, IMapper mapper, ILoggerManager Nlogger, ILogger<EmployeesController> logger, ILoggerFactory loggerfactory)
        {

            logger.LogInformation("created EmployeesController");
            __logger = loggerfactory.CreateLogger("PersonnelASPnetCoreApiApplication.Controllers");

            _loggerController = logger;
            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            _context = context;
            _employeRepo = repo ??
                throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ??
                throw new ArgumentException(nameof(mapper));
        }
        #endregion

        //[Authorize(Roles = Role.Admin)]
        [HttpGet()]
        public ActionResult<IEnumerable<EMPLOYEdto>> Get()
        {
            __logger.LogInformation(LoggingEvents.GetItem, "Getting item {Id}");
            _loggerController.LogDebug(1, "NLog injected into EmployeesController");


            var EmployeesFromRepo = _employeRepo.GetAllEmployesPS();
            return Ok(_mapper.Map<IEnumerable<EmployeResponseDto>>(EmployeesFromRepo));
        }

        //[Authorize(Roles = Role.Admin)]
        [HttpGet("{codeEmp}")]
        public IActionResult Get(string codeEmp)
        {
            var EmployeeFromRepo = _employeRepo.GetEmployesPSbyID(codeEmp);

            #region Logger
            //try
            //{
            //    if (EmployeeFromRepo.CodeEmploye != null)
            //    {
            //        return Ok(_mapper.Map<IEnumerable<EMPLOYEdto>>(EmployeeFromRepo));
            //    }

            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Employee with id: {codeEmp}, hasn't been found in db.");
            //    __logger.LogWarning(LoggingEvents.GetItemNotFound, ex, "GetById({Id}) NOT FOUND", codeEmp);

            //    return NotFound();
            //}
            //return new ObjectResult(EmployeeFromRepo);
            #endregion

            _loggerController.LogInformation("Hello, this is the Get!");

            if (EmployeeFromRepo.CodeEmploye == null)
            {
                _loggerManager.LogError($"Employee with id: {codeEmp}, hasn't been found in db.");
                _loggerController.LogWarning($"Employee with id: {codeEmp}, hasn't been found in db.");
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<EmployeResponseDto>>(EmployeeFromRepo));
        }

        //[HttpGet("{codeEmp}", Name = "GetEmployee")]
        //public async Task<IActionResult> GetEmployee(string codeEmp)
        //{
        //    var EmployeeFromRepo = await _employeRepo.GetEmployeByIDAsync(codeEmp);
        //    #region Logger
        //    //try
        //    //{
        //    //    if (EmployeeFromRepo.CodeEmploye != null)
        //    //    {
        //    //        return Ok(_mapper.Map<IEnumerable<EMPLOYEdto>>(EmployeeFromRepo));
        //    //    }

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    _logger.LogError($"Employee with id: {codeEmp}, hasn't been found in db.");
        //    //    __logger.LogWarning(LoggingEvents.GetItemNotFound, ex, "GetById({Id}) NOT FOUND", codeEmp);

        //    //    return NotFound();
        //    //}
        //    //return new ObjectResult(EmployeeFromRepo);
        //    #endregion
        //    _loggerController.LogInformation("Hello, this is the Get!");

        //    if (EmployeeFromRepo.CodeEmploye == null)
        //    {
        //        _loggerManager.LogError($"Employee with id: {codeEmp}, hasn't been found in db.");
        //        _loggerController.LogWarning($"Employee with id: {codeEmp}, hasn't been found in db.");
        //        return NotFound();
        //    }
        //    return Ok(_mapper.Map<IEnumerable<EMPLOYEdto>>(EmployeeFromRepo));
        //}

        [HttpPost]
        public IActionResult Post([FromBody]EMPLOYE employe)
        {
            _employeRepo.CreateEmployePSAsync(employe);
            return Ok(); ;
        }

        [HttpPut]
        public IActionResult Put(string codeEmp, [FromBody]EMPLOYE employe)
        {
            _employeRepo.UpdateEmployePS(employe);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string codeEmp)
        {
            if (codeEmp == null)
            {
                _loggerManager.LogError($"Employee with id: {codeEmp}, hasn't been found in db.");
            }
            _employeRepo.DeleteEmployePS(codeEmp);
            return Ok();
        }
    }
}
