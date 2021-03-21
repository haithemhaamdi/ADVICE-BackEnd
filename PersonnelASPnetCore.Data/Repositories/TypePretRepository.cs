using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class TypePretRepository : RepositoryBase<TYPE_PRET>, ITypePretRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public TypePretRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateTypePret(TYPE_PRET TypePret)
        {
            throw new NotImplementedException();
        }

        public Task CreateTypePretAsync(TYPE_PRET TypePret)
        {
            throw new NotImplementedException();
        }

        public void DeleteTypePret(TYPE_PRET TypePret)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTypePretAsync(TYPE_PRET TypePret)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_PRET> GetAllTypePrets()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE_PRET>> GetAllTypePretsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_PRET> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public TYPE_PRET GetTypePretByCodeTypePret(string CodeTypePret)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE_PRET> GetTypePretByCodeTypePretAsync(string CodeTypePret)
        {
            throw new NotImplementedException();
        }

        public TYPE_PRET GetTypePretByLibelleTypePret(string LibelleTypePret)
        {
            throw new NotImplementedException();
        }

        public void UpdateTypePret(TYPE_PRET TypePret)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTypePretAsync(TYPE_PRET TypePret)
        {
            throw new NotImplementedException();
        }
    }
}