using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ParametrePointageRepository : RepositoryBase<PARAMETRE_POINTAGE>, IParametrePointageRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ParametrePointageRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateParametrePointage(PARAMETRE_POINTAGE ParametrePointage)
        {
            throw new NotImplementedException();
        }

        public Task CreateParametrePointageAsync(PARAMETRE_POINTAGE ParametrePointage)
        {
            throw new NotImplementedException();
        }

        public void DeleteParametrePointage(PARAMETRE_POINTAGE ParametrePointage)
        {
            throw new NotImplementedException();
        }

        public Task DeleteParametrePointageAsync(PARAMETRE_POINTAGE ParametrePointage)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PARAMETRE_POINTAGE> GetAllParametrePointages()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PARAMETRE_POINTAGE>> GetAllParametrePointagesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PARAMETRE_POINTAGE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public PARAMETRE_POINTAGE GetParametrePointageByID(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<PARAMETRE_POINTAGE> GetParametrePointageByIDAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateParametrePointage(PARAMETRE_POINTAGE ParametrePointage)
        {
            throw new NotImplementedException();
        }

        public Task UpdateParametrePointageAsync(PARAMETRE_POINTAGE ParametrePointage)
        {
            throw new NotImplementedException();
        }
    }
}