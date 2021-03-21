using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class FonctionRepository : RepositoryBase<FONCTION>, IFonctionRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public FonctionRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration) : base(repositoryContext)
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

        public void CreateFonction(FONCTION Fonction)
        {
            throw new NotImplementedException();
        }

        public Task CreateFonctionAsync(FONCTION Fonction)
        {
            throw new NotImplementedException();
        }

        public void DeleteFonction(FONCTION Fonction)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFonctionAsync(FONCTION Fonction)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FONCTION> GetAllFonctions()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FONCTION>> GetAllFonctionsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FONCTION> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public FONCTION GetFonctionByCodeFonction(string CodeFonction)
        {
            throw new NotImplementedException();
        }

        public Task<FONCTION> GetFonctionByCodeFonctionAsync(string CodeFonction)
        {
            throw new NotImplementedException();
        }

        public FONCTION GetFonctionByLibelleFonction(string LibelleFonction)
        {
            throw new NotImplementedException();
        }

        public void UpdateFonction(FONCTION Fonction)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFonctionAsync(FONCTION Fonction)
        {
            throw new NotImplementedException();
        }
    }
}