using PersonnelASPnetCore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public interface IRepositoryWrapper
    {

        #region DOSSIERS_EMPLOYES
        ITypePeriodeRepository TYPE_PERIODERepo { get; }

        IEmployeAffichageGrilleRepository EMPLOYE_AFFICHAGE_GRILLERepo { get; }

        IEmployeRepository EMPLOYERepo { get; }

        ITypeIndemniteRepository TYPE_INDEMNITERepo { get; }

        IEmployeAChargeRepository EMPLOYE_A_CHARGERepo { get; }

        IEmployeContratRepository EMPLOYE_CONTRATRepo { get; }
        ITypeContratRepository EMPLOYE_TYPE_CONTRATRepo { get; }
        IEmployeVentilationRepository EMPLOYE_VENTILATIONRepo { get; }
        IFonctionRepository FONCTIONRepo { get; }
        IAppellationRepository APPELLATIONRepo { get; }
        IEmployeDesciplineRepository EMPLOYE_DISCIPLINERepo { get; }
        IEmployeDocumentRepository EMPLOYE_DOCUMENTRepo { get; }
        IEmployeFormationRepository EMPLOYE_FORMATIONRepo { get; }
        IEmployeObservationRepository EMPLOYE_OBSERVATIONRepo { get; }
        IEmployeDeductionRepository EMPLOYE_DEDUCTIONRepo { get; }

        IEmployeRubriqueRepository EMPLOYE_RUBRIQUERepo { get; }

        #endregion

        #region POINTAGE
        IPointageRepository POINTAGERepo { get; }
        IParametrePointageRepository PARAMETRE_POINTAGERepo { get; }

        #endregion

        #region SOCIETE
        IActiviteRepository ACTIVITERepo { get; }
        IJourFerierRepository JOUR_FERIERepo { get; }
        IDepartementRepository DEPARTEMENTRepo { get; }
        ISiteRepository SITERepo { get; }


        #endregion

        #region DECLARATION
        IDeclarationCNSSRepository DECLARATION_CNSSRepo { get; }
        IDeclarationCNSSDetailRepository DECLARATION_CNSS_DETAILRepo { get; }
        IDeclarationCNSSTauxEmployeurRepository DECLARATION_CNSS_TAUX_EMPLOYEURRepo { get; }
        IDeclarationEmployeurRepository DECLARATION_EMPLOYEURRepo { get; }
        #endregion

        #region TRAVAUX DE PAIE
        #region BULLETIN_PAIE
        IBulletinPaieRepository BULLETINPAIERepo { get; }
        IBulletinPaieDetailRepository BULLETIN_PAIE_DETAILRepo { get; }
        #endregion
        #region MODELE_PAIE
        IModelePaieRepository MODELE_PAIERepo { get; }
        IModelePaieDetailRepository MODELE_PAIE_DETAILRepo { get; }
        #endregion
        #region PAIEMENT
        INaturePaiementRepository NATURE_PAIEMENTRepo { get; }
        IModePaiementRepository MODE_PAIEMENTRepo { get; }
        #endregion
        #region PLAN_PAIE
        IPlanPaieRepository PLAN_PAIERepo { get; }
        IPlanPaieDetailRepository PLAN_PAIE_DETAILRepo { get; }
        #endregion

        #endregion

        #region CORRESPONDANCE
        IModeleCorrespondanceRepository MODELE_CORRESPONDANCERepo { get; }
        #endregion

        #region MOUVEMENT
        IEmployeAbsenceRepository EMPLOYE_ABSENCERepo { get; }
        IEmployePretRepository EMPLOYE_PRETRepo { get; }
        ITypePretRepository EMPLOYE_TYPE_PRETRepo { get; }
        IEmployeAvanceRepository EMPLOYE_AVANCERepo { get; }
        IEmployeAjustementCongeRepository EMPLOYE_AJUSTEMENT_CONGERepo { get; }
        IEmployeCongeRepository EMPLOYE_CONGERepo { get; }
        ISituationCongeRepository SITUATION_CONGERepo { get; }
        ISituationCongeSpecialRepository SITUATION_CONGE_SPECIALRepo { get; }


        #endregion

        #region AVANCEMENT
        IAvancementRepository AVANCEMENTRepo { get; }
        IAvancement_DetailRepository AVANCEMENT_DETAILRepo { get; }
        #endregion

        #region BANQUE
        IBanqueRepository BANQUERepo { get; }
        IBanqueVirementRepository BANQUE_VIREMENTRepo { get; }

        IVirementRepository VIREMENTRepo { get; }
        IVirementDetailRepository VIREMENT_DETAILRepo { get; }
        #endregion

        #region CORRESPONDANCE
        IEmployeCorrespondanceRepository EMPLOYE_CORRESPONDANCERepo { get; }

        #endregion

        #region IMPOTS
        IIMPDeclarationMensuelImpotRepository IMP_DECLARATION_MENSUEL_IMPOTRepo { get; }
        IIMPCavisRepository IMP_CAVISRepo { get; }
        IIMPDeclarationAssuranceRepository IMP_DECLARATION_ASSURANCERepo { get; }
        IIMPFicheAnnuellePaieRepository IMP_FICHE_ANNUELLE_PAIERepo { get; }
        #region BAREME
        IBaremeImportRepository BAREME_IMPOTRepo { get; }
        IBaremeSMIGRepository BAREME_SMIGRepo { get; }
        #endregion
        #endregion

        #region COMPTABILITE
        IDecompteMonnaieRepository DECOMPTE_MONNAIERepo { get; }

        IParametreComptabiliteRepository PARAMETRE_COMPTABILITERepo { get; }
        ICompteComptableRepository COMPTE_COMPTABLERepo { get; }
        IJournalComptableRepository JOURNAL_COMPTABLERepo { get; }

        #region ECRITURE
        IEcritureRepository ECRITURERepo { get; }
        IEcritureDetailRepository ECRITURE_DETAILRepo { get; }
        IEcritureOuvertureRepository ECRITURE_OUVERTURERepo { get; }
        #endregion

        #endregion

        #region RAPPORT
        IListeRapportRepository LISTE_RAPPORTRepo { get; }
        ISequenceRepository SEQUENCERepo { get; }

        #endregion



        #region ADMINISTRATION
        IUserRepository USERRepo { get; }
        #endregion





        #region Grille
        IGrilleRepository GRILLERepo { get; }
        IGilleDetailRepository GRILLE_DETAILRepo { get; }
        #endregion





        IRubriqueRepository RUBRIQUERepo { get; }
        ITypeRubriqueRepository TYPE_RUBRIQUERepo { get; }



        #region FISCALITE
        IBordereauRepository BORDEREAURepo { get; }
        #endregion

        
   

        
    }
}
