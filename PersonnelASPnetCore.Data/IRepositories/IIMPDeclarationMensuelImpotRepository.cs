using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IIMPDeclarationMensuelImpotRepository
    {
        void CreateIMPDeclarationMensuelImpot(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot);
        Task CreateIMPDeclarationMensuelImpotAsync(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot);
        IEnumerable<IMP_DECLARATION_MENSUEL_IMPOT> GetAllIMPDeclarationMensuelImpots();
        IEnumerable<IMP_DECLARATION_MENSUEL_IMPOT> GetAllWithRefernces();
        Task<IEnumerable<IMP_DECLARATION_MENSUEL_IMPOT>> GetAllIMPDeclarationMensuelImpotsAsync();
        void UpdateIMPDeclarationMensuelImpot(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot);
        Task UpdateIMPDeclarationMensuelImpotAsync(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot);
        void DeleteIMPDeclarationMensuelImpot(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot);
        Task DeleteIMPDeclarationMensuelImpotAsync(IMP_DECLARATION_MENSUEL_IMPOT IMPDeclarationMensuelImpot);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}