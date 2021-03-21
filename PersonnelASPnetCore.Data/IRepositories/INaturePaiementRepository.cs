using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface INaturePaiementRepository
    {
        void CreateNaturePaiement(NATURE_PAIEMENT NaturePaiement);
        Task CreateNaturePaiementAsync(NATURE_PAIEMENT NaturePaiement);
        NATURE_PAIEMENT GetNaturePaiementByCodeNaturePaiement(string CodeNaturePaiement);
        NATURE_PAIEMENT GetNaturePaiementByLibelleNaturePaiement(string LibelleNaturePaiement);
        IEnumerable<NATURE_PAIEMENT> GetAllNaturePaiements();
        IEnumerable<NATURE_PAIEMENT> GetAllWithRefernces();
        Task<IEnumerable<NATURE_PAIEMENT>> GetAllNaturePaiementsAsync();
        Task<NATURE_PAIEMENT> GetNaturePaiementByCodeNaturePaiementAsync(string CodeNaturePaiement);
        void UpdateNaturePaiement(NATURE_PAIEMENT NaturePaiement);
        Task UpdateNaturePaiementAsync(NATURE_PAIEMENT NaturePaiement);
        void DeleteNaturePaiement(NATURE_PAIEMENT NaturePaiement);
        Task DeleteNaturePaiementAsync(NATURE_PAIEMENT NaturePaiement);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}