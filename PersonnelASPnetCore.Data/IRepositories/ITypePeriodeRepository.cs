using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface ITypePeriodeRepository
    {
        void CreateTypePeriode(TYPE_PERIODE TypePeriode);
        Task CreateTypePeriodeAsync(TYPE_PERIODE TypePeriode);
        TYPE_PERIODE GetTypePeriodeByCodeTypePeriode(string CodeTypePeriode);
        TYPE_PERIODE GetTypePeriodeByLibelleTypePeriodee(string LibelleTypePeriode);
        IEnumerable<TYPE_PERIODE> GetAllTypePeriodes();
        IEnumerable<TYPE_PERIODE> GetAllWithRefernces();
        Task<IEnumerable<TYPE_PERIODE>> GetAllTypePeriodesAsync();
        Task<TYPE_PERIODE> GetTypePeriodeByCodeTypePeriodeAsync(string CodeTypePeriode);
        void UpdateTypePeriode(TYPE_PERIODE TypePeriode);
        Task UpdateTypePeriodeAsync(TYPE_PERIODE TypePeriode);
        void DeleteTypePeriode(TYPE_PERIODE TypePeriode);
        Task DeleteTypePeriodeAsync(TYPE_PERIODE TypePeriode);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}