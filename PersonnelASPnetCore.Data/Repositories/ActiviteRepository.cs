using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ActiviteRepository : RepositoryBase<ACTIVITE>, IActiviteRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ActiviteRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateActivite(ACTIVITE Activite)
        {
            throw new NotImplementedException();
        }

        public Task CreateActiviteAsync(ACTIVITE Activite)
        {
            throw new NotImplementedException();
        }

        public void DeleteActivite(ACTIVITE Activite)
        {
            throw new NotImplementedException();
        }

        public Task DeleteActiviteAsync(ACTIVITE Activite)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ACTIVITE GetActiviteByCodeActivite(string CodeActivite)
        {
            throw new NotImplementedException();
        }

        public Task<ACTIVITE> GetActiviteByCodeActiviteAsync(string CodeActivite)
        {
            throw new NotImplementedException();
        }

        public ACTIVITE GetActiviteByLibelleActivite(string LibelleActivite)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ACTIVITE> GetAllActivites()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ACTIVITE>> GetAllActivitesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ACTIVITE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public void UpdateActivite(ACTIVITE Activite)
        {
            throw new NotImplementedException();
        }

        public Task UpdateActiviteAsync(ACTIVITE Activite)
        {
            throw new NotImplementedException();
        }
    }
}
