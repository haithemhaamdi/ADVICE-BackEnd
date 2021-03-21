using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class VirementDetailRepository : RepositoryBase<APPELLATION>, IVirementDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public VirementDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VIREMENT_DETAIL> GetAllVirementDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VIREMENT_DETAIL>> GetAllVirementDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}