using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ISiteRepository
    {
        void CreateSite(SITE Site);
        Task CreateSiteAsync(SITE Site);
        SITE GetSiteByCodeSite(string CodeSite);
        SITE GetSiteByLibelleSite(string LibelleSite);
        IEnumerable<SITE> GetAllSites();
        IEnumerable<SITE> GetAllWithRefernces();
        Task<IEnumerable<SITE>> GetAllSitesAsync();
        Task<SITE> GetSiteByCodeSiteAsync(string CodeSite);
        void UpdateSite(SITE Site);
        Task UpdateSiteAsync(SITE Site);
        void DeleteSite(SITE Site);
        Task DeleteSiteAsync(SITE Site);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}