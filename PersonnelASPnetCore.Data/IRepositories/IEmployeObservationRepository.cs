using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeObservationRepository
    {
        void CreateEmployeObservation(EMPLOYE_OBSERVATION EmployeObservation);
        Task CreateEmployeObservationAsync(EMPLOYE_OBSERVATION EmployeObservation);
        EMPLOYE_OBSERVATION GetEmployeObservationByCodeObservation(string CodeObservation);
        EMPLOYE_OBSERVATION GetEmployeObservationByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_OBSERVATION> GetAllEmployeObservations();
        IEnumerable<EMPLOYE_OBSERVATION> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_OBSERVATION>> GetAllEmployeObservationsAsync();
        Task<EMPLOYE_OBSERVATION> GetEmployeObservationByCodeObservationAsync(string CodeObservation);
        void UpdateEmployeObservation(EMPLOYE_OBSERVATION EmployeObservation);
        Task UpdateEmployeObservationAsync(EMPLOYE_OBSERVATION EmployeObservation);
        void DeleteEmployeObservation(EMPLOYE_OBSERVATION EmployeObservation);
        Task DeleteEmployeObservationAsync(EMPLOYE_OBSERVATION EmployeObservation);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}