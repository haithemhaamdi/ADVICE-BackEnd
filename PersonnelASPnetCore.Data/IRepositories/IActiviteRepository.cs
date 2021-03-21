using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IActiviteRepository
    {
        void CreateActivite(ACTIVITE Activite);
        Task CreateActiviteAsync(ACTIVITE Activite);
        ACTIVITE GetActiviteByCodeActivite(string CodeActivite);
        ACTIVITE GetActiviteByLibelleActivite(string LibelleActivite);
        IEnumerable<ACTIVITE> GetAllActivites();
        IEnumerable<ACTIVITE> GetAllWithRefernces();
        Task<IEnumerable<ACTIVITE>> GetAllActivitesAsync();
        Task<ACTIVITE> GetActiviteByCodeActiviteAsync(string CodeActivite);
        void UpdateActivite(ACTIVITE Activite);
        Task UpdateActiviteAsync(ACTIVITE Activite);
        void DeleteActivite(ACTIVITE Activite);
        Task DeleteActiviteAsync(ACTIVITE Activite);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
