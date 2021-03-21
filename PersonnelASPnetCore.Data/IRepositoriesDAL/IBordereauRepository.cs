using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IBordereauRepository
    {
        IEnumerable<BORDEREAU> GetAllBordereauxPS();
        Task CreateBordereauPSAsync(BORDEREAU Bordereau);
        void UpdateBordereauPS(BORDEREAU Bordereau);
        BORDEREAU GetBordereauDetailsPS(string NumeroBordereau);
        void DeleteBordereauPS(string NumeroBordereau);
    }
}