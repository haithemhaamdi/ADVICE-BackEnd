using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IPlanPaieRepository
    {
        void CreatePlanPaie(PLAN_PAIE PlanPaie);
        Task CreatePlanPaieAsync(PLAN_PAIE PlanPaie);
        PLAN_PAIE GetPlanPaieByCodePlan(string CodePlan);
        PLAN_PAIE GetPlanPaieByDatePlanPaie(string LibellePlan);
        IEnumerable<PLAN_PAIE> GetAllPlanPaies();
        IEnumerable<PLAN_PAIE> GetAllWithRefernces();
        Task<IEnumerable<PLAN_PAIE>> GetAllPlanPaiesAsync();
        Task<PLAN_PAIE> GetPlanPaieByCodePlanAsync(string CodePlan);
        void UpdatePlanPaie(PLAN_PAIE PlanPaie);
        Task UpdatePlanPaieAsync(PLAN_PAIE PlanPaie);
        void DeletePlanPaie(PLAN_PAIE PlanPaie);
        Task DeletePlanPaieAsync(PLAN_PAIE PlanPaie);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}