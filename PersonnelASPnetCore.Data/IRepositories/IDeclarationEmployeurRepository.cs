using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IDeclarationEmployeurRepository
    {
        void CreateDeclarationEmployeur(DECLARATION_EMPLOYEUR DeclarationEmployeur);
        Task CreateDeclarationEmployeurAsync(DECLARATION_EMPLOYEUR DeclarationEmployeur);
        DECLARATION_EMPLOYEUR GetDeclarationEmployeurByCodeEmploye(string CodeEmploye);
        DECLARATION_EMPLOYEUR GetDeclarationEmployeurByMatriculeEmploye(string MatriculeEmploye);
        IEnumerable<DECLARATION_EMPLOYEUR> GetAllDeclarationEmployeurs();
        IEnumerable<DECLARATION_EMPLOYEUR> GetAllWithRefernces();
        Task<IEnumerable<DECLARATION_EMPLOYEUR>> GetAllDeclarationEmployeursAsync();
        Task<DECLARATION_EMPLOYEUR> GetDeclarationEmployeurByCodeEmployeAsync(string CodeEmploye);
        void UpdateDeclarationEmployeur(DECLARATION_EMPLOYEUR DeclarationEmployeur);
        Task UpdateDeclarationEmployeurAsync(DECLARATION_EMPLOYEUR DeclarationEmployeur);
        void DeleteDeclarationEmployeur(DECLARATION_EMPLOYEUR DeclarationEmployeur);
        Task DeleteDeclarationEmployeurAsync(DECLARATION_EMPLOYEUR DeclarationEmployeur);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}