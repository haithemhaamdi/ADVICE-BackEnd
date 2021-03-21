using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class DeclarationCNSSTauxEmployeurRepository : RepositoryBase<DECLARATION_CNSS_TAUX_EMPLOYEUR>, IDeclarationCNSSTauxEmployeurRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public DeclarationCNSSTauxEmployeurRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateDeclarationCNSSTauxEmployeur(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur)
        {
            throw new NotImplementedException();
        }

        public Task CreateDeclarationCNSSTauxEmployeurAsync(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur)
        {
            throw new NotImplementedException();
        }

        public void DeleteDeclarationCNSSTauxEmployeur(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDeclarationCNSSTauxEmployeurAsync(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DECLARATION_CNSS_TAUX_EMPLOYEUR> GetAllDeclarationCNSSTauxEmployeurs()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DECLARATION_CNSS_TAUX_EMPLOYEUR>> GetAllDeclarationCNSSTauxEmployeursAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DECLARATION_CNSS_TAUX_EMPLOYEUR> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public DECLARATION_CNSS_TAUX_EMPLOYEUR GetDeclarationCNSSTauxEmployeurByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<DECLARATION_CNSS_TAUX_EMPLOYEUR> GetDeclarationCNSSTauxEmployeurByCodeEmployeAsync(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public DECLARATION_CNSS_TAUX_EMPLOYEUR GetDeclarationCNSSTauxEmployeurByDateDeclarationCNSS(DateTime DateDebut, string DateFin)
        {
            throw new NotImplementedException();
        }

        public void UpdateDeclarationCNSSTauxEmployeur(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDeclarationCNSSTauxEmployeurAsync(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur)
        {
            throw new NotImplementedException();
        }
    }
}