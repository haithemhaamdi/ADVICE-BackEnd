using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeAbsenceRepository : RepositoryBase<EMPLOYE_ABSENCE>, IEmployeAbsenceRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeAbsenceRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeAbsence(EMPLOYE_ABSENCE EmployeAbsence)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeAbsenceAsync(EMPLOYE_ABSENCE EmployeAbsence)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeAbsence(EMPLOYE_ABSENCE EmployeAbsence)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeAbsenceAsync(EMPLOYE_ABSENCE EmployeAbsence)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_ABSENCE> GetAllEmployeAbsences()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_ABSENCE>> GetAllEmployeAbsencesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_ABSENCE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_ABSENCE GetEmployeAbsenceByCodeAbsence(string CodeAbsence)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_ABSENCE> GetEmployeAbsenceByCodeAbsenceAsync(string CodeAbsence)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_ABSENCE GetEmployeAbsenceByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeAbsence(EMPLOYE_ABSENCE EmployeAbsence)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeAbsenceAsync(EMPLOYE_ABSENCE EmployeAbsence)
        {
            throw new NotImplementedException();
        }
    }
}