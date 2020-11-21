using PersonnelASPnetCore.Data.IRepositories;
//using PersonnelASPnetCore.Data.IRepositoriesDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public interface IRepositoryWrapper
    {
        #region ADMINISTRATION
        IEmployeRepository EMPLOYERepo { get; }
        IUserRepository USERRepo { get; }
        #endregion
        #region ACTIVITE
        IActiviteRepository ACTIVITERepo { get; }
        IAppellationRepository APPELLATIONRepo { get; }
        #endregion
        #region AVANCEMENT
        IAvancementRepository AVANCEMENTRepo { get; }
        IAvancement_DetailRepository AVANCEMENT_DETAILRepo { get; }
        #endregion
        #region BANQUE
        //IBanqueRepository BANQUERepo { get; }
        IUserRepository BANQUE_VIREMENTRepo { get; }
        #endregion
        #region BAREME
        IUserRepository BAREME_IMPOTRepo { get; }
        IUserRepository BAREME_SMIGRepo { get; }
        #endregion
        #region BULLETIN_PAIE
        IBulletinPaieRepository BULLETINPAIERepo { get; }
        IUserRepository BULLETIN_PAIE_DETAILRepo { get; }
        #endregion
        #region DECLARATION
        IUserRepository DECLARATION_CNSSRepo { get; }
        IUserRepository DECLARATION_CNSS_DETAILRepo { get; }
        IUserRepository DECLARATION_CNSS_TAUX_EMPLOYEURRepo { get; }
        IUserRepository DECLARATION_EMPLOYEURRepo { get; }
        #endregion
        #region IMPOT
        IUserRepository IMP_DECLARATION_MENSUEL_IMPOTRepo { get; }
        #endregion
        #region VIREMENT
        IUserRepository VIREMENTRepo { get; }
        IUserRepository VIREMENT_DETAILRepo { get; }
        #endregion
        #region ADMINISTRATIF
        IUserRepository EMPLOYE_ABSENCERepo { get; }
        IUserRepository EMPLOYE_AFFICHAGE_GRILLERepo { get; }
        IUserRepository EMPLOYE_AJUSTEMENT_CONGERepo { get; }
        IUserRepository EMPLOYE_AVANCERepo { get; }
        IUserRepository EMPLOYE_CONGERepo { get; }
        IUserRepository EMPLOYE_CONTRATRepo { get; }
        IUserRepository EMPLOYE_CORRESPONDANCERepo { get; }
        IUserRepository EMPLOYE_DEDUCTIONRepo { get; }
        IUserRepository EMPLOYE_DISCIPLINERepo { get; }
        IUserRepository EMPLOYE_DOCUMENTRepo { get; }
        IUserRepository EMPLOYE_FORMATIONRepo { get; }
        IUserRepository EMPLOYE_OBSERVATIONRepo { get; }
        IUserRepository EMPLOYE_PRETRepo { get; }
        IUserRepository EMPLOYE_RUBRIQUERepo { get; }
        IUserRepository EMPLOYE_VENTILATIONRepo { get; }
        IUserRepository FONCTIONRepo { get; }
        IUserRepository SITUATION_CONGERepo { get; }
        IUserRepository SITUATION_CONGE_SPECIALRepo { get; }
        IUserRepository TYPE_CONTRATRepo { get; }
        IUserRepository TYPE_INDEMNITERepo { get; }
        IUserRepository TYPE_PERIODERepo { get; }
        IUserRepository TYPE_PRETRepo { get; }
        #endregion
        #region PAIEMENT
        IUserRepository MODE_PAIEMENTRepo { get; }
        IUserRepository MODELE_CORRESPONDANCERepo { get; }
        IUserRepository MODELE_PAIERepo { get; }
        IUserRepository MODELE_PAIE_DETAILRepo { get; }
        IUserRepository NATURE_PAIEMENTRepo { get; }
        IUserRepository PLAN_PAIERepo { get; }
        IUserRepository PLAN_PAIE_DETAILRepo { get; }
        #endregion
        #region COMPTABILITE
        IUserRepository PARAMETRE_COMPTABILITERepo { get; }
        IUserRepository COMPTE_COMPTABLERepo { get; }
        IUserRepository JOURNAL_COMPTABLERepo { get; }


        #endregion
        #region POINTAGE
        IUserRepository POINTAGERepo { get; }
        IUserRepository PARAMETRE_POINTAGERepo { get; }

        #endregion
        #region XXX
        IUserRepository BORDEREAURepo { get; }
        IUserRepository DECOMPTE_MONNAIERepo { get; }
        IUserRepository ECRITURERepo { get; }
        IUserRepository ECRITURE_DETAILRepo { get; }
        IUserRepository ECRITURE_OUVERTURERepo { get; }
        IUserRepository EMPLOYE_A_CHARGERepo { get; }
        IUserRepository GRILLERepo { get; }
        IUserRepository GRILLE_DETAILRepo { get; }
        IUserRepository IMP_CAVISRepo { get; }
        IUserRepository IMP_DECLARATION_ASSURANCERepo { get; }
        IUserRepository IMP_FICHE_ANNUELLE_PAIERepo { get; }
        IUserRepository RUBRIQUERepo { get; }
        IUserRepository SEQUENCERepo { get; }
        IUserRepository SITERepo { get; }
        IUserRepository TYPE_RUBRIQUERepo { get; }
        #endregion
        #region SOCIETE
        IUserRepository JOUR_FERIERepo { get; }
        IUserRepository LISTE_RAPPORTRepo { get; }
        IUserRepository DEPARTEMENTRepo { get; }

        #endregion
    }
}
