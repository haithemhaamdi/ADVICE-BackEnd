using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Service.ServiceManagmentInterface
{
    public interface ICOMPTE_COMPTABLEService
    {
        bool CreateCompteComptable(COMPTE_COMPTABLE CompteComptable);
        COMPTE_COMPTABLE GetCompteComptableByNumeroCompte(string numeroCompte);
        COMPTE_COMPTABLE GetUserByLibelleCompte(string LibelleCompte);
        //Task<IEnumerable<COMPTE_COMPTABLE>> GetAllCompteComptable();
        IEnumerable<COMPTE_COMPTABLE> GetAllCompteComptable();
        //IEnumerable<COMPTE_COMPTABLE> GetAll();
        bool UpdateCompteComptable(COMPTE_COMPTABLE CompteComptable);
        void DeleteCompteComptable(string numeroCompte);
        void Delete(COMPTE_COMPTABLE CompteComptable);
        void Commit();
        void CommitAsync();
        void Dispose();
    }
}
