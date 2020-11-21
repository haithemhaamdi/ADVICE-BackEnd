using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IBulletinPaieRepository
    {
        void CreateBulletinPaie(BULLETIN_PAIE bulletinPaie);
        Task CreateBulletinPaieAsync(BULLETIN_PAIE bulletinPaie);
        BULLETIN_PAIE GetBulletinPaieByID(string NumeroBulletin);
        BULLETIN_PAIE GetBulletinPaieByName(string NumeroBulletin);
        IEnumerable<BULLETIN_PAIE> GetAllBulletinsPaie();
        // Chargement hâtif
        IEnumerable<BULLETIN_PAIE> GetAllWithRefernces();
        Task<IEnumerable<BULLETIN_PAIE>> GetAllBulletinPaiesAsync();
        Task<BULLETIN_PAIE> GetBulletinPaieByIDAsync(string NumeroBulletin);
        void UpdateBulletinPaie(BULLETIN_PAIE bulletinPaie);
        Task UpdateBulletinPaieAsync(BULLETIN_PAIE bulletinPaie);
        void DeleteBulletinPaie(BULLETIN_PAIE bulletinPaie);
        Task DeleteBulletinPaieAsync(BULLETIN_PAIE bulletinPaie);
        Task SaveAsync();
        void Save();
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
