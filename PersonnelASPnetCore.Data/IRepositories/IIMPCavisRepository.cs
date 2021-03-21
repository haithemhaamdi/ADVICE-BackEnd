using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IIMPCavisRepository
    {
        void CreateIMPCavis(IMP_CAVIS IMPCavis);
        Task CreateIMPCavisAsync(IMP_CAVIS IMPCavis);
        IMP_CAVIS GetIMPCavisByCodeEmploye(string CodeEmploye);
        IMP_CAVIS GetIMPCavisByMatriculeSecuriteSociale(string MatriculeSecuriteSociale);
        IEnumerable<IMP_CAVIS> GetAllIMPCaviss();
        IEnumerable<IMP_CAVIS> GetAllWithRefernces();
        Task<IEnumerable<IMP_CAVIS>> GetAllIMPCavissAsync();
        Task<IMP_CAVIS> GetIMPCavisByNumeroIMPCavisAsync(string NumeroIMPCavis);
        void UpdateIMPCavis(IMP_CAVIS IMPCavis);
        Task UpdateIMPCavisAsync(IMP_CAVIS IMPCavis);
        void DeleteIMPCavis(IMP_CAVIS IMPCavis);
        Task DeleteIMPCavisAsync(IMP_CAVIS IMPCavis);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}