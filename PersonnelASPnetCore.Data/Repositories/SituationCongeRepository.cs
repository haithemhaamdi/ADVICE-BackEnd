using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class SituationCongeRepository : RepositoryBase<SITUATION_CONGE>, ISituationCongeRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public SituationCongeRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration): base(repositoryContext)
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

        public void CreateSituationConge(SITUATION_CONGE SituationConge)
        {
            throw new NotImplementedException();
        }

        public Task CreateSituationCongeAsync(SITUATION_CONGE SituationConge)
        {
            throw new NotImplementedException();
        }

        public void DeleteSituationConge(SITUATION_CONGE SituationConge)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSituationCongeAsync(SITUATION_CONGE SituationConge)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SITUATION_CONGE> GetAllSituationConges()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SITUATION_CONGE>> GetAllSituationCongesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SITUATION_CONGE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public Task<SITUATION_CONGE> GetSituationCongeByCodeAsync(string Code)
        {
            throw new NotImplementedException();
        }

        public SITUATION_CONGE GetSituationCongeByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public SITUATION_CONGE GetSituationCongeByNomEmploye(string NomEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateSituationConge(SITUATION_CONGE SituationConge)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSituationCongeAsync(SITUATION_CONGE SituationConge)
        {
            throw new NotImplementedException();
        }
    }
}