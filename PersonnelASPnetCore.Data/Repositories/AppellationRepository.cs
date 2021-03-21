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
    public class AppellationRepository : RepositoryBase<APPELLATION>, IAppellationRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public AppellationRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateAppellation(APPELLATION Appellation)
        {
            throw new NotImplementedException();
        }

        public Task CreateAppellationAsync(APPELLATION Appellation)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppellation(APPELLATION Appellation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppellationAsync(APPELLATION Appellation)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<APPELLATION> GetAllAppellations()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<APPELLATION>> GetAllAppellationsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<APPELLATION> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public APPELLATION GetAppellationByCodeAppellation(string CodeAppellation)
        {
            throw new NotImplementedException();
        }

        public Task<APPELLATION> GetAppellationByCodeAppellationAsync(string CodeAppellation)
        {
            throw new NotImplementedException();
        }

        public APPELLATION GetAppellationByLibelleAppellation(string LibelleAppellation)
        {
            throw new NotImplementedException();
        }

        public void UpdateAppellation(APPELLATION Appellation)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppellationAsync(APPELLATION Appellation)
        {
            throw new NotImplementedException();
        }
    }
}
