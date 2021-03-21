using PersonnelASPnetCore.Data.IRepositories;
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
        IBanqueRepository BANQUERepo { get; }
        IBanqueVirementRepository BANQUE_VIREMENTRepo { get; }
        #endregion

        #region BAREME
        IBaremeImportRepository BAREME_IMPOTRepo { get; }
        IBaremeSMIGRepository BAREME_SMIGRepo { get; }
        #endregion

        #region BULLETIN_PAIE
        IBulletinPaieRepository BULLETINPAIERepo { get; }
        IBulletinPaieDetailRepository BULLETIN_PAIE_DETAILRepo { get; }
        #endregion

        #region DECLARATION
        IDeclarationCNSSRepository DECLARATION_CNSSRepo { get; }
        IDeclarationCNSSDetailRepository DECLARATION_CNSS_DETAILRepo { get; }
        IDeclarationCNSSTauxEmployeurRepository DECLARATION_CNSS_TAUX_EMPLOYEURRepo { get; }
        IDeclarationEmployeurRepository DECLARATION_EMPLOYEURRepo { get; }
        #endregion

        #region IMPOT
        IIMPDeclarationMensuelImpotRepository IMP_DECLARATION_MENSUEL_IMPOTRepo { get; }
        #endregion

        #region VIREMENT
        IVirementRepository VIREMENTRepo { get; }
        IVirementDetailRepository VIREMENT_DETAILRepo { get; }
        #endregion

        #region ADMINISTRATIF
        IEmployeAbsenceRepository EMPLOYE_ABSENCERepo { get; }
        IEmployeAffichageGrilleRepository EMPLOYE_AFFICHAGE_GRILLERepo { get; }
        IEmployeAjustementCongeRepository EMPLOYE_AJUSTEMENT_CONGERepo { get; }
        IEmployeAvanceRepository EMPLOYE_AVANCERepo { get; }
        IEmployeCongeRepository EMPLOYE_CONGERepo { get; }
        IEmployeContratRepository EMPLOYE_CONTRATRepo { get; }
        IEmployeCorrespondanceRepository EMPLOYE_CORRESPONDANCERepo { get; }
        IEmployeDeductionRepository EMPLOYE_DEDUCTIONRepo { get; }
        IEmployeDesciplineRepository EMPLOYE_DISCIPLINERepo { get; }
        IEmployeDocumentRepository EMPLOYE_DOCUMENTRepo { get; }
        IEmployeFormationRepository EMPLOYE_FORMATIONRepo { get; }
        IEmployeObservationRepository EMPLOYE_OBSERVATIONRepo { get; }
        IEmployePretRepository EMPLOYE_PRETRepo { get; }
        IEmployeRubriqueRepository EMPLOYE_RUBRIQUERepo { get; }
        IEmployeVentilationRepository EMPLOYE_VENTILATIONRepo { get; }
        IFonctionRepository FONCTIONRepo { get; }
        ISituationCongeRepository SITUATION_CONGERepo { get; }
        ISituationCongeSpecialRepository SITUATION_CONGE_SPECIALRepo { get; }
        ITypeContratRepository EMPLOYE_TYPE_CONTRATRepo { get; }
        ITypeIndemniteRepository TYPE_INDEMNITERepo { get; }
        ITypePeriodeRepository EMPLOYE_TYPE_PERIODERepo { get; }
        ITypePretRepository EMPLOYE_TYPE_PRETRepo { get; }
        #endregion

        #region PAIEMENT - PAIE - PLAN_PAIE
        IModePaiementRepository MODE_PAIEMENTRepo { get; }
        IModeleCorrespondanceRepository MODELE_CORRESPONDANCERepo { get; }
        IModelePaieRepository MODELE_PAIERepo { get; }
        IModelePaieDetailRepository MODELE_PAIE_DETAILRepo { get; }
        INaturePaiementRepository NATURE_PAIEMENTRepo { get; }
        IPlanPaieRepository PLAN_PAIERepo { get; }
        IPlanPaieDetailRepository PLAN_PAIE_DETAILRepo { get; }
        #endregion

        #region COMPTABILITE
        IParametreComptabiliteRepository PARAMETRE_COMPTABILITERepo { get; }
        ICompteComptableRepository COMPTE_COMPTABLERepo { get; }
        IJournalComptableRepository JOURNAL_COMPTABLERepo { get; }
        #endregion

        #region POINTAGE
        IPointageRepository POINTAGERepo { get; }
        IParametrePointageRepository PARAMETRE_POINTAGERepo { get; }

        #endregion

        #region XXX
        IBordereauRepository BORDEREAURepo { get; }
        IDecompteMonnaieRepository DECOMPTE_MONNAIERepo { get; }
        IEcritureRepository ECRITURERepo { get; }
        IEcritureDetailRepository ECRITURE_DETAILRepo { get; }
        IEcritureOuvertureRepository ECRITURE_OUVERTURERepo { get; }
        IEmployeAChargeRepository EMPLOYE_A_CHARGERepo { get; }

        #region Grille
        IGrilleRepository GRILLERepo { get; }
        IGilleDetailRepository GRILLE_DETAILRepo { get; }
        #endregion

        #region IMP
        IIMPCavisRepository IMP_CAVISRepo { get; }
        IIMPDeclarationAssuranceRepository IMP_DECLARATION_ASSURANCERepo { get; }
        IIMPFicheAnnuellePaieRepository IMP_FICHE_ANNUELLE_PAIERepo { get; }
        #endregion

        IRubriqueRepository RUBRIQUERepo { get; }
        ISequenceRepository SEQUENCERepo { get; }
        ISiteRepository SITERepo { get; }
        ITypeRubriqueRepository TYPE_RUBRIQUERepo { get; }
        #endregion

        #region SOCIETE
        IJourFerierRepository JOUR_FERIERepo { get; }
        IListeRapportRepository LISTE_RAPPORTRepo { get; }
        IDepartementRepository DEPARTEMENTRepo { get; }

        #endregion
    }
}
