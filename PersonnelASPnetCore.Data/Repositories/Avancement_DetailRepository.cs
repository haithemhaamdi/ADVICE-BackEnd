using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class Avancement_DetailRepository : RepositoryBase<AVANCEMENT_DETAIL>, IAvancement_DetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public Avancement_DetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AVANCEMENT_DETAIL> GetAllAvancementDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AVANCEMENT_DETAIL>> GetAllAvancementDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
