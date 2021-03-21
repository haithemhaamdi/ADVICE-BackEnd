using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeDesciplineRepository
    {
        void CreateEmployeDescipline(EMPLOYE_DISCIPLINE EmployeDescipline);
        Task CreateEmployeDesciplineAsync(EMPLOYE_DISCIPLINE EmployeDescipline);
        EMPLOYE_DISCIPLINE GetEmployeDesciplineByCodeDiscipline(string CodeDiscipline);
        EMPLOYE_DISCIPLINE GetEmployeDesciplineByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_DISCIPLINE> GetAllEmployeDesciplines();
        IEnumerable<EMPLOYE_DISCIPLINE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_DISCIPLINE>> GetAllEmployeDesciplinesAsync();
        Task<EMPLOYE_DISCIPLINE> GetEmployeDesciplineByCodeDisciplineAsync(string CodeDiscipline);
        void UpdateEmployeDescipline(EMPLOYE_DISCIPLINE EmployeDescipline);
        Task UpdateEmployeDesciplineAsync(EMPLOYE_DISCIPLINE EmployeDescipline);
        void DeleteEmployeDescipline(EMPLOYE_DISCIPLINE EmployeDescipline);
        Task DeleteEmployeDesciplineAsync(EMPLOYE_DISCIPLINE EmployeDescipline);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}