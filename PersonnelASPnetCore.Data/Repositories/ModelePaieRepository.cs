using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ModelePaieRepository : RepositoryBase<MODELE_PAIE>, IModelePaieRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ModelePaieRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateModelePaie(MODELE_PAIE ModelePaie)
        {
            throw new NotImplementedException();
        }

        public Task CreateModelePaieAsync(MODELE_PAIE ModelePaie)
        {
            throw new NotImplementedException();
        }

        public void DeleteModelePaie(MODELE_PAIE ModelePaie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteModelePaieAsync(MODELE_PAIE ModelePaie)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODELE_PAIE> GetAllModelePaies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MODELE_PAIE>> GetAllModelePaiesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODELE_PAIE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public MODELE_PAIE GetModelePaieByDateModelePaie(DateTime DateModelePaie)
        {
            throw new NotImplementedException();
        }

        public MODELE_PAIE GetModelePaieByNumeroModelePaie(string NumeroModelePaie)
        {
            throw new NotImplementedException();
        }

        public Task<MODELE_PAIE> GetModelePaieByNumeroModelePaieAsync(string NumeroModelePaie)
        {
            throw new NotImplementedException();
        }

        public void UpdateModelePaie(MODELE_PAIE ModelePaie)
        {
            throw new NotImplementedException();
        }

        public Task UpdateModelePaieAsync(MODELE_PAIE ModelePaie)
        {
            throw new NotImplementedException();
        }
    }
}