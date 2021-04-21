using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IVirementDetailRepository<T> : IRepositoryBaseAsync<T> where T : class
    {
        IEnumerable<VIREMENT_DETAIL> GetAllVIREMENT_DETAILsPS();
        Task<IEnumerable<VIREMENT_DETAIL>> GetAllVIREMENT_DETAILsPSAsync();
        Task<VIREMENT_DETAIL> GetVIREMENT_DETAILsPSbyNumeroBulletin(string NumeroBulletin);
    }
}