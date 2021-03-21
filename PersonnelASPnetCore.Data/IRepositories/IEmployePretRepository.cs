using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployePretRepository
    {
        void CreateEmployePret(EMPLOYE_PRET EmployePret);
        Task CreateEmployePretAsync(EMPLOYE_PRET EmployePret);
        EMPLOYE_PRET GetEmployePretByCodePret(string CodePret);
        EMPLOYE_PRET GetEmployePretByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_PRET> GetAllEmployePrets();
        IEnumerable<EMPLOYE_PRET> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_PRET>> GetAllEmployePretsAsync();
        Task<EMPLOYE_PRET> GetEmployePretByCodePretAsync(string CodePret);
        void UpdateEmployePret(EMPLOYE_PRET EmployePret);
        Task UpdateEmployePretAsync(EMPLOYE_PRET EmployePret);
        void DeleteEmployePret(EMPLOYE_PRET EmployePret);
        Task DeleteEmployePretAsync(EMPLOYE_PRET EmployePret);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}