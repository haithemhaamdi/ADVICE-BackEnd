using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class IMPCavisRepository : RepositoryBase<IMP_CAVIS>, IIMPCavisRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public IMPCavisRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateIMPCavis(IMP_CAVIS IMPCavis)
        {
            throw new NotImplementedException();
        }

        public Task CreateIMPCavisAsync(IMP_CAVIS IMPCavis)
        {
            throw new NotImplementedException();
        }

        public void DeleteIMPCavis(IMP_CAVIS IMPCavis)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIMPCavisAsync(IMP_CAVIS IMPCavis)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMP_CAVIS> GetAllIMPCaviss()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IMP_CAVIS>> GetAllIMPCavissAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMP_CAVIS> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public IMP_CAVIS GetIMPCavisByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public IMP_CAVIS GetIMPCavisByMatriculeSecuriteSociale(string MatriculeSecuriteSociale)
        {
            throw new NotImplementedException();
        }

        public Task<IMP_CAVIS> GetIMPCavisByNumeroIMPCavisAsync(string NumeroIMPCavis)
        {
            throw new NotImplementedException();
        }

        public void UpdateIMPCavis(IMP_CAVIS IMPCavis)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIMPCavisAsync(IMP_CAVIS IMPCavis)
        {
            throw new NotImplementedException();
        }
    }
}