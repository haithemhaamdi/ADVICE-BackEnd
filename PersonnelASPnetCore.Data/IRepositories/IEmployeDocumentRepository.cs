using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEmployeDocumentRepository
    {
        void CreateBordereau(EMPLOYE_DOCUMENT EmployeDocument);
        Task CreateBordereauAsync(EMPLOYE_DOCUMENT Bordereau);
        EMPLOYE_DOCUMENT GetBordereauByCodeDocument(string CodeDocument);
        EMPLOYE_DOCUMENT GetBordereauByCodeEmploye(string CodeEmploye);
        IEnumerable<EMPLOYE_DOCUMENT> GetAllBordereaus();
        IEnumerable<EMPLOYE_DOCUMENT> GetAllWithRefernces();
        Task<IEnumerable<EMPLOYE_DOCUMENT>> GetAllBordereausAsync();
        Task<EMPLOYE_DOCUMENT> GetBordereauByCodeDocumentAsync(string CodeDocument);
        void UpdateBordereau(EMPLOYE_DOCUMENT Bordereau);
        Task UpdateBordereauAsync(EMPLOYE_DOCUMENT Bordereau);
        void DeleteBordereau(EMPLOYE_DOCUMENT Bordereau);
        Task DeleteBordereauAsync(EMPLOYE_DOCUMENT Bordereau);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}