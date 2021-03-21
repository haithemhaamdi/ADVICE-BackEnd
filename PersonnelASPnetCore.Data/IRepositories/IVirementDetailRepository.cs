using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IVirementDetailRepository
    {
        IEnumerable<VIREMENT_DETAIL> GetAllVirementDetails();
        Task<IEnumerable<VIREMENT_DETAIL>> GetAllVirementDetailsAsync();

    }
}