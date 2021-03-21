using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IEcritureOuvertureRepository
    {
        void CreateEcritureOuverture(ECRITURE_OUVERTURE EcritureOuverture);
        Task CreateEcritureOuvertureAsync(ECRITURE_OUVERTURE EcritureOuverture);
        ECRITURE_OUVERTURE GetEcritureOuvertureByNumeroCompteComptable(string NumeroCompteComptable);
        ECRITURE_OUVERTURE GetEcritureOuvertureByLibelleCompteComptable(string LibelleCompteComptable);
        IEnumerable<ECRITURE_OUVERTURE> GetAllEcritureOuvertures();
        IEnumerable<ECRITURE_OUVERTURE> GetAllWithRefernces();
        Task<IEnumerable<ECRITURE_OUVERTURE>> GetAllEcritureOuverturesAsync();
        Task<ECRITURE_OUVERTURE> GetEcritureOuvertureByNumeroCompteComptableAsync(string NumeroCompteComptable);
        void UpdateEcritureOuverture(ECRITURE_OUVERTURE EcritureOuverture);
        Task UpdateEcritureOuvertureAsync(ECRITURE_OUVERTURE EcritureOuverture);
        void DeleteEcritureOuverture(ECRITURE_OUVERTURE EcritureOuverture);
        Task DeleteEcritureOuvertureAsync(ECRITURE_OUVERTURE EcritureOuverture);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}