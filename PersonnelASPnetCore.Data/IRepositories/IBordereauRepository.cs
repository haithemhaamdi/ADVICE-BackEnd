using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBordereauRepository
    {
        void CreateBordereau(BORDEREAU Bordereau);
        Task CreateBordereauAsync(BORDEREAU Bordereau);
        BORDEREAU GetBordereauByNumeroBordereau(string NumeroBordereau);
        BORDEREAU GetBordereauByDateBordereau(DateTime DateBordereau);
        IEnumerable<BORDEREAU> GetAllBordereaus();
        IEnumerable<BORDEREAU> GetAllWithRefernces();
        Task<IEnumerable<BORDEREAU>> GetAllBordereausAsync();
        Task<BORDEREAU> GetBordereauByNumeroBordereauAsync(string NumeroBordereau);
        void UpdateBordereau(BORDEREAU Bordereau);
        Task UpdateBordereauAsync(BORDEREAU Bordereau);
        void DeleteBordereau(BORDEREAU Bordereau);
        Task DeleteBordereauAsync(BORDEREAU Bordereau);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}