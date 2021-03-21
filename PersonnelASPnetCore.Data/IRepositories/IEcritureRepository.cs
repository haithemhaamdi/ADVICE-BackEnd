using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEcritureRepository
    {
        void CreateEcriture(ECRITURE Ecriture);
        Task CreateEcritureAsync(ECRITURE Ecriture);
        ECRITURE GetEcritureByNumeroEcriture(string NumeroEcriture);
        ECRITURE GetEcritureByDateEcriture(DateTime DateEcriture);
        IEnumerable<ECRITURE> GetAllEcritures();
        IEnumerable<ECRITURE> GetAllWithRefernces();
        Task<IEnumerable<ECRITURE>> GetAllEcrituresAsync();
        Task<ECRITURE> GetEcritureByNumeroEcritureAsync(string NumeroEcriture);
        void UpdateEcriture(ECRITURE Ecriture);
        Task UpdateEcritureAsync(ECRITURE Ecriture);
        void DeleteEcriture(ECRITURE Ecriture);
        Task DeleteEcritureAsync(ECRITURE Ecriture);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}