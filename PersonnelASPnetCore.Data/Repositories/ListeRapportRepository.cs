using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class ListeRapportRepository : RepositoryBase<LISTE_RAPPORT>, IListeRapportRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ListeRapportRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateListeRapport(LISTE_RAPPORT ListeRapport)
        {
            throw new NotImplementedException();
        }

        public Task CreateListeRapportAsync(LISTE_RAPPORT ListeRapport)
        {
            throw new NotImplementedException();
        }

        public void DeleteListeRapport(LISTE_RAPPORT ListeRapport)
        {
            throw new NotImplementedException();
        }

        public Task DeleteListeRapportAsync(LISTE_RAPPORT ListeRapport)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LISTE_RAPPORT> GetAllListeRapports()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LISTE_RAPPORT>> GetAllListeRapportsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LISTE_RAPPORT> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public LISTE_RAPPORT GetListeRapportByIdImpression(int IdImpression)
        {
            throw new NotImplementedException();
        }

        public Task<LISTE_RAPPORT> GetListeRapportByIdImpressionAsync(int IdImpression)
        {
            throw new NotImplementedException();
        }

        public LISTE_RAPPORT GetListeRapportByNomRapportRapport(string NomRapport)
        {
            throw new NotImplementedException();
        }

        public void UpdateListeRapport(LISTE_RAPPORT ListeRapport)
        {
            throw new NotImplementedException();
        }

        public Task UpdateListeRapportAsync(LISTE_RAPPORT ListeRapport)
        {
            throw new NotImplementedException();
        }
    }
}