using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class PointageRepository : RepositoryBase<POINTAGE>, IPointageRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public PointageRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreatePointage(POINTAGE Pointage)
        {
            throw new NotImplementedException();
        }

        public Task CreatePointageAsync(POINTAGE Pointage)
        {
            throw new NotImplementedException();
        }

        public void DeletePointage(POINTAGE Pointage)
        {
            throw new NotImplementedException();
        }

        public Task DeletePointageAsync(POINTAGE Pointage)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<POINTAGE> GetAllPointages()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<POINTAGE>> GetAllPointagesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<POINTAGE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public POINTAGE GetPointageByDatePointage(DateTime DatePointage)
        {
            throw new NotImplementedException();
        }

        public POINTAGE GetPointageByNumeroPointage(string NumeroPointage)
        {
            throw new NotImplementedException();
        }

        public Task<POINTAGE> GetPointageByNumeroPointageAsync(string NumeroPointage)
        {
            throw new NotImplementedException();
        }

        public void UpdatePointage(POINTAGE Pointage)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePointageAsync(POINTAGE Pointage)
        {
            throw new NotImplementedException();
        }
    }
}