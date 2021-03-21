using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class IMPFicheAnnuellePaieRepository : RepositoryBase<APPELLATION>, IIMPFicheAnnuellePaieRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public IMPFicheAnnuellePaieRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateIMPFicheAnnuellePaie(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }

        public Task CreateIMPFicheAnnuellePaieAsync(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }

        public void DeleteIMPFicheAnnuellePaie(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIMPFicheAnnuellePaieAsync(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMP_FICHE_ANNUELLE_PAIE> GetAllIMPFicheAnnuellePaies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IMP_FICHE_ANNUELLE_PAIE>> GetAllIMPFicheAnnuellePaiesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMP_FICHE_ANNUELLE_PAIE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public IMP_FICHE_ANNUELLE_PAIE GetIMPFicheAnnuellePaieByCodeEmploye(string CodeEmploye)
        {
            throw new NotImplementedException();
        }

        public Task<IMP_FICHE_ANNUELLE_PAIE> GetIMPFicheAnnuellePaieByNumeroIMPFicheAnnuellePaieAsync(string NumeroIMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }

        public void UpdateIMPFicheAnnuellePaie(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }

        public Task UpdateIMPFicheAnnuellePaieAsync(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie)
        {
            throw new NotImplementedException();
        }
    }
}