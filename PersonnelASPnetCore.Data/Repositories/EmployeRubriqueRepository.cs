using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeRubriqueRepository : RepositoryBase<EMPLOYE_RUBRIQUE>, IEmployeRubriqueRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeRubriqueRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeRubrique(EMPLOYE_RUBRIQUE EmployeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeRubriqueAsync(EMPLOYE_RUBRIQUE EmployeRubrique)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeRubrique(EMPLOYE_RUBRIQUE EmployeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeRubriqueAsync(EMPLOYE_RUBRIQUE EmployeRubrique)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_RUBRIQUE> GetAllEmployeRubriques()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_RUBRIQUE>> GetAllEmployeRubriquesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_RUBRIQUE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_RUBRIQUE GetEmployeRubriqueByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_RUBRIQUE> GetEmployeRubriqueByCodeEmployeAsync(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_RUBRIQUE GetEmployeRubriqueByCodeRubrique(string CodeRubrique)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeRubrique(EMPLOYE_RUBRIQUE EmployeRubrique)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeRubriqueAsync(EMPLOYE_RUBRIQUE EmployeRubrique)
        {
            throw new NotImplementedException();
        }
    }
}