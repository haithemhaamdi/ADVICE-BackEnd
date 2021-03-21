using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBanqueRepository
    {
        void CreateBanque(BANQUE Banque);
        Task CreateBanqueAsync(BANQUE Banque);
        BANQUE GetBanqueByCodeBanque(string CodeBanque);
        BANQUE GetBanqueByLibelleBanque(string LibelleBanque);
        IEnumerable<BANQUE> GetAllBanques();
        IEnumerable<BANQUE> GetAllWithRefernces();
        Task<IEnumerable<BANQUE>> GetAllBanquesAsync();
        Task<BANQUE> GetBanqueByCodeBanqueAsync(string CodeBanque);
        void UpdateBanque(BANQUE Banque);
        Task UpdateBanqueAsync(BANQUE Banque);
        void DeleteBanque(BANQUE Banque);
        Task DeleteBanqueAsync(BANQUE Banque);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
