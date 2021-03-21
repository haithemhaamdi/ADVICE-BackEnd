using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IGilleDetailRepository
    {
        IEnumerable<GRILLE_DETAIL> GetAllGilleDetails();
        Task<IEnumerable<GRILLE_DETAIL>> GetAllGilleDetailsAsync();
    }
}