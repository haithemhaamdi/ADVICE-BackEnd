using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ITypeContratRepository
    {
        void CreateTypeContrat(TYPE_CONTRAT TypeContrat);
        Task CreateTypeContratAsync(TYPE_CONTRAT TypeContrat);
        TYPE_CONTRAT GetTypeContratByCodeTypeContrat(string CodeTypeContrat);
        TYPE_CONTRAT GetTypeContratByLibelleTypeContrat(string LibelleTypeContrat);
        IEnumerable<TYPE_CONTRAT> GetAllTypeContrats();
        IEnumerable<TYPE_CONTRAT> GetAllWithRefernces();
        Task<IEnumerable<TYPE_CONTRAT>> GetAllTypeContratsAsync();
        Task<TYPE_CONTRAT> GetTypeContratByCodeTypeContratAsync(string CodeTypeContrat);
        void UpdateTypeContrat(TYPE_CONTRAT TypeContrat);
        Task UpdateTypeContratAsync(TYPE_CONTRAT TypeContrat);
        void DeleteTypeContrat(TYPE_CONTRAT TypeContrat);
        Task DeleteTypeContratAsync(TYPE_CONTRAT TypeContrat);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}