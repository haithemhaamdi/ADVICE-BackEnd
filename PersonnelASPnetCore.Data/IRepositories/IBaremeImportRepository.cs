using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBaremeImportRepository
    {
        void CreateBaremeImport(BAREME_IMPOT BaremeImport);
        Task CreateBaremeImportAsync(BAREME_IMPOT BaremeImport);
        BAREME_IMPOT GetBaremeImportByMontant(decimal Montant1, decimal Montant2);
        IEnumerable<BAREME_IMPOT> GetAllBaremeImports();
        IEnumerable<BAREME_IMPOT> GetAllWithRefernces();
        Task<IEnumerable<BAREME_IMPOT>> GetAllBaremeImportsAsync();
        Task<BAREME_IMPOT> GetBaremeImportByMontantAsync(string NumeroBaremeImport);
        void UpdateBaremeImport(BAREME_IMPOT BaremeImport);
        Task UpdateBaremeImportAsync(BAREME_IMPOT BaremeImport);
        void DeleteBaremeImport(BAREME_IMPOT BaremeImport);
        Task DeleteBaremeImportAsync(BAREME_IMPOT BaremeImport);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}