using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IParametreComptabiliteRepository
    {
        void CreateParametreComptabilite(PARAMETRE_COMPTABILITE ParametreComptabilite);
        Task CreateParametreComptabiliteAsync(PARAMETRE_COMPTABILITE ParametreComptabilite);
        PARAMETRE_COMPTABILITE GetParametreComptabiliteByCodeParametre(string CodeParametre);
        PARAMETRE_COMPTABILITE GetParametreComptabiliteByGroupe(string Groupe);
        IEnumerable<PARAMETRE_COMPTABILITE> GetAllParametreComptabilites();
        IEnumerable<PARAMETRE_COMPTABILITE> GetAllWithRefernces();
        Task<IEnumerable<PARAMETRE_COMPTABILITE>> GetAllParametreComptabilitesAsync();
        Task<PARAMETRE_COMPTABILITE> GetParametreComptabiliteByCodeParametreAsync(string CodeParametre);
        void UpdateParametreComptabilite(PARAMETRE_COMPTABILITE ParametreComptabilite);
        Task UpdateParametreComptabiliteAsync(PARAMETRE_COMPTABILITE ParametreComptabilite);
        void DeleteParametreComptabilite(PARAMETRE_COMPTABILITE ParametreComptabilite);
        Task DeleteParametreComptabiliteAsync(PARAMETRE_COMPTABILITE ParametreComptabilite);
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
