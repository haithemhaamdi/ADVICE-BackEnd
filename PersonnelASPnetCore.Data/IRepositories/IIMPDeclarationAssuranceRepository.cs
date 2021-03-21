using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IIMPDeclarationAssuranceRepository
    {
        void CreateIMPDeclarationAssurance(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance);
        Task CreateIMPDeclarationAssuranceAsync(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance);
        IMP_DECLARATION_ASSURANCE GetIMPDeclarationAssuranceByCodeEmploye(string CodeEmploye);
        IEnumerable<IMP_DECLARATION_ASSURANCE> GetAllIMPDeclarationAssurances();
        IEnumerable<IMP_DECLARATION_ASSURANCE> GetAllWithRefernces();
        Task<IEnumerable<IMP_DECLARATION_ASSURANCE>> GetAllIMPDeclarationAssurancesAsync();
        Task<IMP_DECLARATION_ASSURANCE> GetIMPDeclarationAssuranceByCodeEmployeAsync(string CodeEmploye);
        void UpdateIMPDeclarationAssurance(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance);
        Task UpdateIMPDeclarationAssuranceAsync(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance);
        void DeleteIMPDeclarationAssurance(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance);
        Task DeleteIMPDeclarationAssuranceAsync(IMP_DECLARATION_ASSURANCE IMPDeclarationAssurance);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}