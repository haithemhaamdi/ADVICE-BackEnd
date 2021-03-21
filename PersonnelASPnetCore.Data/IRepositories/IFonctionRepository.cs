using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IFonctionRepository
    {
        void CreateFonction(FONCTION Fonction);
        Task CreateFonctionAsync(FONCTION Fonction);
        FONCTION GetFonctionByCodeFonction(string CodeFonction);
        FONCTION GetFonctionByLibelleFonction(string LibelleFonction);
        IEnumerable<FONCTION> GetAllFonctions();
        IEnumerable<FONCTION> GetAllWithRefernces();
        Task<IEnumerable<FONCTION>> GetAllFonctionsAsync();
        Task<FONCTION> GetFonctionByCodeFonctionAsync(string CodeFonction);
        void UpdateFonction(FONCTION Fonction);
        Task UpdateFonctionAsync(FONCTION Fonction);
        void DeleteFonction(FONCTION Fonction);
        Task DeleteFonctionAsync(FONCTION Fonction);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}