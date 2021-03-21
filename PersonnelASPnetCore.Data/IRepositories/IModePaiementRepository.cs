using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IModePaiementRepository
    {
        void CreateModePaiement(MODE_PAIEMENT ModePaiement);
        Task CreateModePaiementAsync(MODE_PAIEMENT ModePaiement);
        MODE_PAIEMENT GetModePaiementByCodeModePaiement(string CodeModePaiement);
        MODE_PAIEMENT GetModePaiementByLibelleModePaiement(string LibelleModePaiement);
        IEnumerable<MODE_PAIEMENT> GetAllModePaiements();
        IEnumerable<MODE_PAIEMENT> GetAllWithRefernces();
        Task<IEnumerable<MODE_PAIEMENT>> GetAllModePaiementsAsync();
        Task<MODE_PAIEMENT> GetModePaiementByCodeModePaiementAsync(string CodeModePaiement);
        void UpdateModePaiement(MODE_PAIEMENT ModePaiement);
        Task UpdateModePaiementAsync(MODE_PAIEMENT ModePaiement);
        void DeleteModePaiement(MODE_PAIEMENT ModePaiement);
        Task DeleteModePaiementAsync(MODE_PAIEMENT ModePaiement);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}