using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ITypeRubriqueRepository
    {
        void CreateTypeRubrique(TYPE_RUBRIQUE TypeRubrique);
        Task CreateTypeRubriqueAsync(TYPE_RUBRIQUE TypeRubrique);
        TYPE_RUBRIQUE GetTypeRubriqueByCodeTypeRubrique(string CodeTypeRubrique);
        IEnumerable<TYPE_RUBRIQUE> GetAllTypeRubriques();
        IEnumerable<TYPE_RUBRIQUE> GetAllWithRefernces();
        Task<IEnumerable<TYPE_RUBRIQUE>> GetAllTypeRubriquesAsync();
        Task<TYPE_RUBRIQUE> GetTypeRubriqueByCodeTypeRubriqueAsync(string CodeTypeRubrique);
        void UpdateTypeRubrique(TYPE_RUBRIQUE TypeRubrique);
        Task UpdateTypeRubriqueAsync(TYPE_RUBRIQUE TypeRubrique);
        void DeleteTypeRubrique(TYPE_RUBRIQUE TypeRubrique);
        Task DeleteTypeRubriqueAsync(TYPE_RUBRIQUE TypeRubrique);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}