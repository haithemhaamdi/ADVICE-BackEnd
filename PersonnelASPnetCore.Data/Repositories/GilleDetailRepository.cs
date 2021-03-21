using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class GilleDetailRepository : RepositoryBase<GRILLE_DETAIL>, IGilleDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public GilleDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GRILLE_DETAIL> GetAllGilleDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GRILLE_DETAIL>> GetAllGilleDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}