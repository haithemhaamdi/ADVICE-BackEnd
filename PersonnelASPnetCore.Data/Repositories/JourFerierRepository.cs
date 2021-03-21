using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class JourFerierRepository : RepositoryBase<JOUR_FERIE>, IJourFerierRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public JourFerierRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateJourFerier(JOUR_FERIE JourFerier)
        {
            throw new NotImplementedException();
        }

        public Task CreateJourFerierAsync(JOUR_FERIE JourFerier)
        {
            throw new NotImplementedException();
        }

        public void DeleteJourFerier(JOUR_FERIE JourFerier)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJourFerierAsync(JOUR_FERIE JourFerier)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JOUR_FERIE> GetAllJourFeriers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JOUR_FERIE>> GetAllJourFeriersAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JOUR_FERIE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public JOUR_FERIE GetJourFerierByCodeJourFerie(string CodeJourFerie)
        {
            throw new NotImplementedException();
        }

        public Task<JOUR_FERIE> GetJourFerierByCodeJourFerieAsync(string CodeJourFerie)
        {
            throw new NotImplementedException();
        }

        public JOUR_FERIE GetJourFerierByLibelleJourFerie(string LibelleJourFerie)
        {
            throw new NotImplementedException();
        }

        public void UpdateJourFerier(JOUR_FERIE JourFerier)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJourFerierAsync(JOUR_FERIE JourFerier)
        {
            throw new NotImplementedException();
        }
    }
}