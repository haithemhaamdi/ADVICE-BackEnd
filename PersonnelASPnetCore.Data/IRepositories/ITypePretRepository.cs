using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ITypePretRepository
    {
        void CreateTypePret(TYPE_PRET TypePret);
        Task CreateTypePretAsync(TYPE_PRET TypePret);
        TYPE_PRET GetTypePretByCodeTypePret(string CodeTypePret);
        TYPE_PRET GetTypePretByLibelleTypePret(string LibelleTypePret);
        IEnumerable<TYPE_PRET> GetAllTypePrets();
        IEnumerable<TYPE_PRET> GetAllWithRefernces();
        Task<IEnumerable<TYPE_PRET>> GetAllTypePretsAsync();
        Task<TYPE_PRET> GetTypePretByCodeTypePretAsync(string CodeTypePret);
        void UpdateTypePret(TYPE_PRET TypePret);
        Task UpdateTypePretAsync(TYPE_PRET TypePret);
        void DeleteTypePret(TYPE_PRET TypePret);
        Task DeleteTypePretAsync(TYPE_PRET TypePret);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}