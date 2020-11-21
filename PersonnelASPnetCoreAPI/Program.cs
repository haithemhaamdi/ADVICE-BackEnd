using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using PersonnelASPnetCore.Domaine.Entities;

namespace PersonnelASPnetCoreAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // NLog: setup the logger first to catch all errors
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetService<ARTIPERSONNEL_SOC001Context>();
                    host.Run();
                    //context.Database.EnsureDeleted();
                    //context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    //var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    //logger.LogError(ex, "An error occurred while migrating the database.");
                    //NLog: catch setup errors
                    logger.Error(ex, "Stopped program because of exception");
                    throw;
                }
                finally
                {
                    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                    NLog.LogManager.Shutdown();
                }
            }
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>().ConfigureLogging(logging =>
        //            {
        //                logging.ClearProviders();
        //                logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
        //            }).UseNLog();  // NLog: setup NLog for Dependency injection
        //        });

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
      {
          webBuilder.UseStartup<Startup>()
                        .UseUrls("http://localhost:51044");
      })
      .ConfigureLogging(logging =>
      {
          logging.ClearProviders();
          logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
      })
      .UseNLog();  // NLog: Setup NLog for Dependency injection
    }

}
