using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IModeleCorrespondanceRepository
    {
        void CreateModeleCorrespondance(MODELE_CORRESPONDANCE ModeleCorrespondance);
        Task CreateModeleCorrespondanceAsync(MODELE_CORRESPONDANCE ModeleCorrespondance);
        MODELE_CORRESPONDANCE GetModeleCorrespondanceByNumeroModeleCorrespondance(string NumeroModeleCorrespondance);
        MODELE_CORRESPONDANCE GetModeleCorrespondanceByDateModeleCorrespondance(DateTime DateModeleCorrespondance);
        IEnumerable<MODELE_CORRESPONDANCE> GetAllModeleCorrespondances();
        IEnumerable<MODELE_CORRESPONDANCE> GetAllWithRefernces();
        Task<IEnumerable<MODELE_CORRESPONDANCE>> GetAllModeleCorrespondancesAsync();
        Task<MODELE_CORRESPONDANCE> GetModeleCorrespondanceByNumeroModeleCorrespondanceAsync(string NumeroModeleCorrespondance);
        void UpdateModeleCorrespondance(MODELE_CORRESPONDANCE ModeleCorrespondance);
        Task UpdateModeleCorrespondanceAsync(MODELE_CORRESPONDANCE ModeleCorrespondance);
        void DeleteModeleCorrespondance(MODELE_CORRESPONDANCE ModeleCorrespondance);
        Task DeleteModeleCorrespondanceAsync(MODELE_CORRESPONDANCE ModeleCorrespondance);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}