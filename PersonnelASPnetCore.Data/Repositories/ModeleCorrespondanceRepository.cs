using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ModeleCorrespondanceRepository : RepositoryBase<MODELE_CORRESPONDANCE>, IModeleCorrespondanceRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ModeleCorrespondanceRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateModeleCorrespondance(MODELE_CORRESPONDANCE ModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task CreateModeleCorrespondanceAsync(MODELE_CORRESPONDANCE ModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public void DeleteModeleCorrespondance(MODELE_CORRESPONDANCE ModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteModeleCorrespondanceAsync(MODELE_CORRESPONDANCE ModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODELE_CORRESPONDANCE> GetAllModeleCorrespondances()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MODELE_CORRESPONDANCE>> GetAllModeleCorrespondancesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODELE_CORRESPONDANCE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public MODELE_CORRESPONDANCE GetModeleCorrespondanceByDateModeleCorrespondance(DateTime DateModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public MODELE_CORRESPONDANCE GetModeleCorrespondanceByNumeroModeleCorrespondance(string NumeroModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task<MODELE_CORRESPONDANCE> GetModeleCorrespondanceByNumeroModeleCorrespondanceAsync(string NumeroModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public void UpdateModeleCorrespondance(MODELE_CORRESPONDANCE ModeleCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task UpdateModeleCorrespondanceAsync(MODELE_CORRESPONDANCE ModeleCorrespondance)
        {
            throw new NotImplementedException();
        }
    }
}