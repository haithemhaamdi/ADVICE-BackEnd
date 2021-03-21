using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EcritureDetailRepository : RepositoryBase<ECRITURE_DETAIL>, IEcritureDetailRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EcritureDetailRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
            _ctx = repositoryContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ECRITURE_DETAIL> GetAllEcritureDetails()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ECRITURE_DETAIL>> GetAllEcritureDetailsAsync()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Domaine.Entities.ECRITURE_DETAIL> IEcritureDetailRepository.GetAllEcritureDetails()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Domaine.Entities.ECRITURE_DETAIL>> IEcritureDetailRepository.GetAllEcritureDetailsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}