using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBanqueVirementRepository
    {
        void CreateBanqueVirement(BANQUE_VIREMENT BanqueVirement);
        Task CreateBanqueVirementAsync(BANQUE_VIREMENT BanqueVirement);
        BANQUE_VIREMENT GetBanqueVirementByCodeBanqueVirement(string CodeBanqueVirement);
        BANQUE_VIREMENT GetBanqueVirementByLibelleBanqueVirement(string LibelleBanqueVirement);
        IEnumerable<BANQUE_VIREMENT> GetAllBanqueVirements();
        IEnumerable<BANQUE_VIREMENT> GetAllWithRefernces();
        Task<IEnumerable<BANQUE_VIREMENT>> GetAllBanqueVirementsAsync();
        Task<BANQUE_VIREMENT> GetBanqueVirementByCodeBanqueVirementAsync(string CodeBanqueVirement);
        void UpdateBanqueVirement(BANQUE_VIREMENT BanqueVirement);
        Task UpdateBanqueVirementAsync(BANQUE_VIREMENT BanqueVirement);
        void DeleteBanqueVirement(BANQUE_VIREMENT BanqueVirement);
        Task DeleteBanqueVirementAsync(BANQUE_VIREMENT BanqueVirement);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
