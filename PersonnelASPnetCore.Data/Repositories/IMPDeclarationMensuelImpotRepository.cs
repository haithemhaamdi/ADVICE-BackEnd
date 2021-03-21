using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class IMPDeclarationMensuelImpotRepository : RepositoryBase<IMP_DECLARATION_MENSUEL_IMPOT>, IIMPDeclarationMensuelImpotRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public IMPDeclarationMensuelImpotRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateIMPDeclarationMensuelImpot(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot)
        {
            throw new NotImplementedException();
        }

        public Task CreateIMPDeclarationMensuelImpotAsync(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot)
        {
            throw new NotImplementedException();
        }

        public void DeleteIMPDeclarationMensuelImpot(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIMPDeclarationMensuelImpotAsync(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMP_DECLARATION_MENSUEL_IMPOT> GetAllIMPDeclarationMensuelImpots()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IMP_DECLARATION_MENSUEL_IMPOT>> GetAllIMPDeclarationMensuelImpotsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMP_DECLARATION_MENSUEL_IMPOT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public void UpdateIMPDeclarationMensuelImpot(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIMPDeclarationMensuelImpotAsync(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot)
        {
            throw new NotImplementedException();
        }
    }
}