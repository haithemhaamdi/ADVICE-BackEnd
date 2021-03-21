using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeObservationRepository : RepositoryBase<EMPLOYE_OBSERVATION>, IEmployeObservationRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeObservationRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        public void CreateEmployeObservation(EMPLOYE_OBSERVATION EmployeObservation)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateEmployeObservationAsync(EMPLOYE_OBSERVATION EmployeObservation)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployeObservation(EMPLOYE_OBSERVATION EmployeObservation)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteEmployeObservationAsync(EMPLOYE_OBSERVATION EmployeObservation)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EMPLOYE_OBSERVATION> GetAllEmployeObservations()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_OBSERVATION>> GetAllEmployeObservationsAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EMPLOYE_OBSERVATION> GetAllWithRefernces()
        {
            throw new System.NotImplementedException();
        }

        public EMPLOYE_OBSERVATION GetEmployeObservationByCodeEmploye(string CodeEmploye)
        {
            throw new System.NotImplementedException();
        }

        public EMPLOYE_OBSERVATION GetEmployeObservationByCodeObservation(string CodeObservation)
        {
            throw new System.NotImplementedException();
        }

        public Task<EMPLOYE_OBSERVATION> GetEmployeObservationByCodeObservationAsync(string CodeObservation)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEmployeObservation(EMPLOYE_OBSERVATION EmployeObservation)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateEmployeObservationAsync(EMPLOYE_OBSERVATION EmployeObservation)
        {
            throw new System.NotImplementedException();
        }
    }
}