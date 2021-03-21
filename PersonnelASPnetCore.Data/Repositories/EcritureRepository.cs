using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EcritureRepository : RepositoryBase<ECRITURE>, IEcritureRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EcritureRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEcriture(ECRITURE Ecriture)
        {
            throw new NotImplementedException();
        }

        public Task CreateEcritureAsync(ECRITURE Ecriture)
        {
            throw new NotImplementedException();
        }

        public void DeleteEcriture(ECRITURE Ecriture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEcritureAsync(ECRITURE Ecriture)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ECRITURE> GetAllEcritures()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ECRITURE>> GetAllEcrituresAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ECRITURE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public ECRITURE GetEcritureByDateEcriture(DateTime DateEcriture)
        {
            throw new NotImplementedException();
        }

        public ECRITURE GetEcritureByNumeroEcriture(string NumeroEcriture)
        {
            throw new NotImplementedException();
        }

        public Task<ECRITURE> GetEcritureByNumeroEcritureAsync(string NumeroEcriture)
        {
            throw new NotImplementedException();
        }

        public void UpdateEcriture(ECRITURE Ecriture)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEcritureAsync(ECRITURE Ecriture)
        {
            throw new NotImplementedException();
        }
    }
}