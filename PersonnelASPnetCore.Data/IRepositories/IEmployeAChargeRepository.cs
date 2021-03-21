using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeAChargeRepository
    {
        void CreateEmployeACharge(EMPLOYE_A_CHARGE EmployeACharge);
        Task CreateEmployeAChargeAsync(EMPLOYE_A_CHARGE EmployeACharge);
        EMPLOYE_A_CHARGE GetEmployeAChargeByCodeEmploye(string CodeEmploye);
        EMPLOYE_A_CHARGE GetEmployeAChargeByCodePersonne(string CodePersonne);
        IEnumerable<EMPLOYE_A_CHARGE> GetAllEmployeACharges();
        IEnumerable<EMPLOYE_A_CHARGE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_A_CHARGE>> GetAllEmployeAChargesAsync();
        Task<EMPLOYE_A_CHARGE> GetEmployeAChargeByCodeEmployeAsync(string CodeEmploye);
        void UpdateEmployeACharge(EMPLOYE_A_CHARGE EmployeACharge);
        Task UpdateEmployeAChargeAsync(EMPLOYE_A_CHARGE EmployeACharge);
        void DeleteEmployeACharge(EMPLOYE_A_CHARGE EmployeACharge);
        Task DeleteEmployeAChargeAsync(EMPLOYE_A_CHARGE EmployeACharge);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}