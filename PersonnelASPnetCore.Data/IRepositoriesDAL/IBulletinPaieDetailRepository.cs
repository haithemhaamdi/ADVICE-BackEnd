using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IBulletinPaieDetailRepository<T> : IRepositoryBaseAsync<T> where T : class
    {
        IEnumerable<BULLETIN_PAIE_DETAIL> GetAllBulletinPaieDetailsPS();
        Task<IEnumerable<BULLETIN_PAIE_DETAIL>> GetAllBulletinPaieDetailsPSAsync();
        //Task<BULLETIN_PAIE_DETAIL> GetBulletinPaieDetailPSbyNumeroBulletin(string NumeroBulletin);
        //Task<IEnumerable<BULLETIN_PAIE_DETAIL>> GetALLBulletinPaieDetailPSbyNumeroBulletin(string NumeroBulletin);
        IEnumerable<BULLETIN_PAIE_DETAIL> GetALLBulletinPaieDetailPSbyNumeroBulletin(string NumeroBulletin);


    }
}