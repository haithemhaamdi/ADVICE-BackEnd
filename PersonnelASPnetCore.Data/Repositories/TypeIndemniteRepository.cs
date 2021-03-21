using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class TypeIndemniteRepository : RepositoryBase<TYPE_INDEMNITE>, ITypeIndemniteRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public TypeIndemniteRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        public void CreateTypeIndemnite(TYPE_INDEMNITE TypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateTypeIndemniteAsync(TYPE_INDEMNITE TypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTypeIndemnite(TYPE_INDEMNITE TypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteTypeIndemniteAsync(TYPE_INDEMNITE TypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TYPE_INDEMNITE> GetAllTypeIndemnites()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TYPE_INDEMNITE>> GetAllTypeIndemnitesAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TYPE_INDEMNITE> GetAllWithRefernces()
        {
            throw new System.NotImplementedException();
        }

        public TYPE_INDEMNITE GetTypeIndemniteByCodeTypeIndemnite(string CodeTypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public Task<TYPE_INDEMNITE> GetTypeIndemniteByCodeTypeIndemniteAsync(string CodeTypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public TYPE_INDEMNITE GetTypeIndemniteByLibelleTypeIndemnite(string LibelleTypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTypeIndemnite(TYPE_INDEMNITE TypeIndemnite)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTypeIndemniteAsync(TYPE_INDEMNITE TypeIndemnite)
        {
            throw new System.NotImplementedException();
        }
    }
}