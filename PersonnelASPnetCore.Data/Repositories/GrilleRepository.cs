using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class GrilleRepository : RepositoryBase<GRILLE>, IGrilleRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public GrilleRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateGrille(GRILLE Grille)
        {
            throw new NotImplementedException();
        }

        public Task CreateGrilleAsync(GRILLE Grille)
        {
            throw new NotImplementedException();
        }

        public void DeleteGrille(GRILLE Grille)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGrilleAsync(GRILLE Grille)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GRILLE> GetAllGrilles()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GRILLE>> GetAllGrillesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GRILLE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public GRILLE GetGrilleByCodeGrille(string CodeGrille)
        {
            throw new NotImplementedException();
        }

        public Task<GRILLE> GetGrilleByCodeGrilleAsync(string CodeGrille)
        {
            throw new NotImplementedException();
        }

        public GRILLE GetGrilleByLibelleGrille(string LibelleGrille)
        {
            throw new NotImplementedException();
        }

        public void UpdateGrille(GRILLE Grille)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGrilleAsync(GRILLE Grille)
        {
            throw new NotImplementedException();
        }
    }
}