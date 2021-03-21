using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeRubriqueRepository
    {
        void CreateEmployeRubrique(EMPLOYE_RUBRIQUE EmployeRubrique);
        Task CreateEmployeRubriqueAsync(EMPLOYE_RUBRIQUE EmployeRubrique);
        EMPLOYE_RUBRIQUE GetEmployeRubriqueByCodeEmploye(string CodeEmploye);
        EMPLOYE_RUBRIQUE GetEmployeRubriqueByCodeRubrique(string CodeRubrique);
        IEnumerable<EMPLOYE_RUBRIQUE> GetAllEmployeRubriques();
        IEnumerable<EMPLOYE_RUBRIQUE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_RUBRIQUE>> GetAllEmployeRubriquesAsync();
        Task<EMPLOYE_RUBRIQUE> GetEmployeRubriqueByCodeEmployeAsync(string CodeEmploye);
        void UpdateEmployeRubrique(EMPLOYE_RUBRIQUE EmployeRubrique);
        Task UpdateEmployeRubriqueAsync(EMPLOYE_RUBRIQUE EmployeRubrique);
        void DeleteEmployeRubrique(EMPLOYE_RUBRIQUE EmployeRubrique);
        Task DeleteEmployeRubriqueAsync(EMPLOYE_RUBRIQUE EmployeRubrique);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
