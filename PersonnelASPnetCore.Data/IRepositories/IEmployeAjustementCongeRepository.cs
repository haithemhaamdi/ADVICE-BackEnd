using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeAjustementCongeRepository
    {
        void CreateEmployeAjustementConge(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge);
        Task CreateEmployeAjustementCongeAsync(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge);
        EMPLOYE_AJUSTEMENT_CONGE GetEmployeAjustementCongeByCodeAjustementConge(string CodeAjustementConge);
        EMPLOYE_AJUSTEMENT_CONGE GetEmployeAjustementCongeByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_AJUSTEMENT_CONGE> GetAllEmployeAjustementConges();
        IEnumerable<EMPLOYE_AJUSTEMENT_CONGE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_AJUSTEMENT_CONGE>> GetAllEmployeAjustementCongesAsync();
        Task<EMPLOYE_AJUSTEMENT_CONGE> GetEmployeAjustementCongeByCodeAjustementCongeAsync(string CodeAjustementConge);
        void UpdateEmployeAjustementConge(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge);
        Task UpdateEmployeAjustementCongeAsync(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge);
        void DeleteEmployeAjustementConge(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge);
        Task DeleteEmployeAjustementCongeAsync(EMPLOYE_AJUSTEMENT_CONGE EmployeAjustementConge);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}