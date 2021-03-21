using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class IMPDeclarationAssuranceRepository : RepositoryBase<IMP_DECLARATION_ASSURANCE>, IIMPDeclarationAssuranceRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public IMPDeclarationAssuranceRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        public void CreateIMPDeclarationAssurance(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateIMPDeclarationAssuranceAsync(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteIMPDeclarationAssurance(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteIMPDeclarationAssuranceAsync(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IMP_DECLARATION_ASSURANCE> GetAllIMPDeclarationAssurances()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<IMP_DECLARATION_ASSURANCE>> GetAllIMPDeclarationAssurancesAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IMP_DECLARATION_ASSURANCE> GetAllWithRefernces()
        {
            throw new System.NotImplementedException();
        }

        public IMP_DECLARATION_ASSURANCE GetIMPDeclarationAssuranceByCodeEmploye(string CodeEmploye)
        {
            throw new System.NotImplementedException();
        }

        public Task<IMP_DECLARATION_ASSURANCE> GetIMPDeclarationAssuranceByCodeEmployeAsync(string CodeEmploye)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateIMPDeclarationAssurance(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateIMPDeclarationAssuranceAsync(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance)
        {
            throw new System.NotImplementedException();
        }
    }
}