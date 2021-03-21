using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class DecompteMonnaieRepository : RepositoryBase<DECOMPTE_MONNAIE>, IDecompteMonnaieRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public DecompteMonnaieRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateDecompteMonnaie(DECOMPTE_MONNAIE DecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateDecompteMonnaieAsync(DECOMPTE_MONNAIE DecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteDecompteMonnaie(DECOMPTE_MONNAIE DecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteDecompteMonnaieAsync(DECOMPTE_MONNAIE DecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DECOMPTE_MONNAIE> GetAllDecompteMonnaies()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DECOMPTE_MONNAIE>> GetAllDecompteMonnaiesAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DECOMPTE_MONNAIE> GetAllWithRefernces()
        {
            throw new System.NotImplementedException();
        }

        public DECOMPTE_MONNAIE GetDecompteMonnaieByCodeEmploye(string CodeEmploye)
        {
            throw new System.NotImplementedException();
        }

        public DECOMPTE_MONNAIE GetDecompteMonnaieByNumeroDecompteMonnaie(string NumeroDecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public Task<DECOMPTE_MONNAIE> GetDecompteMonnaieByNumeroDecompteMonnaieAsync(string NumeroDecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDecompteMonnaie(DECOMPTE_MONNAIE DecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateDecompteMonnaieAsync(DECOMPTE_MONNAIE DecompteMonnaie)
        {
            throw new System.NotImplementedException();
        }
    }
}