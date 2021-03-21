using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class BaremeImportRepository : RepositoryBase<BAREME_IMPOT>, IBaremeImportRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BaremeImportRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateBaremeImport(BAREME_IMPOT BaremeImport)
        {
            throw new NotImplementedException();
        }

        public Task CreateBaremeImportAsync(BAREME_IMPOT BaremeImport)
        {
            throw new NotImplementedException();
        }

        public void DeleteBaremeImport(BAREME_IMPOT BaremeImport)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBaremeImportAsync(BAREME_IMPOT BaremeImport)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BAREME_IMPOT> GetAllBaremeImports()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BAREME_IMPOT>> GetAllBaremeImportsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BAREME_IMPOT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public BAREME_IMPOT GetBaremeImportByMontant(decimal Montant1, decimal Montant2)
        {
            throw new NotImplementedException();
        }

        public Task<BAREME_IMPOT> GetBaremeImportByMontantAsync(string NumeroBaremeImport)
        {
            throw new NotImplementedException();
        }

        public void UpdateBaremeImport(BAREME_IMPOT BaremeImport)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBaremeImportAsync(BAREME_IMPOT BaremeImport)
        {
            throw new NotImplementedException();
        }
    }
}