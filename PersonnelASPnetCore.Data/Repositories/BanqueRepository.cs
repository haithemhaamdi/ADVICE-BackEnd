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
    public class BanqueRepository : RepositoryBase<BANQUE>, IBanqueRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public BanqueRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateBanque(BANQUE Banque)
        {
            throw new NotImplementedException();
        }

        public Task CreateBanqueAsync(BANQUE Banque)
        {
            throw new NotImplementedException();
        }

        public void DeleteBanque(BANQUE Banque)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBanqueAsync(BANQUE Banque)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BANQUE> GetAllBanques()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BANQUE>> GetAllBanquesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BANQUE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public BANQUE GetBanqueByCodeBanque(string CodeBanque)
        {
            throw new NotImplementedException();
        }

        public Task<BANQUE> GetBanqueByCodeBanqueAsync(string CodeBanque)
        {
            throw new NotImplementedException();
        }

        public BANQUE GetBanqueByLibelleBanque(string LibelleBanque)
        {
            throw new NotImplementedException();
        }

        public void UpdateBanque(BANQUE Banque)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBanqueAsync(BANQUE Banque)
        {
            throw new NotImplementedException();
        }
    }
}
