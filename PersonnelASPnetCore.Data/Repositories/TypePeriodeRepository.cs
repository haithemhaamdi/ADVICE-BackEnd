using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class TypePeriodeRepository : RepositoryBase<TYPE_PERIODE>, ITypePeriodeRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public TypePeriodeRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateTypePeriode(TYPE_PERIODE TypePeriode)
        {
            throw new NotImplementedException();
        }

        public Task CreateTypePeriodeAsync(TYPE_PERIODE TypePeriode)
        {
            throw new NotImplementedException();
        }

        public void DeleteTypePeriode(TYPE_PERIODE TypePeriode)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTypePeriodeAsync(TYPE_PERIODE TypePeriode)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_PERIODE> GetAllTypePeriodes()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TYPE_PERIODE>> GetAllTypePeriodesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TYPE_PERIODE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public TYPE_PERIODE GetTypePeriodeByCodeTypePeriode(string CodeTypePeriode)
        {
            throw new NotImplementedException();
        }

        public Task<TYPE_PERIODE> GetTypePeriodeByCodeTypePeriodeAsync(string CodeTypePeriode)
        {
            throw new NotImplementedException();
        }

        public TYPE_PERIODE GetTypePeriodeByLibelleTypePeriodee(string LibelleTypePeriode)
        {
            throw new NotImplementedException();
        }

        public void UpdateTypePeriode(TYPE_PERIODE TypePeriode)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTypePeriodeAsync(TYPE_PERIODE TypePeriode)
        {
            throw new NotImplementedException();
        }
    }
}