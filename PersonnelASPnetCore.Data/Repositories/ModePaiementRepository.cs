using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ModePaiementRepository : RepositoryBase<ModePaiementRepository>, IModePaiementRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ModePaiementRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateModePaiement(MODE_PAIEMENT ModePaiement)
        {
            throw new NotImplementedException();
        }

        public Task CreateModePaiementAsync(MODE_PAIEMENT ModePaiement)
        {
            throw new NotImplementedException();
        }

        public void DeleteModePaiement(MODE_PAIEMENT ModePaiement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteModePaiementAsync(MODE_PAIEMENT ModePaiement)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODE_PAIEMENT> GetAllModePaiements()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MODE_PAIEMENT>> GetAllModePaiementsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODE_PAIEMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public MODE_PAIEMENT GetModePaiementByCodeModePaiement(string CodeModePaiement)
        {
            throw new NotImplementedException();
        }

        public Task<MODE_PAIEMENT> GetModePaiementByCodeModePaiementAsync(string CodeModePaiement)
        {
            throw new NotImplementedException();
        }

        public MODE_PAIEMENT GetModePaiementByLibelleModePaiement(string LibelleModePaiement)
        {
            throw new NotImplementedException();
        }

        public void UpdateModePaiement(MODE_PAIEMENT ModePaiement)
        {
            throw new NotImplementedException();
        }

        public Task UpdateModePaiementAsync(MODE_PAIEMENT ModePaiement)
        {
            throw new NotImplementedException();
        }
    }
}