using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IListeRapportRepository
    {
        void CreateListeRapport(LISTE_RAPPORT ListeRapport);
        Task CreateListeRapportAsync(LISTE_RAPPORT ListeRapport);
        LISTE_RAPPORT GetListeRapportByIdImpression(int IdImpression);
        LISTE_RAPPORT GetListeRapportByNomRapportRapport(string NomRapport);
        IEnumerable<LISTE_RAPPORT> GetAllListeRapports();
        IEnumerable<LISTE_RAPPORT> GetAllWithRefernces();
        Task<IEnumerable<LISTE_RAPPORT>> GetAllListeRapportsAsync();
        Task<LISTE_RAPPORT> GetListeRapportByIdImpressionAsync(int IdImpression);
        void UpdateListeRapport(LISTE_RAPPORT ListeRapport);
        Task UpdateListeRapportAsync(LISTE_RAPPORT ListeRapport);
        void DeleteListeRapport(LISTE_RAPPORT ListeRapport);
        Task DeleteListeRapportAsync(LISTE_RAPPORT ListeRapport);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}