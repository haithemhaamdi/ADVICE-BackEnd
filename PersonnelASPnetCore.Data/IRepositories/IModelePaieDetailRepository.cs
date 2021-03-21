using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IModelePaieDetailRepository
    {
        IEnumerable<MODELE_PAIE_DETAIL> GetAllModelePaieDetails();
        Task<IEnumerable<MODELE_PAIE_DETAIL>> GetAllModelePaieDetailsAsync();
    }
}