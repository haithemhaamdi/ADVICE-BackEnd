using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IDepartementRepository
    {
        void CreateDepartement(DEPARTEMENT Departement);
        Task CreateDepartementAsync(DEPARTEMENT Departement);
        DEPARTEMENT GetDepartementByCodeDepartement(string CodeDepartement);
        DEPARTEMENT GetDepartementByLibelleDepartement(string LibelleDepartement);
        IEnumerable<DEPARTEMENT> GetAllDepartements();
        IEnumerable<DEPARTEMENT> GetAllWithRefernces();
        Task<IEnumerable<DEPARTEMENT>> GetAllDepartementsAsync();
        Task<DEPARTEMENT> GetDepartementByCodeDepartementAsync(string CodeDepartement);
        void UpdateDepartement(DEPARTEMENT Departement);
        Task UpdateDepartementAsync(DEPARTEMENT Departement);
        void DeleteDepartement(DEPARTEMENT Departement);
        Task DeleteDepartementAsync(DEPARTEMENT Departement);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}