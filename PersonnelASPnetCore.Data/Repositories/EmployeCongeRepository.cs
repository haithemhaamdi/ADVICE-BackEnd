using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeCongeRepository : RepositoryBase<EMPLOYE_CONGE>, IEmployeCongeRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeCongeRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeConge(EMPLOYE_CONGE EmployeConge)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeCongeAsync(EMPLOYE_CONGE EmployeConge)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeConge(EMPLOYE_CONGE EmployeConge)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeCongeAsync(EMPLOYE_CONGE EmployeConge)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_CONGE> GetAllEmployeConges()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_CONGE>> GetAllEmployeCongesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_CONGE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_CONGE GetEmployeCongeByCodeConge(string CodeConge)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_CONGE> GetEmployeCongeByCodeCongeAsync(string CodeConge)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_CONGE GetEmployeCongeByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeConge(EMPLOYE_CONGE EmployeConge)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeCongeAsync(EMPLOYE_CONGE EmployeConge)
        {
            throw new NotImplementedException();
        }
    }
}