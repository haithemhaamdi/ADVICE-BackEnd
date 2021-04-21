using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using PersonnelASPnetCore.Data;
using PersonnelASPnetCore.Data.Helper;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Data.Logger;
using PersonnelASPnetCore.Data.RepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Service.ServiceManagmentImplementation;
using PersonnelASPnetCore.Service.ServiceManagmentInterface;


namespace PersonnelASPnetCoreAPI
{

    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;
        //public IConfiguration _configuration { get; }
        private readonly IUSERService uService;
        private readonly IRoleRepository rService;

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }

        //readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region session timeout 
            services.AddDistributedMemoryCache();

            services.AddSession();

            //redirect to login page after session timeout RSS
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(3);
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = ".ToolsAppSession";
            });
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromSeconds(20);
                options.LoginPath = "/Users/authenticate";
                options.LogoutPath = "/Users/Logout";
                options.AccessDeniedPath = "Users/authenticate";
                options.SlidingExpiration = true;
                options.Cookie.Name = ".ToolsApp";
            });
            services.AddMemoryCache();

            #endregion
            #region GetConnectionString
            // use sql server db in production and in development
            if (_env.IsProduction())
                services.AddDbContext<ARTIPERSONNEL_SOC001Context>();
            else
                services.AddDbContext<ARTIPERSONNEL_SOC001Context>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            #endregion

            services.AddControllers();
            //services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);

            services.AddControllers(
                setupAction =>
                {
                    //setupAction.ReturnHttpNotAcceptable = true; //406 Not acceptable
                    setupAction.RespectBrowserAcceptHeader = true; // false by default

                    //setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                }).AddXmlDataContractSerializerFormatters(); //{Key,Value}=>{Accept, application/xml }

            #region AddSingleton
            //services.AddSingleton<ILoggerManager>((container) =>
            //{
            //    var logger = container.GetRequiredService<ILogger<LoggerManager>>();
            //    return new LoggerManager() { Logger = logger };
            //,"http://localhost:51044/api/"
            //});

            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS",
                builder =>
                {
                    builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
                });
            });
            #endregion

            #region AppSettings
            // configure strongly typed settings objects
            var appSettingsSection = _configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            #endregion

            #region Log
            services.AddSingleton<ILoggerManager, LoggerManager>();
            #endregion

            #region Authentication [1]
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        //options.TokenValidationParameters = new TokenValidationParameters
            //        //{
            //        //    ValidateIssuerSigningKey = true,
            //        //    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
            //        //        .GetBytes(_configuration.GetSection("AppSettings:Token").Value)),
            //        //    ValidateIssuer = false,
            //        //    ValidateAudience = false
            //        //};
            //        options.RequireHttpsMetadata = false;
            //        options.SaveToken = true;
            //        options.TokenValidationParameters = new TokenValidationParameters()
            //        {
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //            ValidAudience = _configuration["Jwt:Audience"],
            //            ValidIssuer = _configuration["Jwt:Issuer"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]))
            //        };
            //    });


            //// configure basic authentication 
            //services.AddAuthentication("BasicAuthentication")
            //    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            #endregion

            #region Authentication [2]
            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.SaveToken = true;
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var userService = context.HttpContext.RequestServices.GetRequiredService<IUSERService>();
                        var roleService = context.HttpContext.RequestServices.GetRequiredService<IRoleRepository>();

                        //codeUser => CodeEmploye
                        var codeUser = context.Principal.Identity.Name;
                        var user = userService.GetUserByCode(codeUser);
                        var role = roleService.GetRoleByUserCodePS(codeUser);
                        if (user == null)
                        {
                            // return unauthorized if user no longer exists
                            context.Fail("Unauthorized");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero


                };
            });
            #endregion

            #region Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfiles());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            #region AutoMapper with AutoMapper.Extensions.Microsoft.DependencyInjection
            //The parameterless services.AddAutoMapper()(that had the @saineshwar answer) doesn't work anymore (at least for me).
            //But if you use the NuGet assembly AutoMapper.Extensions.Microsoft.DependencyInjection,
            //the framework is able to inspect all the classes that extend AutoMapper.Profile (like mine, MappingProfile).
            #endregion
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            #endregion

            #region Context and DesignPattern

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            #endregion

            #region service Managment
            services.AddScoped<IEMPLOYEService, EMPLOYEService>();
            services.AddScoped<IUSERService, USERService>();
            #endregion

            #region IRepositoriesDAL/RepositoriesDAL


            #endregion

            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository<USER>, UserRepository<USER>>();
            services.AddScoped<IConnectionHistoryRepository<CONNECTIONS_HISTORY>, ConnectionHistoryRepository<CONNECTIONS_HISTORY>>();
            services.AddScoped<IActiviteRepository, ActiviteRepository>();
            //services.AddScoped<IAppellationRepository, AppellationRepository>();
            //services.AddScoped<IAvancement_DetailRepository, Avancement_DetailRepository>();
            //services.AddScoped<IAvancementRepository, AvancementRepository>();
            //services.AddScoped<IBanqueRepository, BanqueRepository>();
            //services.AddScoped<IBanqueVirementRepository, BanqueVirementRepository>();
            //services.AddScoped<IBaremeImportRepository, BaremeImportRepository>();
            //services.AddScoped<IBaremeSMIGRepository, BaremeSMIGRepository>();
            //services.AddScoped<IBordereauRepository, BordereauRepository>();
            services.AddScoped<IBulletin_PaieRepository<BULLETIN_PAIE>, Bulletin_PaieRepository<BULLETIN_PAIE>>();
            services.AddScoped<IBulletinPaieDetailRepository<BULLETIN_PAIE_DETAIL>, BulletinPaieDetailRepository<BULLETIN_PAIE_DETAIL>>();
            //services.AddScoped<ICompteComptableRepository, ICompteComptableRepository>();
            //services.AddScoped<IDeclarationCNSSDetailRepository, IDeclarationCNSSDetailRepository>();
            //services.AddScoped<IDeclarationCNSSRepository, IDeclarationCNSSRepository>();
            //services.AddScoped<IDeclarationCNSSTauxEmployeurRepository, IDeclarationCNSSTauxEmployeurRepository>();
            //services.AddScoped<IDeclarationEmployeurRepository, IDeclarationEmployeurRepository>();
            //services.AddScoped<IDecompteMonnaieRepository, IDecompteMonnaieRepository>();
            //services.AddScoped<IDepartementRepository, IDepartementRepository>();
            //services.AddScoped<IEcritureDetailRepository, IEcritureDetailRepository>();
            //services.AddScoped<IEcritureOuvertureRepository, IEcritureOuvertureRepository>();
            //services.AddScoped<IEcritureRepository, IEcritureRepository>();
            //services.AddScoped<IEmployeAbsenceRepository, IEmployeAbsenceRepository>();
            //services.AddScoped<IEmployeAChargeRepository, IEmployeAChargeRepository>();
            //services.AddScoped<IEmployeAffichageGrilleRepository, IEmployeAffichageGrilleRepository>();
            //services.AddScoped<IEmployeAjustementCongeRepository, IEmployeAjustementCongeRepository>();
            //services.AddScoped<IEmployeAvanceRepository, IEmployeAvanceRepository>();
            //services.AddScoped<IEmployeCongeRepository, IEmployeCongeRepository>();
            //services.AddScoped<IEmployeContratRepository, IEmployeContratRepository>();
            //services.AddScoped<IEmployeCorrespondanceRepository, IEmployeCorrespondanceRepository>();
            //services.AddScoped<IEmployeDeductionRepository, IEmployeDeductionRepository>();
            //services.AddScoped<IEmployeDesciplineRepository, IEmployeDesciplineRepository>();
            //services.AddScoped<IEmployeDocumentRepository, IEmployeDocumentRepository>();
            //services.AddScoped<IEmployeFonctionRepository, IEmployeFonctionRepository>();
            //services.AddScoped<IEmployeFormationRepository, IEmployeFormationRepository>();
            //services.AddScoped<IEmployeObservationRepository, IEmployeObservationRepository>();
            //services.AddScoped<IEmployePretRepository, IEmployePretRepository>();
            services.AddScoped<IEmployeRepository<EMPLOYE>, EmployeRepository<EMPLOYE>>();
            //services.AddScoped<IEmployeRubriqueRepository, IEmployeRubriqueRepository>();
            //services.AddScoped<IEmployeSituationCongeSpecialRepository, IEmployeSituationCongeSpecialRepository>();
            //services.AddScoped<IEmployeTypeContratRepository, IEmployeTypeContratRepository>();
            //services.AddScoped<IEmployeTypePeriodeRepository, IEmployeTypePeriodeRepository>();
            //services.AddScoped<IEmployeTypePretRepository, IEmployeTypePretRepository>();
            //services.AddScoped<IEmployeVentilationRepository, IEmployeVentilationRepository>();
            //services.AddScoped<IGilleDetailRepository, IGilleDetailRepository>();
            //services.AddScoped<IIMPCavisRepository, IIMPCavisRepository>();
            //services.AddScoped<IIMPDeclarationAssuranceRepository, IIMPDeclarationAssuranceRepository>();
            //services.AddScoped<IIMPDeclarationMensuelImpotRepository, IIMPDeclarationMensuelImpotRepository>();
            //services.AddScoped<IIMPFicheAnnuellePaieRepository, IIMPFicheAnnuellePaieRepository>();
            //services.AddScoped<IJourFerierRepository, IJourFerierRepository>();
            //services.AddScoped<IJournalComptableRepository, IJournalComptableRepository>();
            //services.AddScoped<IListeRapportRepository, IListeRapportRepository>();
            //services.AddScoped<IModeleCorrespondanceRepository, IModeleCorrespondanceRepository>();
            //services.AddScoped<IModelePaieDetailRepository, IModelePaieDetailRepository>();
            //services.AddScoped<IModelePaieRepository, IModelePaieRepository>();
            //services.AddScoped<IModePaiementRepository, IModePaiementRepository>();
            //services.AddScoped<INaturePaiementRepository, INaturePaiementRepository>();
            //services.AddScoped<IParametreComptabiliteRepository, IParametreComptabiliteRepository>();
            //services.AddScoped<IParametrePointageRepository, IParametrePointageRepository>();
            //services.AddScoped<IPlanPaieDetailRepository, IPlanPaieDetailRepository>();
            //services.AddScoped<IPlanPaieRepository, IPlanPaieRepository>();
            //services.AddScoped<IPointageRepository, IPointageRepository>();
            //services.AddScoped<IRoleRepository, IRoleRepository>();
            //services.AddScoped<IRubriqueRepository, IRubriqueRepository>();
            //services.AddScoped<ISequenceRepository, ISequenceRepository>();
            //services.AddScoped<ISiteRepository, ISiteRepository>();
            //services.AddScoped<ISituationCongeRepository, ISituationCongeRepository>();
            ////services.AddScoped<ITypeIndemniteRepository, TypeIndemniteRepository>();
            //services.AddScoped<ITypeRubriqueRepository, ITypeRubriqueRepository>();
            services.AddScoped<IVirementDetailRepository<VIREMENT_DETAIL>, VirementDetailRepository<VIREMENT_DETAIL>>();
            //services.AddScoped<IVirementRepository, IVirementRepository>();
            #region 

            #endregion
            #region Authorization
            services.AddAuthorization(options => options.AddPolicy("ADMIN", builder =>
            {
                builder.RequireAssertion(async context =>
                {
                    string strUserId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);

                    USER user = uService.GetUserByCode(strUserId);
                    ROLE role = await rService.GetRoleByUserCodePS(user.CodeEmploye);

                    return role.Name.Contains("Admin");
                });
            }));

            #endregion



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                logger.LogInformation("In Development environment");
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            //app.UseCors("EnableCORS");

            // global cors policy
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCookiePolicy();
            app.UseStaticFiles();

            app.UseSession();

            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Unauthorized ||
                    response.StatusCode == (int)HttpStatusCode.Forbidden)
                    response.Redirect("/Authentication");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}
