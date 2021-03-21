using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonnelASPnetCore.Domaine.Entities;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IVirementRepository
    {
        void CreateVirement(VIREMENT Virement);
        Task CreateVirementAsync(VIREMENT Virement);
        VIREMENT GetVirementByNumeroVirement(string NumeroVirement);
        VIREMENT GetVirementByDateVirement(DateTime DateVirement);
        IEnumerable<VIREMENT> GetAllVirements();
        IEnumerable<VIREMENT> GetAllWithRefernces();
        Task<IEnumerable<VIREMENT>> GetAllVirementsAsync();
        Task<VIREMENT> GetVirementByNumeroVirementAsync(string NumeroVirement);
        void UpdateVirement(VIREMENT Virement);
        Task UpdateVirementAsync(VIREMENT Virement);
        void DeleteVirement(VIREMENT Virement);
        Task DeleteVirementAsync(VIREMENT Virement);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}