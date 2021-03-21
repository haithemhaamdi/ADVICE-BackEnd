using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeVentilationRepository
    {
        void CreateEmployeVentilation(EMPLOYE_VENTILATION EmployeVentilation);
        Task CreateEmployeVentilationAsync(EMPLOYE_VENTILATION EmployeVentilation);
        EMPLOYE_VENTILATION GetEmployeVentilationByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_VENTILATION> GetAllEmployeVentilations();
        IEnumerable<EMPLOYE_VENTILATION> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_VENTILATION>> GetAllEmployeVentilationsAsync();
        Task<EMPLOYE_VENTILATION> GetEmployeVentilationByCodeEmployeAsync(string CodeEmploye);
        void UpdateEmployeVentilation(EMPLOYE_VENTILATION EmployeVentilation);
        Task UpdateEmployeVentilationAsync(EMPLOYE_VENTILATION EmployeVentilation);
        void DeleteEmployeVentilation(EMPLOYE_VENTILATION EmployeVentilation);
        Task DeleteEmployeVentilationAsync(EMPLOYE_VENTILATION EmployeVentilation);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}