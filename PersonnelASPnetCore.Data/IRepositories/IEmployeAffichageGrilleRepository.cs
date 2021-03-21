using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeAffichageGrilleRepository
    {
        void CreateEmployeAffichageGrille(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille);
        Task CreateEmployeAffichageGrilleAsync(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille);
        EMPLOYE_AFFICHAGE_GRILLE GetEmployeAffichageGrilleByCodeOperateur(string CodeOperateur);
        EMPLOYE_AFFICHAGE_GRILLE GetEmployeAffichageGrilleByColonneEmploye(string ColonneEmploye);
        IEnumerable<EMPLOYE_AFFICHAGE_GRILLE> GetAllEmployeAffichageGrilles();
        IEnumerable<EMPLOYE_AFFICHAGE_GRILLE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_AFFICHAGE_GRILLE>> GetAllEmployeAffichageGrillesAsync();
        Task<EMPLOYE_AFFICHAGE_GRILLE> GetEmployeAffichageGrilleByCodeOperateurAsync(string CodeOperateur);
        void UpdateEmployeAffichageGrille(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille);
        Task UpdateEmployeAffichageGrilleAsync(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille);
        void DeleteEmployeAffichageGrille(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille);
        Task DeleteEmployeAffichageGrilleAsync(EMPLOYE_AFFICHAGE_GRILLE EmployeAffichageGrille);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}