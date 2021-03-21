using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class SituationCongeSpecialRepository : RepositoryBase<SITUATION_CONGE_SPECIAL>, ISituationCongeSpecialRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public SituationCongeSpecialRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration) : base(repositoryContext)
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

        public void CreateSituationCongeSpecial(SITUATION_CONGE_SPECIAL SituationCongeSpecial)
        {
            throw new NotImplementedException();
        }

        public Task CreateSituationCongeSpecialAsync(SITUATION_CONGE_SPECIAL SituationCongeSpecial)
        {
            throw new NotImplementedException();
        }

        public void DeleteSituationCongeSpecial(SITUATION_CONGE_SPECIAL SituationCongeSpecial)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSituationCongeSpecialAsync(SITUATION_CONGE_SPECIAL SituationCongeSpecial)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SITUATION_CONGE_SPECIAL> GetAllSituationCongeSpecials()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SITUATION_CONGE_SPECIAL>> GetAllSituationCongeSpecialsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SITUATION_CONGE_SPECIAL> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public SITUATION_CONGE_SPECIAL GetSituationCongeSpecialByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public SITUATION_CONGE_SPECIAL GetSituationCongeSpecialByCodeRubrique(string CodeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task<SITUATION_CONGE_SPECIAL> GetSituationCongeSpecialByCodeRubriqueAsync(string CodeRubrique)
        {
            throw new NotImplementedException();
        }

        public void UpdateSituationCongeSpecial(SITUATION_CONGE_SPECIAL SituationCongeSpecial)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSituationCongeSpecialAsync(SITUATION_CONGE_SPECIAL SituationCongeSpecial)
        {
            throw new NotImplementedException();
        }
    }

}