using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeDeductionRepository
    {
        void CreateEmployeDeduction(EMPLOYE_DEDUCTION EmployeDeduction);
        Task CreateEmployeDeductionAsync(EMPLOYE_DEDUCTION EmployeDeduction);
        EMPLOYE_DEDUCTION GetEmployeDeductionByCodeDeduction(string CodeDeduction);
        EMPLOYE_DEDUCTION GetEmployeDeductionByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_DEDUCTION> GetAllEmployeDeductions();
        IEnumerable<EMPLOYE_DEDUCTION> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_DEDUCTION>> GetAllEmployeDeductionsAsync();
        Task<EMPLOYE_DEDUCTION> GetEmployeDeductionByCodeDeductionAsync(string CodeDeduction);
        void UpdateEmployeDeduction(EMPLOYE_DEDUCTION EmployeDeduction);
        Task UpdateEmployeDeductionAsync(EMPLOYE_DEDUCTION EmployeDeduction);
        void DeleteEmployeDeduction(EMPLOYE_DEDUCTION EmployeDeduction);
        Task DeleteEmployeDeductionAsync(EMPLOYE_DEDUCTION EmployeDeduction);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}