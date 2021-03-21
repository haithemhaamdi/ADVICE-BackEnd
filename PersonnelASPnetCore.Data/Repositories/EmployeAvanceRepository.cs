using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeAvanceRepository : RepositoryBase<EMPLOYE_AVANCE>, IEmployeAvanceRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeAvanceRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeAvance(EMPLOYE_AVANCE EmployeAvance)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeAvanceAsync(EMPLOYE_AVANCE EmployeAvance)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeAvance(EMPLOYE_AVANCE EmployeAvance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeAvanceAsync(EMPLOYE_AVANCE EmployeAvance)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_AVANCE> GetAllEmployeAvances()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_AVANCE>> GetAllEmployeAvancesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_AVANCE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_AVANCE GetEmployeAvanceByCodeAvance(string CodeAvance)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_AVANCE> GetEmployeAvanceByCodeAvanceAsync(string CodeAvance)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_AVANCE GetEmployeAvanceByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeAvance(EMPLOYE_AVANCE EmployeAvance)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeAvanceAsync(EMPLOYE_AVANCE EmployeAvance)
        {
            throw new NotImplementedException();
        }
    }
}