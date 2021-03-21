using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class TypeRubriqueRepository : RepositoryBase<TYPE_RUBRIQUE>, ITypeRubriqueRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public TypeRubriqueRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateTypeRubrique(TYPE_RUBRIQUE TypeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task CreateTypeRubriqueAsync(TYPE_RUBRIQUE TypeRubrique)
        {
            throw new NotImplementedException();
        }

        public void DeleteTypeRubrique(TYPE_RUBRIQUE TypeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTypeRubriqueAsync(TYPE_RUBRIQUE TypeRubrique)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_RUBRIQUE> GetAllTypeRubriques()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE_RUBRIQUE>> GetAllTypeRubriquesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_RUBRIQUE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public TYPE_RUBRIQUE GetTypeRubriqueByCodeTypeRubrique(string CodeTypeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE_RUBRIQUE> GetTypeRubriqueByCodeTypeRubriqueAsync(string CodeTypeRubrique)
        {
            throw new NotImplementedException();
        }

        public void UpdateTypeRubrique(TYPE_RUBRIQUE TypeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTypeRubriqueAsync(TYPE_RUBRIQUE TypeRubrique)
        {
            throw new NotImplementedException();
        }
    }
}