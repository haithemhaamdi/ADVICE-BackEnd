using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IParametrePointageRepository
    {
        void CreateParametrePointage(PARAMETRE_POINTAGE ParametrePointage);
        Task CreateParametrePointageAsync(PARAMETRE_POINTAGE ParametrePointage);
        PARAMETRE_POINTAGE GetParametrePointageByID(int Id);
        IEnumerable<PARAMETRE_POINTAGE> GetAllParametrePointages();
        IEnumerable<PARAMETRE_POINTAGE> GetAllWithRefernces();
        Task<IEnumerable<PARAMETRE_POINTAGE>> GetAllParametrePointagesAsync();
        Task<PARAMETRE_POINTAGE> GetParametrePointageByIDAsync(int Id);
        void UpdateParametrePointage(PARAMETRE_POINTAGE ParametrePointage);
        Task UpdateParametrePointageAsync(PARAMETRE_POINTAGE ParametrePointage);
        void DeleteParametrePointage(PARAMETRE_POINTAGE ParametrePointage);
        Task DeleteParametrePointageAsync(PARAMETRE_POINTAGE ParametrePointage);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}