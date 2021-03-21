using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IDecompteMonnaieRepository
    {
        void CreateDecompteMonnaie(DECOMPTE_MONNAIE DecompteMonnaie);
        Task CreateDecompteMonnaieAsync(DECOMPTE_MONNAIE DecompteMonnaie);
        DECOMPTE_MONNAIE GetDecompteMonnaieByNumeroDecompteMonnaie(string NumeroDecompteMonnaie);
        DECOMPTE_MONNAIE GetDecompteMonnaieByCodeEmploye(string CodeEmploye);
        IEnumerable<DECOMPTE_MONNAIE> GetAllDecompteMonnaies();
        IEnumerable<DECOMPTE_MONNAIE> GetAllWithRefernces();
        Task<IEnumerable<DECOMPTE_MONNAIE>> GetAllDecompteMonnaiesAsync();
        Task<DECOMPTE_MONNAIE> GetDecompteMonnaieByNumeroDecompteMonnaieAsync(string NumeroDecompteMonnaie);
        void UpdateDecompteMonnaie(DECOMPTE_MONNAIE DecompteMonnaie);
        Task UpdateDecompteMonnaieAsync(DECOMPTE_MONNAIE DecompteMonnaie);
        void DeleteDecompteMonnaie(DECOMPTE_MONNAIE DecompteMonnaie);
        Task DeleteDecompteMonnaieAsync(DECOMPTE_MONNAIE DecompteMonnaie);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}