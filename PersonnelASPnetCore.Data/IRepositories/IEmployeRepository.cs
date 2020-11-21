
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeRepository
    {
        void CreateEmploye(EMPLOYE Employe);
        Task CreateEmployeAsync(EMPLOYE Employe);
        EMPLOYE GetEmployeByID(string code);
        IEnumerable<EMPLOYE> GetAllEmployes();
        Task<IEnumerable<EMPLOYE>> GetAllEmployesAsync();
        Task<EMPLOYE> GetEmployeByIDAsync(string Code);
        void UpdateEmploye(EMPLOYE Employe);
        void DeleteEmploye(EMPLOYE Employe);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
