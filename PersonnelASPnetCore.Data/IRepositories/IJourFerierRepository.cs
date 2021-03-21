using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IJourFerierRepository
    {
        void CreateJourFerier(JOUR_FERIE JourFerier);
        Task CreateJourFerierAsync(JOUR_FERIE JourFerier);
        JOUR_FERIE GetJourFerierByCodeJourFerie(string CodeJourFerie);
        JOUR_FERIE GetJourFerierByLibelleJourFerie(string LibelleJourFerie);
        IEnumerable<JOUR_FERIE> GetAllJourFeriers();
        IEnumerable<JOUR_FERIE> GetAllWithRefernces();
        Task<IEnumerable<JOUR_FERIE>> GetAllJourFeriersAsync();
        Task<JOUR_FERIE> GetJourFerierByCodeJourFerieAsync(string CodeJourFerie);
        void UpdateJourFerier(JOUR_FERIE JourFerier);
        Task UpdateJourFerierAsync(JOUR_FERIE JourFerier);
        void DeleteJourFerier(JOUR_FERIE JourFerier);
        Task DeleteJourFerierAsync(JOUR_FERIE JourFerier);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}