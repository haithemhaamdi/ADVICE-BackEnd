using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeAjustementCongeRepository : RepositoryBase<EMPLOYE_AJUSTEMENT_CONGE>, IEmployeAjustementCongeRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeAjustementCongeRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeAjustementConge(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeAjustementCongeAsync(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeAjustementConge(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeAjustementCongeAsync(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_AJUSTEMENT_CONGE> GetAllEmployeAjustementConges()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_AJUSTEMENT_CONGE>> GetAllEmployeAjustementCongesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_AJUSTEMENT_CONGE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_AJUSTEMENT_CONGE GetEmployeAjustementCongeByCodeAjustementConge(string CodeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_AJUSTEMENT_CONGE> GetEmployeAjustementCongeByCodeAjustementCongeAsync(string CodeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_AJUSTEMENT_CONGE GetEmployeAjustementCongeByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeAjustementConge(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeAjustementCongeAsync(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge)
        {
            throw new NotImplementedException();
        }
    }
}