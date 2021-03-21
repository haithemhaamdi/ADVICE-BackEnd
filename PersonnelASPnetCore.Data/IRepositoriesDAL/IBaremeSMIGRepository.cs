using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IBaremeSMIGRepository
    {
        IEnumerable<BAREME_SMIG> GetAllBaremeSMIGsPS();
        Task CreateBaremeSMIGPSAsync(BAREME_SMIG BaremeSMIG);
        void UpdateBaremeSMIGPS(BAREME_SMIG BaremeSMIG);
        BAREME_SMIG GetBaremeSMIGDetailsPS(decimal Montant1, decimal Montant2);
        void DeleteBaremeSMIGPS(decimal Montant1, decimal Montant2);
    }
}