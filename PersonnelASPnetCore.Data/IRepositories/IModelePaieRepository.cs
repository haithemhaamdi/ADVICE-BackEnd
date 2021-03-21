using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IModelePaieRepository
    {
        void CreateModelePaie(MODELE_PAIE ModelePaie);
        Task CreateModelePaieAsync(MODELE_PAIE ModelePaie);
        MODELE_PAIE GetModelePaieByNumeroModelePaie(string NumeroModelePaie);
        MODELE_PAIE GetModelePaieByDateModelePaie(DateTime DateModelePaie);
        IEnumerable<MODELE_PAIE> GetAllModelePaies();
        IEnumerable<MODELE_PAIE> GetAllWithRefernces();
        Task<IEnumerable<MODELE_PAIE>> GetAllModelePaiesAsync();
        Task<MODELE_PAIE> GetModelePaieByNumeroModelePaieAsync(string NumeroModelePaie);
        void UpdateModelePaie(MODELE_PAIE ModelePaie);
        Task UpdateModelePaieAsync(MODELE_PAIE ModelePaie);
        void DeleteModelePaie(MODELE_PAIE ModelePaie);
        Task DeleteModelePaieAsync(MODELE_PAIE ModelePaie);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}