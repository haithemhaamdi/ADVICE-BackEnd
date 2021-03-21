using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IDeclarationCNSSRepository
    {
        void CreateDeclarationCNSS(DECLARATION_CNSS declarationCNSS);
        Task CreateDeclarationCNSSAsync(DECLARATION_CNSS declarationCNSS);
        DECLARATION_CNSS GetDeclarationCNSSByCodeOperateur(string codeOperateur);
        IEnumerable<DECLARATION_CNSS> GetAllDeclarationCNSS();
        IEnumerable<DECLARATION_CNSS> GetAllWithRefernces();
        Task<IEnumerable<DECLARATION_CNSS>> GetAllDeclarationCNSSsAsync();
        Task<DECLARATION_CNSS> GetDeclarationCNSSByDateAsync(DateTime dateDeclaration);
        void UpdateDeclarationCNSS(DECLARATION_CNSS declarationCNSS);
        Task UpdateDeclarationCNSSAsync(DECLARATION_CNSS declarationCNSS);
        void DeleteDeclarationCNSS(DECLARATION_CNSS declarationCNSS);
        Task DeleteDeclarationCNSSAsync(DECLARATION_CNSS declarationCNSS);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}