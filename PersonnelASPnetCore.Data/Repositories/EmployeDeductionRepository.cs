using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeDeductionRepository : RepositoryBase<EMPLOYE_DEDUCTION>, IEmployeDeductionRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeDeductionRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeDeduction(EMPLOYE_DEDUCTION EmployeDeduction)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeDeductionAsync(EMPLOYE_DEDUCTION EmployeDeduction)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeDeduction(EMPLOYE_DEDUCTION EmployeDeduction)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeDeductionAsync(EMPLOYE_DEDUCTION EmployeDeduction)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_DEDUCTION> GetAllEmployeDeductions()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_DEDUCTION>> GetAllEmployeDeductionsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_DEDUCTION> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_DEDUCTION GetEmployeDeductionByCodeDeduction(string CodeDeduction)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_DEDUCTION> GetEmployeDeductionByCodeDeductionAsync(string CodeDeduction)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_DEDUCTION GetEmployeDeductionByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeDeduction(EMPLOYE_DEDUCTION EmployeDeduction)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeDeductionAsync(EMPLOYE_DEDUCTION EmployeDeduction)
        {
            throw new NotImplementedException();
        }
    }
}