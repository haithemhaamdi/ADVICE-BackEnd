using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBulletinPaieDetailRepository
    {
        IEnumerable<BULLETIN_PAIE_DETAIL> GetAllBulletinPaieDetailDetails();
        Task<IEnumerable<BULLETIN_PAIE_DETAIL>> GetAllBulletinPaieDetailsAsync();
    }
}