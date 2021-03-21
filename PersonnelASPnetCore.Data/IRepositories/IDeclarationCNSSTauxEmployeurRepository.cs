using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IDeclarationCNSSTauxEmployeurRepository
    {
        void CreateDeclarationCNSSTauxEmployeur(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur);
        Task CreateDeclarationCNSSTauxEmployeurAsync(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur);
        DECLARATION_CNSS_TAUX_EMPLOYEUR GetDeclarationCNSSTauxEmployeurByCodeEmploye(string CodeEmploye);
        DECLARATION_CNSS_TAUX_EMPLOYEUR GetDeclarationCNSSTauxEmployeurByDateDeclarationCNSS(DateTime DateDebut, string DateFin);
        IEnumerable<DECLARATION_CNSS_TAUX_EMPLOYEUR> GetAllDeclarationCNSSTauxEmployeurs();
        IEnumerable<DECLARATION_CNSS_TAUX_EMPLOYEUR> GetAllWithRefernces();
        Task<IEnumerable<DECLARATION_CNSS_TAUX_EMPLOYEUR>> GetAllDeclarationCNSSTauxEmployeursAsync();
        Task<DECLARATION_CNSS_TAUX_EMPLOYEUR> GetDeclarationCNSSTauxEmployeurByCodeEmployeAsync(string CodeEmploye);
        void UpdateDeclarationCNSSTauxEmployeur(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur);
        Task UpdateDeclarationCNSSTauxEmployeurAsync(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur);
        void DeleteDeclarationCNSSTauxEmployeur(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur);
        Task DeleteDeclarationCNSSTauxEmployeurAsync(DECLARATION_CNSS_TAUX_EMPLOYEUR DeclarationCNSSTauxEmployeur);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}