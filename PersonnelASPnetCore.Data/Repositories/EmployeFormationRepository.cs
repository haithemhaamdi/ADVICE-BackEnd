using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeFormationRepository : RepositoryBase<EMPLOYE_FORMATION>, IEmployeFormationRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeFormationRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeFormation(EMPLOYE_FORMATION EmployeFormation)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeFormationAsync(EMPLOYE_FORMATION EmployeFormation)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeFormation(EMPLOYE_FORMATION EmployeFormation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeFormationAsync(EMPLOYE_FORMATION EmployeFormation)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_FORMATION> GetAllEmployeFormations()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_FORMATION>> GetAllEmployeFormationsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_FORMATION> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_FORMATION GetEmployeFormationByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_FORMATION GetEmployeFormationByCodeFormation(string CodeFormation)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_FORMATION> GetEmployeFormationByCodeFormationAsync(string CodeFormation)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeFormation(EMPLOYE_FORMATION EmployeFormation)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeFormationAsync(EMPLOYE_FORMATION EmployeFormation)
        {
            throw new NotImplementedException();
        }
    }
}