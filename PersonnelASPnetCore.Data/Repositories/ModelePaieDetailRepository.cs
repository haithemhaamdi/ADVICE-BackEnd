using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ModelePaieDetailRepository : RepositoryBase<MODELE_PAIE_DETAIL>, IModelePaieDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ModelePaieDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MODELE_PAIE_DETAIL> GetAllModelePaieDetails()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MODELE_PAIE_DETAIL>> GetAllModelePaieDetailsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}