using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class SiteRepository : RepositoryBase<SITE>, ISiteRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public SiteRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void CreateSite(SITE Site)
        {
            throw new NotImplementedException();
        }

        public Task CreateSiteAsync(SITE Site)
        {
            throw new NotImplementedException();
        }

        public void DeleteSite(SITE Site)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSiteAsync(SITE Site)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SITE> GetAllSites()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SITE>> GetAllSitesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SITE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public SITE GetSiteByCodeSite(string CodeSite)
        {
            throw new NotImplementedException();
        }

        public Task<SITE> GetSiteByCodeSiteAsync(string CodeSite)
        {
            throw new NotImplementedException();
        }

        public SITE GetSiteByLibelleSite(string LibelleSite)
        {
            throw new NotImplementedException();
        }

        public void UpdateSite(SITE Site)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSiteAsync(SITE Site)
        {
            throw new NotImplementedException();
        }
    }
}