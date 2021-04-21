
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IEmployeRepository<T> : IRepositoryBaseAsync<T> where T : class
    {
        IEnumerable<EMPLOYE> GetAllEmployesPS();
        EMPLOYE GetEmployesPSbyID(string codeEmp);
        Task<EMPLOYE> GetEmployeByIDAsync(string codeEmp);
        void IncrementConnectionPS(string codeEmp, int connection);
        Task CreateEmployePSAsync(EMPLOYE Employe);
        void UpdateEmployePS(EMPLOYE Employe);
        EMPLOYE GetEmployeDetailsPS(string id);
        void DeleteEmployePS(string id);
    }
}
