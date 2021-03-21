using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface ICompteComptableRepository
    {

        void CreateCompteComptable(COMPTE_COMPTABLE CompteComptable);
        Task CreateCompteComptableAsync(COMPTE_COMPTABLE CompteComptable);
        COMPTE_COMPTABLE GetCompteComptableByNumero(string NumeroCompteComptable);
        Task<COMPTE_COMPTABLE> GetCompteComptableByNumeroAsync(string NumeroCompteComptable);
        COMPTE_COMPTABLE GetCompteComptableByLibelle(string LibelleCompteComptable);
        Task<COMPTE_COMPTABLE> GetCompteComptableByLibelleAsync(string LibelleCompteComptable);
        IEnumerable<COMPTE_COMPTABLE> GetAllCompteComptable();
        Task<IEnumerable<COMPTE_COMPTABLE>> GetAllCompteComptableAsync();
        void UpdateCompteComptable(COMPTE_COMPTABLE CompteComptable);
        Task UpdateCompteComptableAsync(COMPTE_COMPTABLE CompteComptable);
        void DeleteCompteComptable(COMPTE_COMPTABLE CompteComptable);
        Task DeleteCompteComptableAsync(COMPTE_COMPTABLE CompteComptable);
        Task DeleteCompteComptableAsync(string NumeroCompteComptable);

        //Task SaveAsync();
        //void Save();
        //void Commit();
        //Task CommitAsync();
        //void Dispose();
    }
}
