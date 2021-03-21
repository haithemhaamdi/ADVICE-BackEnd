using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeAvanceRepository
    {
        void CreateEmployeAvance(EMPLOYE_AVANCE EmployeAvance);
        Task CreateEmployeAvanceAsync(EMPLOYE_AVANCE EmployeAvance);
        EMPLOYE_AVANCE GetEmployeAvanceByCodeAvance(string CodeAvance);
        EMPLOYE_AVANCE GetEmployeAvanceByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_AVANCE> GetAllEmployeAvances();
        IEnumerable<EMPLOYE_AVANCE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_AVANCE>> GetAllEmployeAvancesAsync();
        Task<EMPLOYE_AVANCE> GetEmployeAvanceByCodeAvanceAsync(string CodeAvance);
        void UpdateEmployeAvance(EMPLOYE_AVANCE EmployeAvance);
        Task UpdateEmployeAvanceAsync(EMPLOYE_AVANCE EmployeAvance);
        void DeleteEmployeAvance(EMPLOYE_AVANCE EmployeAvance);
        Task DeleteEmployeAvanceAsync(EMPLOYE_AVANCE EmployeAvance);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}