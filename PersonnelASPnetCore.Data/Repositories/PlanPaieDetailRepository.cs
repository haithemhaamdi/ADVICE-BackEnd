using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class PlanPaieDetailRepository : RepositoryBase<PLAN_PAIE_DETAIL>, IPlanPaieDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public PlanPaieDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PLAN_PAIE_DETAIL> GetAllPlanPaieDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PLAN_PAIE_DETAIL>> GetAllPlanPaieDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}