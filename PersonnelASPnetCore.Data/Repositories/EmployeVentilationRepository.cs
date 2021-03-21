using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeVentilationRepository : RepositoryBase<EMPLOYE_VENTILATION>, IEmployeVentilationRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeVentilationRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeVentilation(EMPLOYE_VENTILATION EmployeVentilation)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeVentilationAsync(EMPLOYE_VENTILATION EmployeVentilation)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeVentilation(EMPLOYE_VENTILATION EmployeVentilation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeVentilationAsync(EMPLOYE_VENTILATION EmployeVentilation)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_VENTILATION> GetAllEmployeVentilations()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_VENTILATION>> GetAllEmployeVentilationsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_VENTILATION> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_VENTILATION GetEmployeVentilationByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_VENTILATION> GetEmployeVentilationByCodeEmployeAsync(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeVentilation(EMPLOYE_VENTILATION EmployeVentilation)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeVentilationAsync(EMPLOYE_VENTILATION EmployeVentilation)
        {
            throw new NotImplementedException();
        }
    }
}