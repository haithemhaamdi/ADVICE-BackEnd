using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeCorrespondanceRepository : RepositoryBase<EMPLOYE_CORRESPONDANCE>, IEmployeCorrespondanceRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeCorrespondanceRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeCorrespondance(EMPLOYE_CORRESPONDANCE EmployeCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeCorrespondanceAsync(EMPLOYE_CORRESPONDANCE EmployeCorrespondance)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeCorrespondance(EMPLOYE_CORRESPONDANCE EmployeCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeCorrespondanceAsync(EMPLOYE_CORRESPONDANCE EmployeCorrespondance)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_CORRESPONDANCE> GetAllEmployeCorrespondances()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_CORRESPONDANCE>> GetAllEmployeCorrespondancesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_CORRESPONDANCE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_CORRESPONDANCE GetEmployeCorrespondanceByCodeDocument(string CodeDocument)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_CORRESPONDANCE GetEmployeCorrespondanceByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_CORRESPONDANCE> GetEmployeCorrespondanceByCodeEmployeAsync(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeCorrespondance(EMPLOYE_CORRESPONDANCE EmployeCorrespondance)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeCorrespondanceAsync(EMPLOYE_CORRESPONDANCE EmployeCorrespondance)
        {
            throw new NotImplementedException();
        }
    }
}