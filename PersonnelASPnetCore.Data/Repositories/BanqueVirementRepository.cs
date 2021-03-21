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
    public class BanqueVirementRepository : RepositoryBase<BANQUE_VIREMENT>, IBanqueVirementRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BanqueVirementRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateBanqueVirement(BANQUE_VIREMENT BanqueVirement)
        {
            throw new NotImplementedException();
        }

        public Task CreateBanqueVirementAsync(BANQUE_VIREMENT BanqueVirement)
        {
            throw new NotImplementedException();
        }

        public void DeleteBanqueVirement(BANQUE_VIREMENT BanqueVirement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBanqueVirementAsync(BANQUE_VIREMENT BanqueVirement)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BANQUE_VIREMENT> GetAllBanqueVirements()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BANQUE_VIREMENT>> GetAllBanqueVirementsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BANQUE_VIREMENT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public BANQUE_VIREMENT GetBanqueVirementByCodeBanqueVirement(string CodeBanqueVirement)
        {
            throw new NotImplementedException();
        }

        public Task<BANQUE_VIREMENT> GetBanqueVirementByCodeBanqueVirementAsync(string CodeBanqueVirement)
        {
            throw new NotImplementedException();
        }

        public BANQUE_VIREMENT GetBanqueVirementByLibelleBanqueVirement(string LibelleBanqueVirement)
        {
            throw new NotImplementedException();
        }

        public void UpdateBanqueVirement(BANQUE_VIREMENT BanqueVirement)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBanqueVirementAsync(BANQUE_VIREMENT BanqueVirement)
        {
            throw new NotImplementedException();
        }
    }
}
