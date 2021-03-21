using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class DepartementRepository : RepositoryBase<DEPARTEMENT>, IDepartementRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public DepartementRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateDepartement(DEPARTEMENT Departement)
        {
            throw new NotImplementedException();
        }

        public Task CreateDepartementAsync(DEPARTEMENT Departement)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartement(DEPARTEMENT Departement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDepartementAsync(DEPARTEMENT Departement)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DEPARTEMENT> GetAllDepartements()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DEPARTEMENT>> GetAllDepartementsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DEPARTEMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public DEPARTEMENT GetDepartementByCodeDepartement(string CodeDepartement)
        {
            throw new NotImplementedException();
        }

        public Task<DEPARTEMENT> GetDepartementByCodeDepartementAsync(string CodeDepartement)
        {
            throw new NotImplementedException();
        }

        public DEPARTEMENT GetDepartementByLibelleDepartement(string LibelleDepartement)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartement(DEPARTEMENT Departement)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDepartementAsync(DEPARTEMENT Departement)
        {
            throw new NotImplementedException();
        }
    }
}