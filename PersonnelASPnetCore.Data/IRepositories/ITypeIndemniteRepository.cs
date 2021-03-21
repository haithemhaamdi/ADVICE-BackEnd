using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ITypeIndemniteRepository
    {
        void CreateTypeIndemnite(TYPE_INDEMNITE TypeIndemnite);
        Task CreateTypeIndemniteAsync(TYPE_INDEMNITE TypeIndemnite);
        TYPE_INDEMNITE GetTypeIndemniteByCodeTypeIndemnite(string CodeTypeIndemnite);
        TYPE_INDEMNITE GetTypeIndemniteByLibelleTypeIndemnite(string LibelleTypeIndemnite);
        IEnumerable<TYPE_INDEMNITE> GetAllTypeIndemnites();
        IEnumerable<TYPE_INDEMNITE> GetAllWithRefernces();
        Task<IEnumerable<TYPE_INDEMNITE>> GetAllTypeIndemnitesAsync();
        Task<TYPE_INDEMNITE> GetTypeIndemniteByCodeTypeIndemniteAsync(string CodeTypeIndemnite);
        void UpdateTypeIndemnite(TYPE_INDEMNITE TypeIndemnite);
        Task UpdateTypeIndemniteAsync(TYPE_INDEMNITE TypeIndemnite);
        void DeleteTypeIndemnite(TYPE_INDEMNITE TypeIndemnite);
        Task DeleteTypeIndemniteAsync(TYPE_INDEMNITE TypeIndemnite);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}