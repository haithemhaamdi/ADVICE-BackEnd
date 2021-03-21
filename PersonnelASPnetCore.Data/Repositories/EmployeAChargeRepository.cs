using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeAChargeRepository : RepositoryBase<EMPLOYE_A_CHARGE>, IEmployeAChargeRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeAChargeRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeACharge(EMPLOYE_A_CHARGE EmployeACharge)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeAChargeAsync(EMPLOYE_A_CHARGE EmployeACharge)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeACharge(EMPLOYE_A_CHARGE EmployeACharge)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeAChargeAsync(EMPLOYE_A_CHARGE EmployeACharge)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_A_CHARGE> GetAllEmployeACharges()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_A_CHARGE>> GetAllEmployeAChargesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_A_CHARGE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_A_CHARGE GetEmployeAChargeByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_A_CHARGE> GetEmployeAChargeByCodeEmployeAsync(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_A_CHARGE GetEmployeAChargeByCodePersonne(string CodePersonne)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeACharge(EMPLOYE_A_CHARGE EmployeACharge)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeAChargeAsync(EMPLOYE_A_CHARGE EmployeACharge)
        {
            throw new NotImplementedException();
        }
    }
}