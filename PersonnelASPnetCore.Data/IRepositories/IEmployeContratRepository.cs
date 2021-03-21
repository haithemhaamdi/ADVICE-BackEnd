using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeContratRepository
    {
        void CreateEmployeContrat(EMPLOYE_CONTRAT EmployeContrat);
        Task CreateEmployeContratAsync(EMPLOYE_CONTRAT EmployeContrat);
        EMPLOYE_CONTRAT GetEmployeContratByCodeContratEmploye(string CodeContratEmploye);
        EMPLOYE_CONTRAT GetEmployeContratByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_CONTRAT> GetAllEmployeContrats();
        IEnumerable<EMPLOYE_CONTRAT> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_CONTRAT>> GetAllEmployeContratsAsync();
        Task<EMPLOYE_CONTRAT> GetEmployeContratByCodeContratEmployeAsync(string CodeContratEmploye);
        void UpdateEmployeContrat(EMPLOYE_CONTRAT EmployeContrat);
        Task UpdateEmployeContratAsync(EMPLOYE_CONTRAT EmployeContrat);
        void DeleteEmployeContrat(EMPLOYE_CONTRAT EmployeContrat);
        Task DeleteEmployeContratAsync(EMPLOYE_CONTRAT EmployeContrat);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}