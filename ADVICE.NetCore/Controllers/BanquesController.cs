using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ADVICEData.Infrastructure;
using ADVICEData.IRepositoriesDAL;
using ADVICEData.Logger;
using ADVICEDomaine.Entities;

namespace ADVICE.NetCore.Controllers
{
    [ApiController]
    [Route("api/banques")]
    public class BanquesController : ControllerBase
    {
        #region Injecting a Constructor

        private readonly ARTIPERSONNEL_SOC001Context _context;
        private readonly IRepositoryWrapper _repository;
        private readonly IBanqueRepository _banqueRepo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _loggerManager;
        private readonly ILogger __logger;
        private readonly ILogger<BanquesController> _loggerController;

        public BanquesController(IRepositoryWrapper repository, IBanqueRepository repo, ARTIPERSONNEL_SOC001Context context, IMapper mapper, ILoggerManager Nlogger, ILogger<EmployeesController> logger, ILoggerFactory loggerfactory)
        {

            logger.LogInformation("created EmployeesController");
            __logger = loggerfactory.CreateLogger("ADVICENetCoreApplication.Controllers");

            //_loggerController = logger;
            //_repository = repository ??
            //    throw new ArgumentNullException(nameof(repository));
            _context = context;
            _banqueRepo = repo ??
                throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ??
                throw new ArgumentException(nameof(mapper));
        }
        #endregion
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}