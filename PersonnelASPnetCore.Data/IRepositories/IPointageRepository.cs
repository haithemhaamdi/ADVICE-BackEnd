using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IPointageRepository
    {
        void CreatePointage(POINTAGE Pointage);
        Task CreatePointageAsync(POINTAGE Pointage);
        POINTAGE GetPointageByNumeroPointage(string NumeroPointage);
        POINTAGE GetPointageByDatePointage(DateTime DatePointage);
        IEnumerable<POINTAGE> GetAllPointages();
        IEnumerable<POINTAGE> GetAllWithRefernces();
        Task<IEnumerable<POINTAGE>> GetAllPointagesAsync();
        Task<POINTAGE> GetPointageByNumeroPointageAsync(string NumeroPointage);
        void UpdatePointage(POINTAGE Pointage);
        Task UpdatePointageAsync(POINTAGE Pointage);
        void DeletePointage(POINTAGE Pointage);
        Task DeletePointageAsync(POINTAGE Pointage);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}