using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.IRepositories;
using PersonnelASPnetCore.Data.Repositories;
using PersonnelASPnetCore.Domaine.Entities;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ARTIPERSONNEL_SOC001Context _repoContext;

        private IUserRepository _UserRepo;
        private IBulletinPaieRepository _Bulletin_PaieRepo;
        private IActiviteRepository _ActiviteRepo;
        private IAppellationRepository _AppellationRepo;
        private IAvancementRepository _AvancementRepo;
        private IAvancement_DetailRepository _Avancement_DetailRepo;
        private IBanqueVirementRepository _BanqueVirementRepo;
        private IBanqueRepository _BanqueRepo;
        private IBaremeImportRepository _BaremeImportRepo;
        private IBaremeSMIGRepository _BaremeSMIGRepo;
        private IBulletinPaieDetailRepository _BulletinPaieDetailRepo;
        private IDeclarationCNSSRepository _DeclarationCNSSRepo;
        private IDeclarationCNSSDetailRepository _DeclarationCNSSDetailRepo;
        private IDeclarationCNSSTauxEmployeurRepository _DeclarationCNSSTauxEmployeurRepo;
        private IDeclarationEmployeurRepository _DeclarationEmployeurRepo;
        private IIMPDeclarationMensuelImpotRepository _IMPDeclarationMensuelImpotRepo;
        private IVirementRepository _VirementRepo;
        private IVirementDetailRepository _VirementDetailRepo;
        private IEmployeRepository _EmployeRepo;
        private IEmployeAbsenceRepository _EmployeAbsenceRepo;
        private IEmployeAffichageGrilleRepository _EmployeAffichageGrilleRepo;
        private IEmployeAjustementCongeRepository _EmployeAjustementCongeRepo;
        private IEmployeAvanceRepository _EmployeAvanceRepo;
        private IEmployeCongeRepository _EmployeCongeRepo;
        private IEmployeContratRepository _EmployeContratRepo;
        private IEmployeCorrespondanceRepository _EmployeCorrespondanceRepo;
        private IEmployeDeductionRepository _EmployeDeductionRepo;
        private IEmployeDesciplineRepository _EmployeDesciplineRepo;
        private IEmployeDocumentRepository _EmployeDocumentRepo;
        private IEmployeFormationRepository _EmployeFormationRepo;
        private IEmployeObservationRepository _EmployeObservationRepo;
        private IEmployePretRepository _EmployePretRepo;
        private IEmployeRubriqueRepository _EmployeRubriqueRepo;
        private IEmployeVentilationRepository _EmployeVentilationRepo;
        private IFonctionRepository _FonctionRepo;
        private ISituationCongeRepository _SituationCongeRepo;
        private ISituationCongeSpecialRepository _SituationCongeSpecialRepo;
        private ITypeContratRepository _TypeContratRepo;
        private ITypeIndemniteRepository _TypeIndemniteRepo;
        private ITypePeriodeRepository _TypePeriodeRepo;
        private ITypePretRepository _TypePretRepo;
        private IEmployeAChargeRepository _EmployeAChargeRepo;
        private IModePaiementRepository _ModePaiementRepo;
        private IModeleCorrespondanceRepository _ModeleCorrespondanceRepo;
        private IModelePaieRepository _ModelePaieRepo;
        private IModelePaieDetailRepository _ModelePaieDetailRepo;
        private INaturePaiementRepository _NaturePaiementRepo;
        private IPlanPaieRepository _PlanPaieRepo;
        private IPlanPaieDetailRepository _PlanPaieDetailRepo;
        private IParametreComptabiliteRepository _ParametreComptabiliteRepo;
        private ICompteComptableRepository _CompteComptableRepo;
        private IJournalComptableRepository _JournalComptableRepo;
        private IPointageRepository _PointageRepoRepo;
        private IParametrePointageRepository _ParametrePointageRepo;
        private IBordereauRepository _BordereauRepo;
        private IDecompteMonnaieRepository _DecompteMonnaieRepo;
        private IEcritureRepository _EcritureRepo;
        private IEcritureDetailRepository _EcritureDetailRepo;
        private IEcritureOuvertureRepository _EcritureOuvertureRepo;
        private IGrilleRepository _GrilleRepo;
        private IGilleDetailRepository _GilleDetailRepo;
        private IIMPCavisRepository _IMPCavisRepo;
        private IIMPDeclarationAssuranceRepository _IMPDeclarationAssuranceRepo;
        private IIMPFicheAnnuellePaieRepository _IMPFicheAnnuellePaieRepo;
        private IRubriqueRepository _RubriqueRepo;
        private ISequenceRepository _SequenceRepo;
        private ISiteRepository _SiteRepo;
        private ITypeRubriqueRepository _TypeRubriqueRepo;
        private IJourFerierRepository _JourFerierRepo;
        private IListeRapportRepository _ListeRapportRepo;
        private IDepartementRepository _DepartementRepo;
        private IConfiguration _Configuration;

        public RepositoryWrapper(ARTIPERSONNEL_SOC001Context repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public IEmployeRepository EMPLOYERepo
        {
            get
            {
                if (_EmployeRepo == null)
                {
                    _EmployeRepo = new EmployeRepository(_repoContext, _Configuration);
                }

                return _EmployeRepo;
            }
        }

        public IUserRepository USERRepo
        {
            get
            {
                if (_UserRepo == null)
                {
                    _UserRepo = new UserRepository(_repoContext, _Configuration);
                }

                return _UserRepo;
            }
        }

        public IBulletinPaieRepository BULLETINPAIERepo
        {
            get
            {
                if (_Bulletin_PaieRepo == null)
                {
                    _Bulletin_PaieRepo = new BulletinPaieRepository(_repoContext, _Configuration);
                }

                return _Bulletin_PaieRepo;
            }
        }

        public IFonctionRepository FONCTIONRepo
        {
            get
            {
                if (_FonctionRepo == null)
                {
                    _FonctionRepo = new FonctionRepository(_repoContext, _Configuration);
                }

                return _FonctionRepo;
            }
        }

        public ISituationCongeRepository SITUATION_CONGERepo
        {
            get
            {
                if (_SituationCongeRepo == null)
                {
                    _SituationCongeRepo = new SituationCongeRepository(_repoContext, _Configuration);
                }

                return _SituationCongeRepo;
            }
        }

        public ISituationCongeSpecialRepository SITUATION_CONGE_SPECIALRepo
        {
            get
            {
                if (_SituationCongeSpecialRepo == null)
                {
                    _SituationCongeSpecialRepo = new SituationCongeSpecialRepository(_repoContext, _Configuration);
                }

                return _SituationCongeSpecialRepo;
            }
        }

        public ITypeContratRepository EMPLOYE_TYPE_CONTRATRepo
        {
            get
            {
                if (_TypeContratRepo == null)
                {
                    _TypeContratRepo = new TypeContratRepository(_repoContext, _Configuration);
                }

                return _TypeContratRepo;
            }
        }

        public ITypeIndemniteRepository TYPE_INDEMNITERepo
        {
            get
            {
                if (_TypeIndemniteRepo == null)
                {
                    _TypeIndemniteRepo = new TypeIndemniteRepository(_repoContext, _Configuration);
                }

                return _TypeIndemniteRepo;
            }
        }

        public ITypePeriodeRepository TYPE_PERIODERepo
        {
            get
            {
                if (_TypePeriodeRepo == null)
                {
                    _TypePeriodeRepo = new TypePeriodeRepository(_repoContext, _Configuration);
                }

                return _TypePeriodeRepo;
            }
        }

        public ITypePretRepository EMPLOYE_TYPE_PRETRepo
        {
            get
            {
                if (_TypePretRepo == null)
                {
                    _TypePretRepo = new TypePretRepository(_repoContext, _Configuration);
                }

                return _TypePretRepo;
            }
        }

        public IBanqueRepository BANQUERepo
        {
            get
            {
                if (_BanqueRepo == null)
                {
                    _BanqueRepo = new BanqueRepository(_repoContext, _Configuration);
                }

                return _BanqueRepo;
            }
        }

        public IBanqueVirementRepository BANQUE_VIREMENTRepo
        {
            get
            {
                if (_BanqueVirementRepo == null)
                {
                    _BanqueVirementRepo = new BanqueVirementRepository(_repoContext, _Configuration);
                }

                return _BanqueVirementRepo;
            }
        }

        public IActiviteRepository ACTIVITERepo
        {
            get
            {
                if (_ActiviteRepo == null)
                {
                    _ActiviteRepo = new ActiviteRepository(_repoContext, _Configuration);
                }

                return _ActiviteRepo;
            }
        }

        public IAppellationRepository APPELLATIONRepo
        {
            get
            {
                if (_AppellationRepo == null)
                {
                    _AppellationRepo = new AppellationRepository(_repoContext, _Configuration);
                }

                return _AppellationRepo;
            }
        }

        public IAvancementRepository AVANCEMENTRepo
        {
            get
            {
                if (_AvancementRepo == null)
                {
                    _AvancementRepo = new AvancementRepository(_repoContext, _Configuration);
                }

                return _AvancementRepo;
            }
        }

        public IAvancement_DetailRepository AVANCEMENT_DETAILRepo
        {
            get
            {
                if (_Avancement_DetailRepo == null)
                {
                    _Avancement_DetailRepo = new Avancement_DetailRepository(_repoContext, _Configuration);
                }

                return _Avancement_DetailRepo;
            }
        }

        public IBaremeImportRepository BAREME_IMPOTRepo
        {
            get
            {
                if (_BaremeImportRepo == null)
                {
                    _BaremeImportRepo = new BaremeImportRepository(_repoContext, _Configuration);
                }

                return _BaremeImportRepo;
            }
        }

        public IBaremeSMIGRepository BAREME_SMIGRepo
        {
            get
            {
                if (_BaremeSMIGRepo == null)
                {
                    _BaremeSMIGRepo = new BaremeSMIGRepository(_repoContext, _Configuration);
                }

                return _BaremeSMIGRepo;
            }
        }

        public IBulletinPaieDetailRepository BULLETIN_PAIE_DETAILRepo
        {
            get
            {
                if (_BulletinPaieDetailRepo == null)
                {
                    _BulletinPaieDetailRepo = new BulletinPaieDetailRepository(_repoContext, _Configuration);
                }

                return _BulletinPaieDetailRepo;
            }
        }

        public IDeclarationCNSSRepository DECLARATION_CNSSRepo
        {
            get
            {
                if (_DeclarationCNSSRepo == null)
                {
                    _DeclarationCNSSRepo = new DeclarationCNSSRepository(_repoContext, _Configuration);
                }

                return _DeclarationCNSSRepo;
            }
        }

        public IDeclarationCNSSDetailRepository DECLARATION_CNSS_DETAILRepo
        {
            get
            {
                if (_DeclarationCNSSDetailRepo == null)
                {
                    _DeclarationCNSSDetailRepo = new DeclarationCNSSDetailRepository(_repoContext, _Configuration);
                }

                return _DeclarationCNSSDetailRepo;
            }
        }

        public IDeclarationCNSSTauxEmployeurRepository DECLARATION_CNSS_TAUX_EMPLOYEURRepo
        {
            get
            {
                if (_DeclarationCNSSTauxEmployeurRepo == null)
                {
                    _DeclarationCNSSTauxEmployeurRepo = new DeclarationCNSSTauxEmployeurRepository(_repoContext, _Configuration);
                }

                return _DeclarationCNSSTauxEmployeurRepo;
            }
        }

        public IDeclarationEmployeurRepository DECLARATION_EMPLOYEURRepo
        {
            get
            {
                if (_DeclarationEmployeurRepo == null)
                {
                    _DeclarationEmployeurRepo = new DeclarationEmployeurRepository(_repoContext, _Configuration);
                }

                return _DeclarationEmployeurRepo;
            }
        }

        public IIMPDeclarationMensuelImpotRepository IMP_DECLARATION_MENSUEL_IMPOTRepo
        {
            get
            {
                if (_IMPDeclarationMensuelImpotRepo == null)
                {
                    _IMPDeclarationMensuelImpotRepo = new IMPDeclarationMensuelImpotRepository(_repoContext, _Configuration);
                }

                return _IMPDeclarationMensuelImpotRepo;
            }
        }

        public IVirementRepository VIREMENTRepo
        {
            get
            {
                if (_VirementRepo == null)
                {
                    _VirementRepo = new VirementRepository(_repoContext, _Configuration);
                }

                return _VirementRepo;
            }
        }

        public IVirementDetailRepository VIREMENT_DETAILRepo
        {
            get
            {
                if (_VirementDetailRepo == null)
                {
                    _VirementDetailRepo = new VirementDetailRepository(_repoContext, _Configuration);
                }

                return _VirementDetailRepo;
            }
        }

        public IEmployeAbsenceRepository EMPLOYE_ABSENCERepo
        {
            get
            {
                if (_EmployeAbsenceRepo == null)
                {
                    _EmployeAbsenceRepo = new EmployeAbsenceRepository(_repoContext, _Configuration);
                }

                return _EmployeAbsenceRepo;
            }
        }

        public IEmployeAffichageGrilleRepository EMPLOYE_AFFICHAGE_GRILLERepo
        {
            get
            {
                if (_EmployeAffichageGrilleRepo == null)
                {
                    _EmployeAffichageGrilleRepo = new EmployeAffichageGrilleRepository(_repoContext, _Configuration);
                }

                return _EmployeAffichageGrilleRepo;
            }
        }

        public IEmployeAjustementCongeRepository EMPLOYE_AJUSTEMENT_CONGERepo
        {
            get
            {
                if (_EmployeAjustementCongeRepo == null)
                {
                    _EmployeAjustementCongeRepo = new EmployeAjustementCongeRepository(_repoContext, _Configuration);
                }

                return _EmployeAjustementCongeRepo;
            }
        }

        public IEmployeAvanceRepository EMPLOYE_AVANCERepo
        {
            get
            {
                if (_EmployeAvanceRepo == null)
                {
                    _EmployeAvanceRepo = new EmployeAvanceRepository(_repoContext, _Configuration);
                }

                return _EmployeAvanceRepo;
            }
        }

        public IEmployeCongeRepository EMPLOYE_CONGERepo
        {
            get
            {
                if (_EmployeCongeRepo == null)
                {
                    _EmployeCongeRepo = new EmployeCongeRepository(_repoContext, _Configuration);
                }

                return _EmployeCongeRepo;
            }
        }

        public IEmployeContratRepository EMPLOYE_CONTRATRepo
        {
            get
            {
                if (_EmployeContratRepo == null)
                {
                    _EmployeContratRepo = new EmployeContratRepository(_repoContext, _Configuration);
                }

                return _EmployeContratRepo;
            }
        }

        public IEmployeCorrespondanceRepository EMPLOYE_CORRESPONDANCERepo
        {
            get
            {
                if (_EmployeCorrespondanceRepo == null)
                {
                    _EmployeCorrespondanceRepo = new EmployeCorrespondanceRepository(_repoContext, _Configuration);
                }

                return _EmployeCorrespondanceRepo;
            }
        }

        public IEmployeDeductionRepository EMPLOYE_DEDUCTIONRepo
        {
            get
            {
                if (_EmployeDeductionRepo == null)
                {
                    _EmployeDeductionRepo = new EmployeDeductionRepository(_repoContext, _Configuration);
                }

                return _EmployeDeductionRepo;
            }
        }

        public IEmployeDesciplineRepository EMPLOYE_DISCIPLINERepo
        {
            get
            {
                if (_EmployeDesciplineRepo == null)
                {
                    _EmployeDesciplineRepo = new EmployeDesciplineRepository(_repoContext, _Configuration);
                }

                return _EmployeDesciplineRepo;
            }
        }

        public IEmployeDocumentRepository EMPLOYE_DOCUMENTRepo
        {
            get
            {
                if (_EmployeDocumentRepo == null)
                {
                    _EmployeDocumentRepo = new EmployeDocumentRepository(_repoContext, _Configuration);
                }

                return _EmployeDocumentRepo;
            }
        }

        public IEmployeFormationRepository EMPLOYE_FORMATIONRepo
        {
            get
            {
                if (_EmployeFormationRepo == null)
                {
                    _EmployeFormationRepo = new EmployeFormationRepository(_repoContext, _Configuration);
                }

                return _EmployeFormationRepo;
            }
        }

        public IEmployeObservationRepository EMPLOYE_OBSERVATIONRepo
        {
            get
            {
                if (_EmployeObservationRepo == null)
                {
                    _EmployeObservationRepo = new EmployeObservationRepository(_repoContext, _Configuration);
                }

                return _EmployeObservationRepo;
            }
        }

        public IEmployePretRepository EMPLOYE_PRETRepo
        {
            get
            {
                if (_EmployePretRepo == null)
                {
                    _EmployePretRepo = new EmployePretRepository(_repoContext, _Configuration);
                }

                return _EmployePretRepo;
            }
        }

        public IEmployeRubriqueRepository EMPLOYE_RUBRIQUERepo
        {
            get
            {
                if (_EmployeRubriqueRepo == null)
                {
                    _EmployeRubriqueRepo = new EmployeRubriqueRepository(_repoContext, _Configuration);
                }

                return _EmployeRubriqueRepo;
            }
        }

        public IEmployeVentilationRepository EMPLOYE_VENTILATIONRepo
        {
            get
            {
                if (_EmployeVentilationRepo == null)
                {
                    _EmployeVentilationRepo = new EmployeVentilationRepository(_repoContext, _Configuration);
                }

                return _EmployeVentilationRepo;
            }
        }

        public IModePaiementRepository MODE_PAIEMENTRepo
        {
            get
            {
                if (_ModePaiementRepo == null)
                {
                    _ModePaiementRepo = new ModePaiementRepository(_repoContext, _Configuration);
                }

                return _ModePaiementRepo;
            }
        }

        public IModeleCorrespondanceRepository MODELE_CORRESPONDANCERepo
        {
            get
            {
                if (_ModeleCorrespondanceRepo == null)
                {
                    _ModeleCorrespondanceRepo = new ModeleCorrespondanceRepository(_repoContext, _Configuration);
                }

                return _ModeleCorrespondanceRepo;
            }
        }

        public IModelePaieRepository MODELE_PAIERepo
        {
            get
            {
                if (_ModelePaieRepo == null)
                {
                    _ModelePaieRepo = new ModelePaieRepository(_repoContext, _Configuration);
                }

                return _ModelePaieRepo;
            }
        }

        public IModelePaieDetailRepository MODELE_PAIE_DETAILRepo
        {
            get
            {
                if (_ModelePaieDetailRepo == null)
                {
                    _ModelePaieDetailRepo = new ModelePaieDetailRepository(_repoContext, _Configuration);
                }

                return _ModelePaieDetailRepo;
            }
        }

        public INaturePaiementRepository NATURE_PAIEMENTRepo
        {
            get
            {
                if (_NaturePaiementRepo == null)
                {
                    _NaturePaiementRepo = new NaturePaiementRepository(_repoContext, _Configuration);
                }

                return _NaturePaiementRepo;
            }
        }

        public IPlanPaieRepository PLAN_PAIERepo
        {
            get
            {
                if (_PlanPaieRepo == null)
                {
                    _PlanPaieRepo = new PlanPaieRepository(_repoContext, _Configuration);
                }

                return _PlanPaieRepo;
            }
        }

        public IPlanPaieDetailRepository PLAN_PAIE_DETAILRepo
        {
            get
            {
                if (_PlanPaieDetailRepo == null)
                {
                    _PlanPaieDetailRepo = new PlanPaieDetailRepository(_repoContext, _Configuration);
                }

                return _PlanPaieDetailRepo;
            }
        }

        public IParametreComptabiliteRepository PARAMETRE_COMPTABILITERepo
        {
            get
            {
                if (_ParametreComptabiliteRepo == null)
                {
                    _ParametreComptabiliteRepo = new ParametreComptabiliteRepository(_repoContext, _Configuration);
                }

                return _ParametreComptabiliteRepo;
            }
        }

        public ICompteComptableRepository COMPTE_COMPTABLERepo
        {
            get
            {
                if (_CompteComptableRepo == null)
                {
                    _CompteComptableRepo = new CompteComptableRepository(_repoContext, _Configuration);
                }

                return _CompteComptableRepo;
            }
        }

        public IJournalComptableRepository JOURNAL_COMPTABLERepo
        {
            get
            {
                if (_JournalComptableRepo == null)
                {
                    _JournalComptableRepo = new JournalComptableRepository(_repoContext, _Configuration);
                }

                return _JournalComptableRepo;
            }
        }

        public IPointageRepository POINTAGERepo
        {
            get
            {
                if (_PointageRepoRepo == null)
                {
                    _PointageRepoRepo = new PointageRepository(_repoContext, _Configuration);
                }

                return _PointageRepoRepo;
            }
        }

        public IParametrePointageRepository PARAMETRE_POINTAGERepo
        {
            get
            {
                if (_ParametrePointageRepo == null)
                {
                    _ParametrePointageRepo = new ParametrePointageRepository(_repoContext, _Configuration);
                }

                return _ParametrePointageRepo;
            }
        }

        public IBordereauRepository BORDEREAURepo
        {
            get
            {
                if (_BordereauRepo == null)
                {
                    _BordereauRepo = new BordereauRepository(_repoContext, _Configuration);
                }

                return _BordereauRepo;
            }
        }

        public IDecompteMonnaieRepository DECOMPTE_MONNAIERepo
        {
            get
            {
                if (_DecompteMonnaieRepo == null)
                {
                    _DecompteMonnaieRepo = new DecompteMonnaieRepository(_repoContext, _Configuration);
                }

                return _DecompteMonnaieRepo;
            }
        }

        public IEcritureRepository ECRITURERepo
        {
            get
            {
                if (_EcritureRepo == null)
                {
                    _EcritureRepo = new EcritureRepository(_repoContext, _Configuration);
                }

                return _EcritureRepo;
            }
        }

        public IEcritureDetailRepository ECRITURE_DETAILRepo
        {
            get
            {
                if (_EcritureDetailRepo == null)
                {
                    _EcritureDetailRepo = new EcritureDetailRepository(_repoContext, _Configuration);
                }

                return _EcritureDetailRepo;
            }
        }

        public IEcritureOuvertureRepository ECRITURE_OUVERTURERepo
        {
            get
            {
                if (_EcritureOuvertureRepo == null)
                {
                    _EcritureOuvertureRepo = new EcritureOuvertureRepository(_repoContext, _Configuration);
                }

                return _EcritureOuvertureRepo;
            }
        }

        public IEmployeAChargeRepository EMPLOYE_A_CHARGERepo
        {
            get
            {
                if (_EmployeAChargeRepo == null)
                {
                    _EmployeAChargeRepo = new EmployeAChargeRepository(_repoContext, _Configuration);
                }

                return _EmployeAChargeRepo;
            }
        }

        public IGrilleRepository GRILLERepo
        {
            get
            {
                if (_GrilleRepo == null)
                {
                    _GrilleRepo = new GrilleRepository(_repoContext, _Configuration);
                }

                return _GrilleRepo;
            }
        }

        public IGilleDetailRepository GRILLE_DETAILRepo
        {
            get
            {
                if (_GilleDetailRepo == null)
                {
                    _GilleDetailRepo = new GilleDetailRepository(_repoContext, _Configuration);
                }

                return _GilleDetailRepo;
            }
        }

        public IIMPCavisRepository IMP_CAVISRepo
        {
            get
            {
                if (_IMPCavisRepo == null)
                {
                    _IMPCavisRepo = new IMPCavisRepository(_repoContext, _Configuration);
                }

                return _IMPCavisRepo;
            }
        }

        public IIMPDeclarationAssuranceRepository IMP_DECLARATION_ASSURANCERepo
        {
            get
            {
                if (_IMPDeclarationAssuranceRepo == null)
                {
                    _IMPDeclarationAssuranceRepo = new IMPDeclarationAssuranceRepository(_repoContext, _Configuration);
                }

                return _IMPDeclarationAssuranceRepo;
            }
        }

        public IIMPFicheAnnuellePaieRepository IMP_FICHE_ANNUELLE_PAIERepo
        {
            get
            {
                if (_IMPFicheAnnuellePaieRepo == null)
                {
                    _IMPFicheAnnuellePaieRepo = new IMPFicheAnnuellePaieRepository(_repoContext, _Configuration);
                }

                return _IMPFicheAnnuellePaieRepo;
            }
        }

        public IRubriqueRepository RUBRIQUERepo
        {
            get
            {
                if (_RubriqueRepo == null)
                {
                    _RubriqueRepo = new RubriqueRepository(_repoContext, _Configuration);
                }

                return _RubriqueRepo;
            }
        }

        public ISequenceRepository SEQUENCERepo
        {
            get
            {
                if (_SequenceRepo == null)
                {
                    _SequenceRepo = new SequenceRepository(_repoContext, _Configuration);
                }

                return _SequenceRepo;
            }
        }

        public ISiteRepository SITERepo
        {
            get
            {
                if (_SiteRepo == null)
                {
                    _SiteRepo = new SiteRepository(_repoContext, _Configuration);
                }

                return _SiteRepo;
            }
        }

        public ITypeRubriqueRepository TYPE_RUBRIQUERepo
        {
            get
            {
                if (_TypeRubriqueRepo == null)
                {
                    _TypeRubriqueRepo = new TypeRubriqueRepository(_repoContext, _Configuration);
                }

                return _TypeRubriqueRepo;
            }
        }

        public IJourFerierRepository JOUR_FERIERepo
        {
            get
            {
                if (_JourFerierRepo == null)
                {
                    _JourFerierRepo = new JourFerierRepository(_repoContext, _Configuration);
                }

                return _JourFerierRepo;
            }
        }

        public IListeRapportRepository LISTE_RAPPORTRepo
        {
            get
            {
                if (_ListeRapportRepo == null)
                {
                    _ListeRapportRepo = new ListeRapportRepository(_repoContext, _Configuration);
                }

                return _ListeRapportRepo;
            }
        }

        public IDepartementRepository DEPARTEMENTRepo
        {
            get
            {
                if (_DepartementRepo == null)
                {
                    _DepartementRepo = new DepartementRepository(_repoContext, _Configuration);
                }

                return _DepartementRepo;
            }
        }

    }
}
