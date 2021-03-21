using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IGrilleRepository
    {
        void CreateGrille(GRILLE Grille);
        Task CreateGrilleAsync(GRILLE Grille);
        GRILLE GetGrilleByCodeGrille(string CodeGrille);
        GRILLE GetGrilleByLibelleGrille(string LibelleGrille);
        IEnumerable<GRILLE> GetAllGrilles();
        IEnumerable<GRILLE> GetAllWithRefernces();
        Task<IEnumerable<GRILLE>> GetAllGrillesAsync();
        Task<GRILLE> GetGrilleByCodeGrilleAsync(string CodeGrille);
        void UpdateGrille(GRILLE Grille);
        Task UpdateGrilleAsync(GRILLE Grille);
        void DeleteGrille(GRILLE Grille);
        Task DeleteGrilleAsync(GRILLE Grille);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}