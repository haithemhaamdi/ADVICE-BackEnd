using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeContratRepository : RepositoryBase<EMPLOYE_CONTRAT>, IEmployeContratRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeContratRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeContrat(EMPLOYE_CONTRAT EmployeContrat)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeContratAsync(EMPLOYE_CONTRAT EmployeContrat)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeContrat(EMPLOYE_CONTRAT EmployeContrat)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeContratAsync(EMPLOYE_CONTRAT EmployeContrat)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_CONTRAT> GetAllEmployeContrats()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_CONTRAT>> GetAllEmployeContratsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_CONTRAT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_CONTRAT GetEmployeContratByCodeContratEmploye(string CodeContratEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_CONTRAT> GetEmployeContratByCodeContratEmployeAsync(string CodeContratEmploye)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_CONTRAT GetEmployeContratByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeContrat(EMPLOYE_CONTRAT EmployeContrat)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeContratAsync(EMPLOYE_CONTRAT EmployeContrat)
        {
            throw new NotImplementedException();
        }
    }
}