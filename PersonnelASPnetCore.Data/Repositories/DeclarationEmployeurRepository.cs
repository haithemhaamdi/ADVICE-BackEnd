using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class DeclarationEmployeurRepository : RepositoryBase<DECLARATION_EMPLOYEUR>, IDeclarationEmployeurRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public DeclarationEmployeurRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateDeclarationEmployeur(DECLARATION_EMPLOYEUR DeclarationEmployeur)
        {
            throw new NotImplementedException();
        }

        public Task CreateDeclarationEmployeurAsync(DECLARATION_EMPLOYEUR DeclarationEmployeur)
        {
            throw new NotImplementedException();
        }

        public void DeleteDeclarationEmployeur(DECLARATION_EMPLOYEUR DeclarationEmployeur)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDeclarationEmployeurAsync(DECLARATION_EMPLOYEUR DeclarationEmployeur)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DECLARATION_EMPLOYEUR> GetAllDeclarationEmployeurs()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DECLARATION_EMPLOYEUR>> GetAllDeclarationEmployeursAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DECLARATION_EMPLOYEUR> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public DECLARATION_EMPLOYEUR GetDeclarationEmployeurByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<DECLARATION_EMPLOYEUR> GetDeclarationEmployeurByCodeEmployeAsync(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public DECLARATION_EMPLOYEUR GetDeclarationEmployeurByMatriculeEmploye(string MatriculeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateDeclarationEmployeur(DECLARATION_EMPLOYEUR DeclarationEmployeur)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDeclarationEmployeurAsync(DECLARATION_EMPLOYEUR DeclarationEmployeur)
        {
            throw new NotImplementedException();
        }
    }
}