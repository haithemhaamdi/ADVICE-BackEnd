using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeAbsenceRepository
    {
        void CreateEmployeAbsence(EMPLOYE_ABSENCE EmployeAbsence);
        Task CreateEmployeAbsenceAsync(EMPLOYE_ABSENCE EmployeAbsence);
        EMPLOYE_ABSENCE GetEmployeAbsenceByCodeAbsence(string CodeAbsence);
        EMPLOYE_ABSENCE GetEmployeAbsenceByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_ABSENCE> GetAllEmployeAbsences();
        IEnumerable<EMPLOYE_ABSENCE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_ABSENCE>> GetAllEmployeAbsencesAsync();
        Task<EMPLOYE_ABSENCE> GetEmployeAbsenceByCodeAbsenceAsync(string CodeAbsence);
        void UpdateEmployeAbsence(EMPLOYE_ABSENCE EmployeAbsence);
        Task UpdateEmployeAbsenceAsync(EMPLOYE_ABSENCE EmployeAbsence);
        void DeleteEmployeAbsence(EMPLOYE_ABSENCE EmployeAbsence);
        Task DeleteEmployeAbsenceAsync(EMPLOYE_ABSENCE EmployeAbsence);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}