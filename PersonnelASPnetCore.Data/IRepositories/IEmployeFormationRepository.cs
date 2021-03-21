using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeFormationRepository
    {
        void CreateEmployeFormation(EMPLOYE_FORMATION EmployeFormation);
        Task CreateEmployeFormationAsync(EMPLOYE_FORMATION EmployeFormation);
        EMPLOYE_FORMATION GetEmployeFormationByCodeFormation(string CodeFormation);
        EMPLOYE_FORMATION GetEmployeFormationByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_FORMATION> GetAllEmployeFormations();
        IEnumerable<EMPLOYE_FORMATION> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_FORMATION>> GetAllEmployeFormationsAsync();
        Task<EMPLOYE_FORMATION> GetEmployeFormationByCodeFormationAsync(string CodeFormation);
        void UpdateEmployeFormation(EMPLOYE_FORMATION EmployeFormation);
        Task UpdateEmployeFormationAsync(EMPLOYE_FORMATION EmployeFormation);
        void DeleteEmployeFormation(EMPLOYE_FORMATION EmployeFormation);
        Task DeleteEmployeFormationAsync(EMPLOYE_FORMATION EmployeFormation);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}