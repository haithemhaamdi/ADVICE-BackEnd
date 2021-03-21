using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IBaremeImportRepository
    {
        IEnumerable<BAREME_IMPOT> GetAllBaremeImportsPS();
        Task CreateBaremeImportPSAsync(BAREME_IMPOT BaremeImport);
        void UpdateBaremeImportPS(BAREME_IMPOT BaremeImport);
        BAREME_IMPOT GetBaremeImportDetailsPS(decimal Montant1, decimal Montant2);
        void DeleteBaremeImportPS(decimal Montant1, decimal Montant2);
    }
}