using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class DeclarationCNSSDetailRepository : RepositoryBase<DECLARATION_CNSS_DETAIL>, IDeclarationCNSSDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public DeclarationCNSSDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DECLARATION_CNSS_DETAIL> GetAllDeclarationCNSSDetails()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DECLARATION_CNSS_DETAIL>> GetAllDeclarationCNSSDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}