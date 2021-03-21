using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EcritureOuvertureRepository : RepositoryBase<ECRITURE_OUVERTURE>, IEcritureOuvertureRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EcritureOuvertureRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEcritureOuverture(ECRITURE_OUVERTURE EcritureOuverture)
        {
            throw new NotImplementedException();
        }

        public Task CreateEcritureOuvertureAsync(ECRITURE_OUVERTURE EcritureOuverture)
        {
            throw new NotImplementedException();
        }

        public void DeleteEcritureOuverture(ECRITURE_OUVERTURE EcritureOuverture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEcritureOuvertureAsync(ECRITURE_OUVERTURE EcritureOuverture)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ECRITURE_OUVERTURE> GetAllEcritureOuvertures()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ECRITURE_OUVERTURE>> GetAllEcritureOuverturesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ECRITURE_OUVERTURE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public ECRITURE_OUVERTURE GetEcritureOuvertureByLibelleCompteComptable(string LibelleCompteComptable)
        {
            throw new NotImplementedException();
        }

        public ECRITURE_OUVERTURE GetEcritureOuvertureByNumeroCompteComptable(string NumeroCompteComptable)
        {
            throw new NotImplementedException();
        }

        public Task<ECRITURE_OUVERTURE> GetEcritureOuvertureByNumeroCompteComptableAsync(string NumeroCompteComptable)
        {
            throw new NotImplementedException();
        }

        public void UpdateEcritureOuverture(ECRITURE_OUVERTURE EcritureOuverture)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEcritureOuvertureAsync(ECRITURE_OUVERTURE EcritureOuverture)
        {
            throw new NotImplementedException();
        }
    }
}