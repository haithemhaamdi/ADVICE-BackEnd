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
    public class ParametreComptabiliteRepository : RepositoryBase<PARAMETRE_COMPTABILITE>, IParametreComptabiliteRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public ParametreComptabiliteRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateParametreComptabilite(PARAMETRE_COMPTABILITE ParametreComptabilite)
        {
            throw new NotImplementedException();
        }

        public Task CreateParametreComptabiliteAsync(PARAMETRE_COMPTABILITE ParametreComptabilite)
        {
            throw new NotImplementedException();
        }

        public void DeleteParametreComptabilite(PARAMETRE_COMPTABILITE ParametreComptabilite)
        {
            throw new NotImplementedException();
        }

        public Task DeleteParametreComptabiliteAsync(PARAMETRE_COMPTABILITE ParametreComptabilite)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PARAMETRE_COMPTABILITE> GetAllParametreComptabilites()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PARAMETRE_COMPTABILITE>> GetAllParametreComptabilitesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PARAMETRE_COMPTABILITE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public PARAMETRE_COMPTABILITE GetParametreComptabiliteByCodeParametre(string CodeParametre)
        {
            throw new NotImplementedException();
        }

        public Task<PARAMETRE_COMPTABILITE> GetParametreComptabiliteByCodeParametreAsync(string CodeParametre)
        {
            throw new NotImplementedException();
        }

        public PARAMETRE_COMPTABILITE GetParametreComptabiliteByGroupe(string Groupe)
        {
            throw new NotImplementedException();
        }

        public void UpdateParametreComptabilite(PARAMETRE_COMPTABILITE ParametreComptabilite)
        {
            throw new NotImplementedException();
        }

        public Task UpdateParametreComptabiliteAsync(PARAMETRE_COMPTABILITE ParametreComptabilite)
        {
            throw new NotImplementedException();
        }
    }
}
