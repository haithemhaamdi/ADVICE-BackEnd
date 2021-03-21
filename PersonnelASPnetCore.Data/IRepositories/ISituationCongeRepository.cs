using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ISituationCongeRepository
    {
        void CreateSituationConge(SITUATION_CONGE SituationConge);
        Task CreateSituationCongeAsync(SITUATION_CONGE SituationConge);
        SITUATION_CONGE GetSituationCongeByCodeEmploye(string CodeEmploye);
        SITUATION_CONGE GetSituationCongeByNomEmploye(string NomEmploye);
        IEnumerable<SITUATION_CONGE> GetAllSituationConges();
        IEnumerable<SITUATION_CONGE> GetAllWithRefernces();
        Task<IEnumerable<SITUATION_CONGE>> GetAllSituationCongesAsync();
        Task<SITUATION_CONGE> GetSituationCongeByCodeAsync(string Code);
        void UpdateSituationConge(SITUATION_CONGE SituationConge);
        Task UpdateSituationCongeAsync(SITUATION_CONGE SituationConge);
        void DeleteSituationConge(SITUATION_CONGE SituationConge);
        Task DeleteSituationCongeAsync(SITUATION_CONGE SituationConge);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}