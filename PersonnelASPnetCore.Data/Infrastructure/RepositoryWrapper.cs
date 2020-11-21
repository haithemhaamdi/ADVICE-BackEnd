using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.IRepositories;
//using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Data.Repositories;
using PersonnelASPnetCore.Domaine.Entities;

namespace PersonnelASPnetCore.Data.Infrastructure
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ARTIPERSONNEL_SOC001Context _repoContext;
        private IUserRepository _UserRepo;
        private IEmployeRepository _EmployeRepo;
        private IBulletinPaieRepository _Bulletin_PaieRepo;
                
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

        public IActiviteRepository ACTIVITERepo => throw new System.NotImplementedException();

        public IAppellationRepository APPELLATIONRepo => throw new System.NotImplementedException();

        public IAvancementRepository AVANCEMENTRepo => throw new System.NotImplementedException();

        public IAvancement_DetailRepository AVANCEMENT_DETAILRepo => throw new System.NotImplementedException();

        //public IBanqueRepository BANQUERepo => throw new System.NotImplementedException();

        public IUserRepository BANQUE_VIREMENTRepo => throw new System.NotImplementedException();

        public IUserRepository BAREME_IMPOTRepo => throw new System.NotImplementedException();

        public IUserRepository BAREME_SMIGRepo => throw new System.NotImplementedException();

        //public IBulletinPaieRepository BULLETIN_PAIERepo => throw new System.NotImplementedException();

        public IUserRepository BULLETIN_PAIE_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository DECLARATION_CNSSRepo => throw new System.NotImplementedException();

        public IUserRepository DECLARATION_CNSS_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository DECLARATION_CNSS_TAUX_EMPLOYEURRepo => throw new System.NotImplementedException();

        public IUserRepository DECLARATION_EMPLOYEURRepo => throw new System.NotImplementedException();

        public IUserRepository IMP_DECLARATION_MENSUEL_IMPOTRepo => throw new System.NotImplementedException();

        public IUserRepository VIREMENTRepo => throw new System.NotImplementedException();

        public IUserRepository VIREMENT_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_ABSENCERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_AFFICHAGE_GRILLERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_AJUSTEMENT_CONGERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_AVANCERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_CONGERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_CONTRATRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_CORRESPONDANCERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_DEDUCTIONRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_DISCIPLINERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_DOCUMENTRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_FORMATIONRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_OBSERVATIONRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_PRETRepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_RUBRIQUERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_VENTILATIONRepo => throw new System.NotImplementedException();

        public IUserRepository FONCTIONRepo => throw new System.NotImplementedException();

        public IUserRepository SITUATION_CONGERepo => throw new System.NotImplementedException();

        public IUserRepository SITUATION_CONGE_SPECIALRepo => throw new System.NotImplementedException();

        public IUserRepository TYPE_CONTRATRepo => throw new System.NotImplementedException();

        public IUserRepository TYPE_INDEMNITERepo => throw new System.NotImplementedException();

        public IUserRepository TYPE_PERIODERepo => throw new System.NotImplementedException();

        public IUserRepository TYPE_PRETRepo => throw new System.NotImplementedException();

        public IUserRepository MODE_PAIEMENTRepo => throw new System.NotImplementedException();

        public IUserRepository MODELE_CORRESPONDANCERepo => throw new System.NotImplementedException();

        public IUserRepository MODELE_PAIERepo => throw new System.NotImplementedException();

        public IUserRepository MODELE_PAIE_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository NATURE_PAIEMENTRepo => throw new System.NotImplementedException();

        public IUserRepository PLAN_PAIERepo => throw new System.NotImplementedException();

        public IUserRepository PLAN_PAIE_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository PARAMETRE_COMPTABILITERepo => throw new System.NotImplementedException();

        public IUserRepository COMPTE_COMPTABLERepo => throw new System.NotImplementedException();

        public IUserRepository JOURNAL_COMPTABLERepo => throw new System.NotImplementedException();

        public IUserRepository POINTAGERepo => throw new System.NotImplementedException();

        public IUserRepository PARAMETRE_POINTAGERepo => throw new System.NotImplementedException();

        public IUserRepository BORDEREAURepo => throw new System.NotImplementedException();

        public IUserRepository DECOMPTE_MONNAIERepo => throw new System.NotImplementedException();

        public IUserRepository ECRITURERepo => throw new System.NotImplementedException();

        public IUserRepository ECRITURE_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository ECRITURE_OUVERTURERepo => throw new System.NotImplementedException();

        public IUserRepository EMPLOYE_A_CHARGERepo => throw new System.NotImplementedException();

        public IUserRepository GRILLERepo => throw new System.NotImplementedException();

        public IUserRepository GRILLE_DETAILRepo => throw new System.NotImplementedException();

        public IUserRepository IMP_CAVISRepo => throw new System.NotImplementedException();

        public IUserRepository IMP_DECLARATION_ASSURANCERepo => throw new System.NotImplementedException();

        public IUserRepository IMP_FICHE_ANNUELLE_PAIERepo => throw new System.NotImplementedException();

        public IUserRepository RUBRIQUERepo => throw new System.NotImplementedException();

        public IUserRepository SEQUENCERepo => throw new System.NotImplementedException();

        public IUserRepository SITERepo => throw new System.NotImplementedException();

        public IUserRepository TYPE_RUBRIQUERepo => throw new System.NotImplementedException();

        public IUserRepository JOUR_FERIERepo => throw new System.NotImplementedException();

        public IUserRepository LISTE_RAPPORTRepo => throw new System.NotImplementedException();

        public IUserRepository DEPARTEMENTRepo => throw new System.NotImplementedException();
    }
}
