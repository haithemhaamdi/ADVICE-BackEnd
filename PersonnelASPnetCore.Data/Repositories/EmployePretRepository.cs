using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployePretRepository : RepositoryBase<EMPLOYE_PRET>, IEmployePretRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployePretRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployePret(EMPLOYE_PRET EmployePret)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployePretAsync(EMPLOYE_PRET EmployePret)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployePret(EMPLOYE_PRET EmployePret)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployePretAsync(EMPLOYE_PRET EmployePret)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_PRET> GetAllEmployePrets()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_PRET>> GetAllEmployePretsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_PRET> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_PRET GetEmployePretByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_PRET GetEmployePretByCodePret(string CodePret)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_PRET> GetEmployePretByCodePretAsync(string CodePret)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployePret(EMPLOYE_PRET EmployePret)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployePretAsync(EMPLOYE_PRET EmployePret)
        {
            throw new NotImplementedException();
        }
    }
}