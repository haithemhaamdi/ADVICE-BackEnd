using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.Repositories
{
    public class EmployeAffichageGrilleRepository : RepositoryBase<EMPLOYE_AFFICHAGE_GRILLE>, IEmployeAffichageGrilleRepository, IDisposable
    {
        IConfiguration _ConnectionString;
        ARTIPERSONNEL_SOC001Context _ctx;

        public EmployeAffichageGrilleRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
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

        public void CreateEmployeAffichageGrille(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille)
        {
            throw new NotImplementedException();
        }

        public Task CreateEmployeAffichageGrilleAsync(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeAffichageGrille(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeAffichageGrilleAsync(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_AFFICHAGE_GRILLE> GetAllEmployeAffichageGrilles()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EMPLOYE_AFFICHAGE_GRILLE>> GetAllEmployeAffichageGrillesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EMPLOYE_AFFICHAGE_GRILLE> GetAllWithRefernces()
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_AFFICHAGE_GRILLE GetEmployeAffichageGrilleByCodeOperateur(string CodeOperateur)
        {
            throw new NotImplementedException();
        }

        public Task<EMPLOYE_AFFICHAGE_GRILLE> GetEmployeAffichageGrilleByCodeOperateurAsync(string CodeOperateur)
        {
            throw new NotImplementedException();
        }

        public EMPLOYE_AFFICHAGE_GRILLE GetEmployeAffichageGrilleByColonneEmploye(string ColonneEmploye)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeAffichageGrille(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeAffichageGrilleAsync(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille)
        {
            throw new NotImplementedException();
        }
    }
}