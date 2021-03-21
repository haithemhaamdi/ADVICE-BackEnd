using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class RubriqueRepository : RepositoryBase<RUBRIQUE>, IRubriqueRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public RubriqueRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateRubrique(RUBRIQUE Rubrique)
        {
            throw new NotImplementedException();
        }

        public Task CreateRubriqueAsync(RUBRIQUE Rubrique)
        {
            throw new NotImplementedException();
        }

        public void DeleteRubrique(RUBRIQUE Rubrique)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRubriqueAsync(RUBRIQUE Rubrique)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RUBRIQUE> GetAllRubriques()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RUBRIQUE>> GetAllRubriquesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RUBRIQUE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public RUBRIQUE GetRubriqueByCodeRubrique(string CodeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task<RUBRIQUE> GetRubriqueByCodeRubriqueAsync(string CodeRubrique)
        {
            throw new NotImplementedException();
        }

        public RUBRIQUE GetRubriqueByLibelleRubrique(string LibelleRubrique)
        {
            throw new NotImplementedException();
        }

        public void UpdateRubrique(RUBRIQUE Rubrique)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRubriqueAsync(RUBRIQUE Rubrique)
        {
            throw new NotImplementedException();
        }
    }
}