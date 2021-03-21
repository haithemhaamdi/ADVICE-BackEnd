using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeDesciplineRepository : RepositoryBase<EMPLOYE_DISCIPLINE>, IEmployeDesciplineRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeDesciplineRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeDescipline(EMPLOYE_DISCIPLINE EmployeDescipline)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeDesciplineAsync(EMPLOYE_DISCIPLINE EmployeDescipline)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeDescipline(EMPLOYE_DISCIPLINE EmployeDescipline)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeDesciplineAsync(EMPLOYE_DISCIPLINE EmployeDescipline)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_DISCIPLINE> GetAllEmployeDesciplines()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_DISCIPLINE>> GetAllEmployeDesciplinesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_DISCIPLINE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_DISCIPLINE GetEmployeDesciplineByCodeDiscipline(string CodeDiscipline)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_DISCIPLINE> GetEmployeDesciplineByCodeDisciplineAsync(string CodeDiscipline)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_DISCIPLINE GetEmployeDesciplineByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeDescipline(EMPLOYE_DISCIPLINE EmployeDescipline)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeDesciplineAsync(EMPLOYE_DISCIPLINE EmployeDescipline)
        {
            throw new NotImplementedException();
        }
    }
}