using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeCongeRepository
    {
        void CreateEmployeConge(EMPLOYE_CONGE EmployeConge);
        Task CreateEmployeCongeAsync(EMPLOYE_CONGE EmployeConge);
        EMPLOYE_CONGE GetEmployeCongeByCodeConge(string CodeConge);
        EMPLOYE_CONGE GetEmployeCongeByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_CONGE> GetAllEmployeConges();
        IEnumerable<EMPLOYE_CONGE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_CONGE>> GetAllEmployeCongesAsync();
        Task<EMPLOYE_CONGE> GetEmployeCongeByCodeCongeAsync(string CodeConge);
        void UpdateEmployeConge(EMPLOYE_CONGE EmployeConge);
        Task UpdateEmployeCongeAsync(EMPLOYE_CONGE EmployeConge);
        void DeleteEmployeConge(EMPLOYE_CONGE EmployeConge);
        Task DeleteEmployeCongeAsync(EMPLOYE_CONGE EmployeConge);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}