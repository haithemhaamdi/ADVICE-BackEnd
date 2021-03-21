using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class BulletinPaieDetailRepository : RepositoryBase<BULLETIN_PAIE_DETAIL>, IBulletinPaieDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BulletinPaieDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BULLETIN_PAIE_DETAIL> GetAllBulletinPaieDetailDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BULLETIN_PAIE_DETAIL>> GetAllBulletinPaieDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}