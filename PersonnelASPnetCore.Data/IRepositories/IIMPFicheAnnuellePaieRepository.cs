using PersonnelASPnetCore.Domaine.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IIMPFicheAnnuellePaieRepository
    {
        void CreateIMPFicheAnnuellePaie(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie);
        Task CreateIMPFicheAnnuellePaieAsync(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie);
        IMP_FICHE_ANNUELLE_PAIE GetIMPFicheAnnuellePaieByCodeEmploye(string CodeEmploye);
        IEnumerable<IMP_FICHE_ANNUELLE_PAIE> GetAllIMPFicheAnnuellePaies();
        IEnumerable<IMP_FICHE_ANNUELLE_PAIE> GetAllWithRefernces();
        Task<IEnumerable<IMP_FICHE_ANNUELLE_PAIE>> GetAllIMPFicheAnnuellePaiesAsync();
        Task<IMP_FICHE_ANNUELLE_PAIE> GetIMPFicheAnnuellePaieByNumeroIMPFicheAnnuellePaieAsync(string NumeroIMPFicheAnnuellePaie);
        void UpdateIMPFicheAnnuellePaie(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie);
        Task UpdateIMPFicheAnnuellePaieAsync(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie);
        void DeleteIMPFicheAnnuellePaie(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie);
        Task DeleteIMPFicheAnnuellePaieAsync(IMP_FICHE_ANNUELLE_PAIE IMPFicheAnnuellePaie);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}