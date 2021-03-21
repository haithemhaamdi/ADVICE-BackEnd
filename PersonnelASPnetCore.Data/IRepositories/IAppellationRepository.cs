using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IAppellationRepository
    {
        void CreateAppellation(APPELLATION Appellation);
        Task CreateAppellationAsync(APPELLATION Appellation);
        APPELLATION GetAppellationByCodeAppellation(string CodeAppellation);
        APPELLATION GetAppellationByLibelleAppellation(string LibelleAppellation);
        IEnumerable<APPELLATION> GetAllAppellations();
        IEnumerable<APPELLATION> GetAllWithRefernces();
        Task<IEnumerable<APPELLATION>> GetAllAppellationsAsync();
        Task<APPELLATION> GetAppellationByCodeAppellationAsync(string CodeAppellation);
        void UpdateAppellation(APPELLATION Appellation);
        Task UpdateAppellationAsync(APPELLATION Appellation);
        void DeleteAppellation(APPELLATION Appellation);
        Task DeleteAppellationAsync(APPELLATION Appellation);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
