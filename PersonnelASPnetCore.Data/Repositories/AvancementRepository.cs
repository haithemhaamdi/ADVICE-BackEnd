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
    public class AvancementRepository : RepositoryBase<AVANCEMENT>, IAvancementRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public AvancementRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateAvancement(AVANCEMENT Avancement)
        {
            throw new NotImplementedException();
        }

        public Task CreateAvancementAsync(AVANCEMENT Avancement)
        {
            throw new NotImplementedException();
        }

        public void DeleteAvancement(AVANCEMENT Avancement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAvancementAsync(AVANCEMENT Avancement)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AVANCEMENT> GetAllAvancements()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AVANCEMENT>> GetAllAvancementsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AVANCEMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public AVANCEMENT GetAvancementByDateAvancement(DateTime DateAvancement)
        {
            throw new NotImplementedException();
        }

        public AVANCEMENT GetAvancementByNumeroAvancement(string NumeroAvancement)
        {
            throw new NotImplementedException();
        }

        public Task<AVANCEMENT> GetAvancementByNumeroAvancementAsync(string NumeroAvancement)
        {
            throw new NotImplementedException();
        }

        public void UpdateAvancement(AVANCEMENT Avancement)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAvancementAsync(AVANCEMENT Avancement)
        {
            throw new NotImplementedException();
        }
    }
}
