using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class VirementRepository : RepositoryBase<VIREMENT>, IVirementRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public VirementRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateVirement(VIREMENT Virement)
        {
            throw new NotImplementedException();
        }

        public Task CreateVirementAsync(VIREMENT Virement)
        {
            throw new NotImplementedException();
        }

        public void DeleteVirement(VIREMENT Virement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteVirementAsync(VIREMENT Virement)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VIREMENT> GetAllVirements()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VIREMENT>> GetAllVirementsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VIREMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public VIREMENT GetVirementByDateVirement(DateTime DateVirement)
        {
            throw new NotImplementedException();
        }

        public VIREMENT GetVirementByNumeroVirement(string NumeroVirement)
        {
            throw new NotImplementedException();
        }

        public Task<VIREMENT> GetVirementByNumeroVirementAsync(string NumeroVirement)
        {
            throw new NotImplementedException();
        }

        public void UpdateVirement(VIREMENT Virement)
        {
            throw new NotImplementedException();
        }

        public Task UpdateVirementAsync(VIREMENT Virement)
        {
            throw new NotImplementedException();
        }
    }
}