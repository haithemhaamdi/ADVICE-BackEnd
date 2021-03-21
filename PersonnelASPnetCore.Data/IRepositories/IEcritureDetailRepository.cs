using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEcritureDetailRepository
    {
        IEnumerable<ECRITURE_DETAIL> GetAllEcritureDetails();
        Task<IEnumerable<ECRITURE_DETAIL>> GetAllEcritureDetailsAsync();
    }
}