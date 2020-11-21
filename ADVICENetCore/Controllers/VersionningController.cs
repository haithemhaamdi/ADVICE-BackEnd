using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ADVICENetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionningController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string[]>Get()
        {
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            //var env = Configuration.GetSection("appSettings:Environment").Values;

            return new string[]
            {
                $"Version:{ver}",
                //$"Environment:{env}"
            };
        }

    }

}
