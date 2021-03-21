using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeCorrespondanceRepository
    {
        void CreateEmployeCorrespondance(EMPLOYE_CORRESPONDANCE EmployeCorrespondance);
        Task CreateEmployeCorrespondanceAsync(EMPLOYE_CORRESPONDANCE EmployeCorrespondance);
        EMPLOYE_CORRESPONDANCE GetEmployeCorrespondanceByCodeEmploye(string CodeEmploye);
        EMPLOYE_CORRESPONDANCE GetEmployeCorrespondanceByCodeDocument(string CodeDocument);
        IEnumerable<EMPLOYE_CORRESPONDANCE> GetAllEmployeCorrespondances();
        IEnumerable<EMPLOYE_CORRESPONDANCE> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_CORRESPONDANCE>> GetAllEmployeCorrespondancesAsync();
        Task<EMPLOYE_CORRESPONDANCE> GetEmployeCorrespondanceByCodeEmployeAsync(string CodeEmploye);
        void UpdateEmployeCorrespondance(EMPLOYE_CORRESPONDANCE EmployeCorrespondance);
        Task UpdateEmployeCorrespondanceAsync(EMPLOYE_CORRESPONDANCE EmployeCorrespondance);
        void DeleteEmployeCorrespondance(EMPLOYE_CORRESPONDANCE EmployeCorrespondance);
        Task DeleteEmployeCorrespondanceAsync(EMPLOYE_CORRESPONDANCE EmployeCorrespondance);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}