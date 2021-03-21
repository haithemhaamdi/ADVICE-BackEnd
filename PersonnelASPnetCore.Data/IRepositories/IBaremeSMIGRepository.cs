using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBaremeSMIGRepository
    {
        void CreateBaremeSMIG(BAREME_SMIG BaremeSMIG);
        Task CreateBaremeSMIGAsync(BAREME_SMIG BaremeSMIG);
        BAREME_SMIG GetBaremeSMIGByTaux(decimal Taux);
        IEnumerable<BAREME_SMIG> GetAllBaremeSMIGs();
        IEnumerable<BAREME_SMIG> GetAllWithRefernces();
        Task<IEnumerable<BAREME_SMIG>> GetAllBaremeSMIGsAsync();
        Task<BAREME_SMIG> GetBaremeSMIGByTauxAsync(decimal Taux);
        void UpdateBaremeSMIG(BAREME_SMIG BaremeSMIG);
        Task UpdateBaremeSMIGAsync(BAREME_SMIG BaremeSMIG);
        void DeleteBaremeSMIG(BAREME_SMIG BaremeSMIG);
        Task DeleteBaremeSMIGAsync(BAREME_SMIG BaremeSMIG);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}