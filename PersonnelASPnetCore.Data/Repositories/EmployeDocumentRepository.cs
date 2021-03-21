using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeDocumentRepository : RepositoryBase<EMPLOYE_DOCUMENT>, IEmployeDocumentRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeDocumentRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateBordereau(EMPLOYE_DOCUMENT EmployeDocument)
        {
            throw new NotImplementedException();
        }

        public Task CreateBordereauAsync(EMPLOYE_DOCUMENT Bordereau)
        {
            throw new NotImplementedException();
        }

        public void DeleteBordereau(EMPLOYE_DOCUMENT Bordereau)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBordereauAsync(EMPLOYE_DOCUMENT Bordereau)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_DOCUMENT> GetAllBordereaus()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_DOCUMENT>> GetAllBordereausAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_DOCUMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_DOCUMENT GetBordereauByCodeDocument(string CodeDocument)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_DOCUMENT> GetBordereauByCodeDocumentAsync(string CodeDocument)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_DOCUMENT GetBordereauByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateBordereau(EMPLOYE_DOCUMENT Bordereau)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBordereauAsync(EMPLOYE_DOCUMENT Bordereau)
        {
            throw new NotImplementedException();
        }
    }
}