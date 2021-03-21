using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IPlanPaieDetailRepository
    {
        IEnumerable<PLAN_PAIE_DETAIL> GetAllPlanPaieDetails();
        Task<IEnumerable<PLAN_PAIE_DETAIL>> GetAllPlanPaieDetailsAsync();
    }
}