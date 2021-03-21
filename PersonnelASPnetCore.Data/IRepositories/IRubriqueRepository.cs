using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IRubriqueRepository
    {
        void CreateRubrique(RUBRIQUE Rubrique);
        Task CreateRubriqueAsync(RUBRIQUE Rubrique);
        RUBRIQUE GetRubriqueByCodeRubrique(string CodeRubrique);
        RUBRIQUE GetRubriqueByLibelleRubrique(string LibelleRubrique);
        IEnumerable<RUBRIQUE> GetAllRubriques();
        IEnumerable<RUBRIQUE> GetAllWithRefernces();
        Task<IEnumerable<RUBRIQUE>> GetAllRubriquesAsync();
        Task<RUBRIQUE> GetRubriqueByCodeRubriqueAsync(string CodeRubrique);
        void UpdateRubrique(RUBRIQUE Rubrique);
        Task UpdateRubriqueAsync(RUBRIQUE Rubrique);
        void DeleteRubrique(RUBRIQUE Rubrique);
        Task DeleteRubriqueAsync(RUBRIQUE Rubrique);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}