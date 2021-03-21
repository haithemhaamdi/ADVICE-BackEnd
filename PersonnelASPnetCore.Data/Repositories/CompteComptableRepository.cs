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
    public class CompteComptableRepository : RepositoryBase<COMPTE_COMPTABLE>, ICompteComptableRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public CompteComptableRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateCompteComptable(COMPTE_COMPTABLE CompteComptable)
        {
            throw new NotImplementedException();
        }

        public Task CreateCompteComptableAsync(COMPTE_COMPTABLE CompteComptable)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompteComptable(COMPTE_COMPTABLE CompteComptable)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCompteComptableAsync(COMPTE_COMPTABLE CompteComptable)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<COMPTE_COMPTABLE> GetAllCompteComptable()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<COMPTE_COMPTABLE>> GetAllCompteComptableAsync()
        {
            throw new NotImplementedException();
        }

        public COMPTE_COMPTABLE GetCompteComptableByLibelle(string LibelleCompteComptable)
        {
            throw new NotImplementedException();
        }

        public Task<COMPTE_COMPTABLE> GetCompteComptableByLibelleAsync(string LibelleCompteComptable)
        {
            throw new NotImplementedException();
        }

        public COMPTE_COMPTABLE GetCompteComptableByNumero(string NumeroCompteComptable)
        {
            throw new NotImplementedException();
        }

        public Task<COMPTE_COMPTABLE> GetCompteComptableByNumeroAsync(string NumeroCompteComptable)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompteComptable(COMPTE_COMPTABLE CompteComptable)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompteComptableAsync(COMPTE_COMPTABLE CompteComptable)
        {
            throw new NotImplementedException();
        }
    }
}
