using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class NaturePaiementRepository : RepositoryBase<NATURE_PAIEMENT>, INaturePaiementRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public NaturePaiementRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateNaturePaiement(NATURE_PAIEMENT NaturePaiement)
        {
            throw new NotImplementedException();
        }

        public Task CreateNaturePaiementAsync(NATURE_PAIEMENT NaturePaiement)
        {
            throw new NotImplementedException();
        }

        public void DeleteNaturePaiement(NATURE_PAIEMENT NaturePaiement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNaturePaiementAsync(NATURE_PAIEMENT NaturePaiement)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NATURE_PAIEMENT> GetAllNaturePaiements()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NATURE_PAIEMENT>> GetAllNaturePaiementsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NATURE_PAIEMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public NATURE_PAIEMENT GetNaturePaiementByCodeNaturePaiement(string CodeNaturePaiement)
        {
            throw new NotImplementedException();
        }

        public Task<NATURE_PAIEMENT> GetNaturePaiementByCodeNaturePaiementAsync(string CodeNaturePaiement)
        {
            throw new NotImplementedException();
        }

        public NATURE_PAIEMENT GetNaturePaiementByLibelleNaturePaiement(string LibelleNaturePaiement)
        {
            throw new NotImplementedException();
        }

        public void UpdateNaturePaiement(NATURE_PAIEMENT NaturePaiement)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNaturePaiementAsync(NATURE_PAIEMENT NaturePaiement)
        {
            throw new NotImplementedException();
        }
    }
}