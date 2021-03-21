using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ISituationCongeSpecialRepository
    {
        void CreateSituationCongeSpecial(SITUATION_CONGE_SPECIAL SituationCongeSpecial);
        Task CreateSituationCongeSpecialAsync(SITUATION_CONGE_SPECIAL SituationCongeSpecial);
        SITUATION_CONGE_SPECIAL GetSituationCongeSpecialByCodeRubrique(string CodeRubrique);
        SITUATION_CONGE_SPECIAL GetSituationCongeSpecialByCodeEmploye(string CodeEmploye);
        IEnumerable<SITUATION_CONGE_SPECIAL> GetAllSituationCongeSpecials();
        IEnumerable<SITUATION_CONGE_SPECIAL> GetAllWithRefernces();
        Task<IEnumerable<SITUATION_CONGE_SPECIAL>> GetAllSituationCongeSpecialsAsync();
        Task<SITUATION_CONGE_SPECIAL> GetSituationCongeSpecialByCodeRubriqueAsync(string CodeRubrique);
        void UpdateSituationCongeSpecial(SITUATION_CONGE_SPECIAL SituationCongeSpecial);
        Task UpdateSituationCongeSpecialAsync(SITUATION_CONGE_SPECIAL SituationCongeSpecial);
        void DeleteSituationCongeSpecial(SITUATION_CONGE_SPECIAL SituationCongeSpecial);
        Task DeleteSituationCongeSpecialAsync(SITUATION_CONGE_SPECIAL SituationCongeSpecial);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}