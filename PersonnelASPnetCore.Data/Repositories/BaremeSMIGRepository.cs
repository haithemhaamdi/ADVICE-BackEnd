using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class BaremeSMIGRepository : RepositoryBase<BAREME_SMIG>, IBaremeSMIGRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BaremeSMIGRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateBaremeSMIG(BAREME_SMIG BaremeSMIG)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateBaremeSMIGAsync(BAREME_SMIG BaremeSMIG)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBaremeSMIG(BAREME_SMIG BaremeSMIG)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBaremeSMIGAsync(BAREME_SMIG BaremeSMIG)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BAREME_SMIG> GetAllBaremeSMIGs()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<BAREME_SMIG>> GetAllBaremeSMIGsAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BAREME_SMIG> GetAllWithRefernces()
        {
            throw new System.NotImplementedException();
        }

        public BAREME_SMIG GetBaremeSMIGByTaux(decimal Taux)
        {
            throw new System.NotImplementedException();
        }

        public Task<BAREME_SMIG> GetBaremeSMIGByTauxAsync(decimal Taux)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBaremeSMIG(BAREME_SMIG BaremeSMIG)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateBaremeSMIGAsync(BAREME_SMIG BaremeSMIG)
        {
            throw new System.NotImplementedException();
        }
    }
}