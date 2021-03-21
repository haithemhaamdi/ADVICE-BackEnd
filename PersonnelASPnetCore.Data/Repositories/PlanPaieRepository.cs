using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class PlanPaieRepository : RepositoryBase<PLAN_PAIE>, IPlanPaieRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public PlanPaieRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void CreatePlanPaie(PLAN_PAIE PlanPaie)
        {
            throw new NotImplementedException();
        }

        public Task CreatePlanPaieAsync(PLAN_PAIE PlanPaie)
        {
            throw new NotImplementedException();
        }

        public void DeletePlanPaie(PLAN_PAIE PlanPaie)
        {
            throw new NotImplementedException();
        }

        public Task DeletePlanPaieAsync(PLAN_PAIE PlanPaie)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PLAN_PAIE> GetAllPlanPaies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PLAN_PAIE>> GetAllPlanPaiesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PLAN_PAIE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public PLAN_PAIE GetPlanPaieByCodePlan(string CodePlan)
        {
            throw new NotImplementedException();
        }

        public Task<PLAN_PAIE> GetPlanPaieByCodePlanAsync(string CodePlan)
        {
            throw new NotImplementedException();
        }

        public PLAN_PAIE GetPlanPaieByDatePlanPaie(string LibellePlan)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlanPaie(PLAN_PAIE PlanPaie)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePlanPaieAsync(PLAN_PAIE PlanPaie)
        {
            throw new NotImplementedException();
        }
    }
}