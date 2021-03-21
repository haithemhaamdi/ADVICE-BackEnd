using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IAvancementRepository
    {
        void CreateAvancement(AVANCEMENT Avancement);
        Task CreateAvancementAsync(AVANCEMENT Avancement);
        AVANCEMENT GetAvancementByNumeroAvancement(string NumeroAvancement);
        AVANCEMENT GetAvancementByDateAvancement(DateTime DateAvancement);
        IEnumerable<AVANCEMENT> GetAllAvancements();
        IEnumerable<AVANCEMENT> GetAllWithRefernces();
        Task<IEnumerable<AVANCEMENT>> GetAllAvancementsAsync();
        Task<AVANCEMENT> GetAvancementByNumeroAvancementAsync(string NumeroAvancement);
        void UpdateAvancement(AVANCEMENT Avancement);
        Task UpdateAvancementAsync(AVANCEMENT Avancement);
        void DeleteAvancement(AVANCEMENT Avancement);
        Task DeleteAvancementAsync(AVANCEMENT Avancement);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
