using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class Bulletin_PaieRepository : RepositoryBase<BULLETIN_PAIE>, IBulletin_PaieRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        /// <summary>
        /// Utilisé pour générer des paramètres de configuration basés sur des clés/valeurs 
        /// à utiliser dans une application.
        /// </summary>
        IConfiguration _ConnectionString;

        public Bulletin_PaieRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
            : base(repositoryContext)
        {
            _ConnectionString = configuration;
        }
        #endregion

        public async Task CreateBulletinPaiePSAsync(BULLETIN_PAIE BulletinPaie)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CREATE_BULLETIN_PAIE", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ArrondissementNegatif", BulletinPaie.ArrondissementNegatif);
                cmd.Parameters.AddWithValue("@ArrondissementPositif", BulletinPaie.ArrondissementPositif);
                cmd.Parameters.AddWithValue("@AssuranceGroupe", BulletinPaie.AssuranceGroupe);
                cmd.Parameters.AddWithValue("@Cavis", BulletinPaie.Cavis);
                cmd.Parameters.AddWithValue("@ChefFamille", BulletinPaie.ChefFamille);
                cmd.Parameters.AddWithValue("@Cin", BulletinPaie.CIN);
                cmd.Parameters.AddWithValue("@CodeBanque", BulletinPaie.CodeBanque);
                cmd.Parameters.AddWithValue("@CodeDepartement", BulletinPaie.CodeDepartement);
                cmd.Parameters.AddWithValue("@CodeFonction", BulletinPaie.CodeFonction);
                cmd.Parameters.AddWithValue("@CodeGrille", BulletinPaie.CodeGrille);
                cmd.Parameters.AddWithValue("@CodeModele", BulletinPaie.CodeModele);
                cmd.Parameters.AddWithValue("@CodeModePaiement", BulletinPaie.CodeModePaiement);
                cmd.Parameters.AddWithValue("@CodeOperateur", BulletinPaie.CodeOperateur);
                cmd.Parameters.AddWithValue("@CodePeriode", BulletinPaie.CodePeriode);
                cmd.Parameters.AddWithValue("@CodePlan", BulletinPaie.CodePlan);
                cmd.Parameters.AddWithValue("@CodeSituation", BulletinPaie.CodeSituation);
                cmd.Parameters.AddWithValue("@CodeTypeContrat", BulletinPaie.CodeTypeContrat);
                cmd.Parameters.AddWithValue("@CodeTypePeriode", BulletinPaie.CodeTypePeriode);
                cmd.Parameters.AddWithValue("@CotisationSociale", BulletinPaie.CotisationSociale);
                cmd.Parameters.AddWithValue("@DateOperation", BulletinPaie.DateOperation);
                cmd.Parameters.AddWithValue("@DatePaye", BulletinPaie.DatePaye);
                cmd.Parameters.AddWithValue("@HeureBase", BulletinPaie.HeureBase);
                cmd.Parameters.AddWithValue("@Imposable", BulletinPaie.Imposable);
                cmd.Parameters.AddWithValue("@ImpotLiquidatif", BulletinPaie.ImpotLiquidatif);
                cmd.Parameters.AddWithValue("@JourBase", BulletinPaie.JourBase);
                cmd.Parameters.AddWithValue("@LibelleBanque", BulletinPaie.LibelleBanque);
                cmd.Parameters.AddWithValue("@LibelleDepartement", BulletinPaie.LibelleDepartement);
                cmd.Parameters.AddWithValue("@LibelleFonction", BulletinPaie.LibelleFonction);
                cmd.Parameters.AddWithValue("@LibellePeriode", BulletinPaie.LibellePeriode);
                cmd.Parameters.AddWithValue("@MatriculeAssuranceGroupe", BulletinPaie.MatriculeAssuranceGroupe);
                cmd.Parameters.AddWithValue("@MatriculeCnss", BulletinPaie.MatriculeCNSS);
                cmd.Parameters.AddWithValue("@MatriculeEmploye", BulletinPaie.MatriculeEmploye);
                cmd.Parameters.AddWithValue("@MontantCavis", BulletinPaie.MontantCavis);
                cmd.Parameters.AddWithValue("@MontantPlafondAssuranceGroupe", BulletinPaie.MontantPlafondAssuranceGroupe);
                cmd.Parameters.AddWithValue("@MontantRedevanceCompensation", BulletinPaie.MontantRedevanceCompensation);
                cmd.Parameters.AddWithValue("@NombrePersonneAcharge", BulletinPaie.NombrePersonneACharge);
                cmd.Parameters.AddWithValue("@NomEmploye", BulletinPaie.NomEmploye);
                cmd.Parameters.AddWithValue("@Notes", BulletinPaie.Notes);
                cmd.Parameters.AddWithValue("@NumeroBulletin", BulletinPaie.NumeroBulletin);
                cmd.Parameters.AddWithValue("@RedevanceCompensation", BulletinPaie.RedevanceCompensation);
                cmd.Parameters.AddWithValue("@Rib", BulletinPaie.RIB);
                cmd.Parameters.AddWithValue("@SalaireBase", BulletinPaie.SalaireBase);
                cmd.Parameters.AddWithValue("@SalaireNet", BulletinPaie.SalaireNet);
                cmd.Parameters.AddWithValue("@Smig", BulletinPaie.Smig);
                cmd.Parameters.AddWithValue("@SoldeConge", BulletinPaie.SoldeConge);
                cmd.Parameters.AddWithValue("@TotalDeduction", BulletinPaie.TotalDeduction);
                cmd.Parameters.AddWithValue("@Valide", BulletinPaie.Valide);
                cmd.Parameters.AddWithValue("@VirementDetails", BulletinPaie.VIREMENT_DETAIL);
                connection.Open();
                await cmd.ExecuteNonQueryAsync();
                connection.Close();
            }
        }

        public void DeleteBulletinPaiePS(string NumeroBulletin)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_DELETE_BULLETIN_PAIE", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumeroBulletin", NumeroBulletin);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<BULLETIN_PAIE> GetAllBulletinPaiesPS()
        {
            List<BULLETIN_PAIE> lstBulletinsPaie = new List<BULLETIN_PAIE>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BULLETINS_PAIE", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BULLETIN_PAIE BulletinPaie = new BULLETIN_PAIE();

                    BulletinPaie.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    BulletinPaie.CodeEmploye = sdr["CodeEmploye"].ToString();
                    BulletinPaie.DatePaye = Convert.ToDateTime(sdr["DatePaye"]);
                    BulletinPaie.RIB = sdr["RIB"].ToString();
                    BulletinPaie.CIN = sdr["CIN"].ToString();
                    BulletinPaie.ArrondissementNegatif = Convert.ToDecimal(sdr["ArrondissementNegatif"]);
                    BulletinPaie.ArrondissementPositif = Convert.ToDecimal(sdr["ArrondissementPositif"]);
                    BulletinPaie.AssuranceGroupe = Convert.ToBoolean(sdr["AssuranceGroupe"]);
                    BulletinPaie.Cavis = Convert.ToBoolean(sdr["Cavis"]);
                    BulletinPaie.ChefFamille = Convert.ToBoolean(sdr["ChefFamille"]);
                    BulletinPaie.CodeBanque = sdr["CodeBanque"].ToString();
                    BulletinPaie.CodeDepartement = sdr["CodeDepartement"].ToString();
                    BulletinPaie.CodeFonction = sdr["CodeFonction"].ToString();
                    BulletinPaie.CodeGrille = sdr["CodeGrille"].ToString();
                    BulletinPaie.CodeModele = sdr["CodeModele"].ToString();
                    BulletinPaie.CodeModePaiement = sdr["CodeModePaiement"].ToString();
                    BulletinPaie.CodeOperateur = sdr["CodeOperateur"].ToString();
                    BulletinPaie.CodePeriode = sdr["CodePeriode"].ToString();
                    BulletinPaie.CodePlan = sdr["CodePlan"].ToString();
                    BulletinPaie.CodeSituation = sdr["CodeSituation"].ToString();
                    BulletinPaie.CodeTypeContrat = sdr["CodeTypeContrat"].ToString();
                    BulletinPaie.CodeTypePeriode = sdr["CodeTypePeriode"].ToString();
                    BulletinPaie.CotisationSociale = Convert.ToBoolean(sdr["CotisationSociale"]);
                    BulletinPaie.DateOperation = Convert.ToDateTime(sdr["DateOperation"]);
                    BulletinPaie.HeureBase = (int)sdr["HeureBase"];
                    BulletinPaie.Imposable = Convert.ToBoolean(sdr["Imposable"]);
                    BulletinPaie.ImpotLiquidatif = Convert.ToBoolean(sdr["ImpotLiquidatif"]);
                    BulletinPaie.JourBase = (int)sdr["JourBase"];
                    BulletinPaie.LibelleBanque = sdr["LibelleBanque"].ToString();
                    BulletinPaie.LibelleDepartement = sdr["LibelleDepartement"].ToString();
                    BulletinPaie.LibelleFonction = sdr["LibelleFonction"].ToString();
                    BulletinPaie.LibellePeriode = sdr["LibellePeriode"].ToString();
                    BulletinPaie.MatriculeAssuranceGroupe = sdr["MatriculeAssuranceGroupe"].ToString();
                    BulletinPaie.MatriculeCNSS = sdr["MatriculeCnss"].ToString();
                    BulletinPaie.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    BulletinPaie.MontantCavis = Convert.ToDecimal(sdr["MontantCavis"]);
                    BulletinPaie.MontantPlafondAssuranceGroupe = Convert.ToDecimal(sdr["MontantPlafondAssuranceGroupe"]);
                    BulletinPaie.MontantRedevanceCompensation = Convert.ToDecimal(sdr["MontantRedevanceCompensation"]);
                    BulletinPaie.NombrePersonneACharge = (int)sdr["NombrePersonneAcharge"];
                    BulletinPaie.NomEmploye = sdr["NomEmploye"].ToString();
                    BulletinPaie.Notes = sdr["Notes"].ToString();
                    BulletinPaie.RedevanceCompensation = Convert.ToBoolean(sdr["RedevanceCompensation"]);
                    BulletinPaie.SalaireBase = Convert.ToDecimal(sdr["SalaireBase"]);
                    BulletinPaie.SalaireNet = Convert.ToDecimal(sdr["SalaireNet"]);
                    BulletinPaie.Smig = Convert.ToBoolean(sdr["Smig"]);
                    BulletinPaie.SoldeConge = Convert.ToDecimal(sdr["SoldeConge"]);
                    BulletinPaie.TotalDeduction = Convert.ToDecimal(sdr["TotalDeduction"]);
                    BulletinPaie.Valide = Convert.ToBoolean(sdr["Valide"]);

                    #region xxx
                    //cmd.Parameters.AddWithValue("@ArrondissementNegatif", BulletinPaie.ArrondissementNegatif);
                    //cmd.Parameters.AddWithValue("@ArrondissementPositif", BulletinPaie.ArrondissementPositif);
                    //cmd.Parameters.AddWithValue("@AssuranceGroupe", BulletinPaie.AssuranceGroupe);
                    //cmd.Parameters.AddWithValue("@Cavis", BulletinPaie.Cavis);
                    //cmd.Parameters.AddWithValue("@ChefFamille", BulletinPaie.ChefFamille);
                    //cmd.Parameters.AddWithValue("@Cin", BulletinPaie.Cin);
                    //cmd.Parameters.AddWithValue("@Code", BulletinPaie.Code);
                    //cmd.Parameters.AddWithValue("@CodeBanque", BulletinPaie.CodeBanque);
                    ////cmd.Parameters.AddWithValue("@CodeBanqueNavigation", BulletinPaie.CodeBanqueNavigation);
                    //cmd.Parameters.AddWithValue("@CodeDepartement", BulletinPaie.CodeDepartement);
                    //cmd.Parameters.AddWithValue("@CodeFonction", BulletinPaie.CodeFonction);
                    ////cmd.Parameters.AddWithValue("@CodeDepartementNavigation", BulletinPaie.CodeDepartementNavigation);
                    ////cmd.Parameters.AddWithValue("@CodeFonctionNavigation", BulletinPaie.CodeFonctionNavigation);
                    //cmd.Parameters.AddWithValue("@CodeGrille", BulletinPaie.CodeGrille);
                    //cmd.Parameters.AddWithValue("@CodeModele", BulletinPaie.CodeModele);
                    ////cmd.Parameters.AddWithValue("@CodeModeleNavigation", BulletinPaie.CodeModeleNavigation);
                    //cmd.Parameters.AddWithValue("@CodeModePaiement", BulletinPaie.CodeModePaiement);
                    ////cmd.Parameters.AddWithValue("@CodeModePaiementNavigation", BulletinPaie.CodeModePaiementNavigation);
                    //cmd.Parameters.AddWithValue("@CodeOperateur", BulletinPaie.CodeOperateur);
                    //cmd.Parameters.AddWithValue("@CodeP", BulletinPaie.CodeP);
                    //cmd.Parameters.AddWithValue("@CodePeriode", BulletinPaie.CodePeriode);
                    //cmd.Parameters.AddWithValue("@CodePlan", BulletinPaie.CodePlan);
                    //cmd.Parameters.AddWithValue("@CodeSituation", BulletinPaie.CodeSituation);
                    //cmd.Parameters.AddWithValue("@CodeTypeContrat", BulletinPaie.CodeTypeContrat);
                    //cmd.Parameters.AddWithValue("@CodeTypePeriode", BulletinPaie.CodeTypePeriode);
                    ////cmd.Parameters.AddWithValue("@CodeTypePeriodeNavigation", BulletinPaie.CodeTypePeriodeNavigation);
                    //cmd.Parameters.AddWithValue("@CotisationSociale", BulletinPaie.CotisationSociale);
                    //cmd.Parameters.AddWithValue("@DateOperation", BulletinPaie.DateOperation);
                    //cmd.Parameters.AddWithValue("@DatePaye", BulletinPaie.DatePaye);
                    //cmd.Parameters.AddWithValue("@HeureBase", BulletinPaie.HeureBase);
                    //cmd.Parameters.AddWithValue("@Imposable", BulletinPaie.Imposable);
                    //cmd.Parameters.AddWithValue("@ImpotLiquidatif", BulletinPaie.ImpotLiquidatif);
                    //cmd.Parameters.AddWithValue("@JourBase", BulletinPaie.JourBase);
                    //cmd.Parameters.AddWithValue("@LibelleBanque", BulletinPaie.LibelleBanque);
                    //cmd.Parameters.AddWithValue("@LibelleDepartement", BulletinPaie.LibelleDepartement);
                    //cmd.Parameters.AddWithValue("@LibelleFonction", BulletinPaie.LibelleFonction);
                    //cmd.Parameters.AddWithValue("@LibellePeriode", BulletinPaie.LibellePeriode);
                    //cmd.Parameters.AddWithValue("@MatriculeAssuranceGroupe", BulletinPaie.MatriculeAssuranceGroupe);
                    //cmd.Parameters.AddWithValue("@MatriculeCnss", BulletinPaie.MatriculeCnss);
                    //cmd.Parameters.AddWithValue("@MatriculeEmploye", BulletinPaie.MatriculeEmploye);
                    //cmd.Parameters.AddWithValue("@MontantCavis", BulletinPaie.MontantCavis);
                    //cmd.Parameters.AddWithValue("@MontantPlafondAssuranceGroupe", BulletinPaie.MontantPlafondAssuranceGroupe);
                    //cmd.Parameters.AddWithValue("@MontantRedevanceCompensation", BulletinPaie.MontantRedevanceCompensation);
                    //cmd.Parameters.AddWithValue("@NombrePersonneAcharge", BulletinPaie.NombrePersonneAcharge);
                    //cmd.Parameters.AddWithValue("@NomEmploye", BulletinPaie.NomEmploye);
                    //cmd.Parameters.AddWithValue("@Notes", BulletinPaie.Notes);
                    //cmd.Parameters.AddWithValue("@NumeroBulletin", BulletinPaie.NumeroBulletin);
                    //cmd.Parameters.AddWithValue("@RedevanceCompensation", BulletinPaie.RedevanceCompensation);
                    //cmd.Parameters.AddWithValue("@Rib", BulletinPaie.Rib);
                    //cmd.Parameters.AddWithValue("@SalaireBase", BulletinPaie.SalaireBase);
                    //cmd.Parameters.AddWithValue("@SalaireNet", BulletinPaie.SalaireNet);
                    //cmd.Parameters.AddWithValue("@Smig", BulletinPaie.Smig);
                    //cmd.Parameters.AddWithValue("@SoldeConge", BulletinPaie.SoldeConge);
                    //cmd.Parameters.AddWithValue("@TotalDeduction", BulletinPaie.TotalDeduction);
                    //cmd.Parameters.AddWithValue("@Valide", BulletinPaie.Valide);
                    //cmd.Parameters.AddWithValue("@VirementDetails", BulletinPaie.VirementDetails);
                    #endregion

                    lstBulletinsPaie.Add(BulletinPaie);
                }
                connection.Close();
            }
            return lstBulletinsPaie;
        }

        public BULLETIN_PAIE_DETAIL GetBulletinPaieDetailsPS(string NumeroBulletin, string CodeRubrique)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            BULLETIN_PAIE_DETAIL BulletinPaieDetail = new BULLETIN_PAIE_DETAIL();
            //BulletinPaie BulletinPaie = new BulletinPaie();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_BULLETIN_PAIE_DETAILSByNumero", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NumeroBulletin", NumeroBulletin);
                cmd.Parameters.AddWithValue("@CodeRubrique", CodeRubrique);

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    #region BP
                    //BulletinPaie.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    //BulletinPaie.DatePaye = Convert.ToDateTime(sdr["DatePaye"]);
                    //BulletinPaie.Rib = sdr["RIB"].ToString();
                    //BulletinPaie.Cin = sdr["CIN"].ToString();
                    //BulletinPaie.ArrondissementNegatif = Convert.ToDecimal(sdr["ArrondissementNegatif"]);
                    //BulletinPaie.ArrondissementPositif = Convert.ToDecimal(sdr["ArrondissementPositif"]);
                    //BulletinPaie.AssuranceGroupe = Convert.ToBoolean(sdr["AssuranceGroupe"]);
                    //BulletinPaie.Cavis = Convert.ToBoolean(sdr["Cavis"]);
                    //BulletinPaie.ChefFamille = Convert.ToBoolean(sdr["ChefFamille"]);
                    ////BulletinPaie.Code = sdr["Code"].ToString();
                    //BulletinPaie.CodeBanque = sdr["CodeBanque"].ToString();
                    //BulletinPaie.CodeDepartement = sdr["CodeDepartement"].ToString();
                    //BulletinPaie.CodeFonction = sdr["CodeFonction"].ToString();
                    //BulletinPaie.CodeGrille = sdr["CodeGrille"].ToString();
                    //BulletinPaie.CodeModele = sdr["CodeModele"].ToString();
                    //BulletinPaie.CodeModePaiement = sdr["CodeModePaiement"].ToString();
                    //BulletinPaie.CodeOperateur = sdr["CodeOperateur"].ToString();
                    ////BulletinPaie.CodeP = sdr["CodeP"].ToString();
                    //BulletinPaie.CodePeriode = sdr["CodePeriode"].ToString();
                    //BulletinPaie.CodePlan = sdr["CodePlan"].ToString();
                    //BulletinPaie.CodeSituation = sdr["CodeSituation"].ToString();
                    //BulletinPaie.CodeTypeContrat = sdr["CodeTypeContrat"].ToString();
                    //BulletinPaie.CodeTypePeriode = sdr["CodeTypePeriode"].ToString();
                    //BulletinPaie.CotisationSociale = Convert.ToBoolean(sdr["CotisationSociale"]);
                    //BulletinPaie.DateOperation = Convert.ToDateTime(sdr["DateOperation"]);
                    //BulletinPaie.HeureBase = (int)sdr["HeureBase"];
                    //BulletinPaie.Imposable = Convert.ToBoolean(sdr["Imposable"]);
                    //BulletinPaie.ImpotLiquidatif = Convert.ToBoolean(sdr["ImpotLiquidatif"]);
                    //BulletinPaie.JourBase = (int)sdr["JourBase"];
                    //BulletinPaie.LibelleBanque = sdr["LibelleBanque"].ToString();
                    //BulletinPaie.LibelleDepartement = sdr["LibelleDepartement"].ToString();
                    //BulletinPaie.LibelleFonction = sdr["LibelleFonction"].ToString();
                    //BulletinPaie.LibellePeriode = sdr["LibellePeriode"].ToString();
                    //BulletinPaie.MatriculeAssuranceGroupe = sdr["MatriculeAssuranceGroupe"].ToString();
                    //BulletinPaie.MatriculeCnss = sdr["MatriculeCnss"].ToString();
                    //BulletinPaie.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    //BulletinPaie.MontantCavis = Convert.ToDecimal(sdr["MontantCavis"]);
                    //BulletinPaie.MontantPlafondAssuranceGroupe = Convert.ToDecimal(sdr["MontantPlafondAssuranceGroupe"]);
                    //BulletinPaie.MontantRedevanceCompensation = Convert.ToDecimal(sdr["MontantRedevanceCompensation"]);
                    //BulletinPaie.NombrePersonneAcharge = (int)sdr["NombrePersonneAcharge"];
                    //BulletinPaie.NomEmploye = sdr["NomEmploye"].ToString();
                    //BulletinPaie.Notes = sdr["Notes"].ToString();
                    //BulletinPaie.RedevanceCompensation = Convert.ToBoolean(sdr["RedevanceCompensation"]);
                    //BulletinPaie.SalaireBase = Convert.ToDecimal(sdr["SalaireBase"]);
                    //BulletinPaie.SalaireNet = Convert.ToDecimal(sdr["SalaireNet"]);
                    //BulletinPaie.Smig = Convert.ToBoolean(sdr["Smig"]);
                    //BulletinPaie.SoldeConge = Convert.ToDecimal(sdr["SoldeConge"]);
                    //BulletinPaie.TotalDeduction = Convert.ToDecimal(sdr["TotalDeduction"]);
                    //BulletinPaie.Valide = Convert.ToBoolean(sdr["Valide"]);
                    //BulletinPaie.CodeEmploye = sdr["CodeEmploye"].ToString();
                    #endregion
                    #region BPD
                    BulletinPaieDetail.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    BulletinPaieDetail.CodeRubrique = sdr["CodeRubrique"].ToString();
                    BulletinPaieDetail.CodeTypeRubrique = sdr["CodeTypeRubrique"].ToString();
                    BulletinPaieDetail.CodeSecondaire = sdr["CodeSecondaire"].ToString();
                    BulletinPaieDetail.MontantBase = Convert.ToDecimal(sdr["MontantBase"]);
                    BulletinPaieDetail.Taux = Convert.ToDecimal(sdr["Taux"]);
                    BulletinPaieDetail.Nombre = (float)(sdr["Nombre"]);
                    BulletinPaieDetail.Valeur = Convert.ToDecimal(sdr["Valeur"]);
                    BulletinPaieDetail.Montant = Convert.ToDecimal(sdr["Montant"]);
                    BulletinPaieDetail.LibelleRubrique = sdr["LibelleRubrique"].ToString();
                    BulletinPaieDetail.LibelleTypeRubrique = sdr["LibelleTypeRubrique"].ToString();
                    BulletinPaieDetail.InclureAssuranceGroupe = Convert.ToBoolean(sdr["InclureAssuranceGroupe"]);
                    BulletinPaieDetail.InclureSecuriteSociale = Convert.ToBoolean(sdr["InclureSecuriteSociale"]);
                    BulletinPaieDetail.InclureImpot = Convert.ToBoolean(sdr["InclureImpot"]);
                    BulletinPaieDetail.IndemniteActive = Convert.ToBoolean(sdr["IndemniteActive"]);
                    BulletinPaieDetail.InclureIndemniteConge = Convert.ToBoolean(sdr["InclureIndemniteConge"]);
                    BulletinPaieDetail.CodeTypeIndemnite = sdr["CodeTypeIndemnite"].ToString();
                    BulletinPaieDetail.MontantIndemnite = Convert.ToDecimal(sdr["MontantIndemnite"]);
                    BulletinPaieDetail.BasePonderation = Convert.ToDecimal(sdr["BasePonderation"]);
                    BulletinPaieDetail.RubriqueParDefaut = Convert.ToBoolean(sdr["RubriqueParDefaut"]);
                    BulletinPaieDetail.Actif = Convert.ToBoolean(sdr["Actif"]);
                    BulletinPaieDetail.MontantRubrique = Convert.ToDecimal(sdr["MontantRubrique"]);
                    BulletinPaieDetail.MontantPlafondMaximum = Convert.ToDecimal(sdr["MontantPlafondMaximum"]);
                    BulletinPaieDetail.MontantPlafondMinimum = Convert.ToDecimal(sdr["MontantPlafondMinimum"]);
                    #endregion
                }
                #region NextResult()
                //if (sdr.NextResult())
                //{
                //    while (sdr.Read())
                //    {
                //        #region BPD
                //        BulletinPaieDetail.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                //        BulletinPaieDetail.CodeRubrique = sdr["CodeRubrique"].ToString();
                //        BulletinPaieDetail.CodeTypeRubrique = sdr["CodeTypeRubrique"].ToString();
                //        BulletinPaieDetail.CodeSecondaire = sdr["CodeSecondaire"].ToString();
                //        BulletinPaieDetail.MontantBase = Convert.ToDecimal(sdr["MontantBase"]);
                //        BulletinPaieDetail.Taux = Convert.ToDecimal(sdr["Taux"]);
                //        BulletinPaieDetail.Nombre = (float)(sdr["Nombre"]);
                //        BulletinPaieDetail.Valeur = Convert.ToDecimal(sdr["Valeur"]);
                //        BulletinPaieDetail.Montant = Convert.ToDecimal(sdr["Montant"]);
                //        BulletinPaieDetail.LibelleRubrique = sdr["LibelleRubrique"].ToString();
                //        BulletinPaieDetail.LibelleTypeRubrique = sdr["LibelleTypeRubrique"].ToString();
                //        BulletinPaieDetail.InclureAssuranceGroupe = Convert.ToBoolean(sdr["InclureAssuranceGroupe"]);
                //        BulletinPaieDetail.InclureSecuriteSociale = Convert.ToBoolean(sdr["InclureSecuriteSociale"]);
                //        BulletinPaieDetail.InclureImpot = Convert.ToBoolean(sdr["InclureImpot"]);
                //        BulletinPaieDetail.IndemniteActive = Convert.ToBoolean(sdr["IndemniteActive"]);
                //        BulletinPaieDetail.InclureIndemniteConge = Convert.ToBoolean(sdr["InclureIndemniteConge"]);
                //        BulletinPaieDetail.CodeTypeIndemnite = sdr["CodeTypeIndemnite"].ToString();
                //        BulletinPaieDetail.MontantIndemnite = Convert.ToDecimal(sdr["MontantIndemnite"]);
                //        BulletinPaieDetail.BasePonderation = Convert.ToDecimal(sdr["BasePonderation"]);
                //        BulletinPaieDetail.RubriqueParDefaut = Convert.ToBoolean(sdr["RubriqueParDefaut"]);
                //        BulletinPaieDetail.Actif = Convert.ToBoolean(sdr["Actif"]);
                //        BulletinPaieDetail.MontantRubrique = Convert.ToDecimal(sdr["MontantRubrique"]);
                //        BulletinPaieDetail.MontantPlafondMaximum = Convert.ToDecimal(sdr["MontantPlafondMaximum"]);
                //        BulletinPaieDetail.MontantPlafondMinimum = Convert.ToDecimal(sdr["MontantPlafondMinimum"]);
                //        #endregion
                //    }
                //}
                #endregion
            }
            return BulletinPaieDetail;
        }

        public async Task<BULLETIN_PAIE> GetBulletinPaiePSbyNumero(string numeroBulletin)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            BULLETIN_PAIE BulletinPaie = new BULLETIN_PAIE();

            await using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BULLETIN_PAIE_ByNumero", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroBulletin", numeroBulletin);

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BulletinPaie.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    BulletinPaie.DatePaye = Convert.ToDateTime(sdr["DatePaye"]);
                    BulletinPaie.RIB = sdr["RIB"].ToString();
                    BulletinPaie.CIN = sdr["CIN"].ToString();
                    BulletinPaie.ArrondissementNegatif = Convert.ToDecimal(sdr["ArrondissementNegatif"]);
                    BulletinPaie.ArrondissementPositif = Convert.ToDecimal(sdr["ArrondissementPositif"]);
                    BulletinPaie.AssuranceGroupe = Convert.ToBoolean(sdr["AssuranceGroupe"]);
                    BulletinPaie.Cavis = Convert.ToBoolean(sdr["Cavis"]);
                    BulletinPaie.ChefFamille = Convert.ToBoolean(sdr["ChefFamille"]);
                    //BulletinPaie.Code = sdr["Code"].ToString();
                    BulletinPaie.CodeBanque = sdr["CodeBanque"].ToString();
                    BulletinPaie.CodeDepartement = sdr["CodeDepartement"].ToString();
                    BulletinPaie.CodeFonction = sdr["CodeFonction"].ToString();
                    BulletinPaie.CodeGrille = sdr["CodeGrille"].ToString();
                    BulletinPaie.CodeModele = sdr["CodeModele"].ToString();
                    BulletinPaie.CodeModePaiement = sdr["CodeModePaiement"].ToString();
                    BulletinPaie.CodeOperateur = sdr["CodeOperateur"].ToString();
                    //BulletinPaie.CodeP = sdr["CodeP"].ToString();
                    BulletinPaie.CodePeriode = sdr["CodePeriode"].ToString();
                    BulletinPaie.CodePlan = sdr["CodePlan"].ToString();
                    BulletinPaie.CodeSituation = sdr["CodeSituation"].ToString();
                    BulletinPaie.CodeTypeContrat = sdr["CodeTypeContrat"].ToString();
                    BulletinPaie.CodeTypePeriode = sdr["CodeTypePeriode"].ToString();
                    BulletinPaie.CotisationSociale = Convert.ToBoolean(sdr["CotisationSociale"]);
                    BulletinPaie.DateOperation = Convert.ToDateTime(sdr["DateOperation"]);
                    BulletinPaie.HeureBase = (int)sdr["HeureBase"];
                    BulletinPaie.Imposable = Convert.ToBoolean(sdr["Imposable"]);
                    BulletinPaie.ImpotLiquidatif = Convert.ToBoolean(sdr["ImpotLiquidatif"]);
                    BulletinPaie.JourBase = (int)sdr["JourBase"];
                    BulletinPaie.LibelleBanque = sdr["LibelleBanque"].ToString();
                    BulletinPaie.LibelleDepartement = sdr["LibelleDepartement"].ToString();
                    BulletinPaie.LibelleFonction = sdr["LibelleFonction"].ToString();
                    BulletinPaie.LibellePeriode = sdr["LibellePeriode"].ToString();
                    BulletinPaie.MatriculeAssuranceGroupe = sdr["MatriculeAssuranceGroupe"].ToString();
                    BulletinPaie.MatriculeCNSS = sdr["MatriculeCnss"].ToString();
                    BulletinPaie.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    BulletinPaie.MontantCavis = Convert.ToDecimal(sdr["MontantCavis"]);
                    BulletinPaie.MontantPlafondAssuranceGroupe = Convert.ToDecimal(sdr["MontantPlafondAssuranceGroupe"]);
                    BulletinPaie.MontantRedevanceCompensation = Convert.ToDecimal(sdr["MontantRedevanceCompensation"]);
                    BulletinPaie.NombrePersonneACharge = (int)sdr["NombrePersonneAcharge"];
                    BulletinPaie.NomEmploye = sdr["NomEmploye"].ToString();
                    BulletinPaie.Notes = sdr["Notes"].ToString();
                    BulletinPaie.RedevanceCompensation = Convert.ToBoolean(sdr["RedevanceCompensation"]);
                    BulletinPaie.SalaireBase = Convert.ToDecimal(sdr["SalaireBase"]);
                    BulletinPaie.SalaireNet = Convert.ToDecimal(sdr["SalaireNet"]);
                    BulletinPaie.Smig = Convert.ToBoolean(sdr["Smig"]);
                    BulletinPaie.SoldeConge = Convert.ToDecimal(sdr["SoldeConge"]);
                    BulletinPaie.TotalDeduction = Convert.ToDecimal(sdr["TotalDeduction"]);
                    BulletinPaie.Valide = Convert.ToBoolean(sdr["Valide"]);
                    BulletinPaie.CodeEmploye = sdr["CodeEmploye"].ToString();
                }
                connection.Close();
            }
            return BulletinPaie;
        }

        public void UpdateBulletinPaiePS(BULLETIN_PAIE BulletinPaie)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_BulletinPaie", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@ArrondissementNegatif", BulletinPaie.ArrondissementNegatif);
                    cmd.Parameters.AddWithValue("@ArrondissementPositif", BulletinPaie.ArrondissementPositif);
                    cmd.Parameters.AddWithValue("@AssuranceGroupe", BulletinPaie.AssuranceGroupe);
                    cmd.Parameters.AddWithValue("@Cavis", BulletinPaie.Cavis);
                    cmd.Parameters.AddWithValue("@ChefFamille", BulletinPaie.ChefFamille);
                    cmd.Parameters.AddWithValue("@Cin", BulletinPaie.CIN);
                    cmd.Parameters.AddWithValue("@CodeBanque", BulletinPaie.CodeBanque);
                    cmd.Parameters.AddWithValue("@CodeDepartement", BulletinPaie.CodeDepartement);
                    cmd.Parameters.AddWithValue("@CodeFonction", BulletinPaie.CodeFonction);
                    cmd.Parameters.AddWithValue("@CodeGrille", BulletinPaie.CodeGrille);
                    cmd.Parameters.AddWithValue("@CodeModele", BulletinPaie.CodeModele);
                    cmd.Parameters.AddWithValue("@CodeModePaiement", BulletinPaie.CodeModePaiement);
                    cmd.Parameters.AddWithValue("@CodeOperateur", BulletinPaie.CodeOperateur);
                    cmd.Parameters.AddWithValue("@CodePeriode", BulletinPaie.CodePeriode);
                    cmd.Parameters.AddWithValue("@CodePlan", BulletinPaie.CodePlan);
                    cmd.Parameters.AddWithValue("@CodeSituation", BulletinPaie.CodeSituation);
                    cmd.Parameters.AddWithValue("@CodeTypeContrat", BulletinPaie.CodeTypeContrat);
                    cmd.Parameters.AddWithValue("@CodeTypePeriode", BulletinPaie.CodeTypePeriode);
                    cmd.Parameters.AddWithValue("@CotisationSociale", BulletinPaie.CotisationSociale);
                    cmd.Parameters.AddWithValue("@DateOperation", BulletinPaie.DateOperation);
                    cmd.Parameters.AddWithValue("@DatePaye", BulletinPaie.DatePaye);
                    cmd.Parameters.AddWithValue("@HeureBase", BulletinPaie.HeureBase);
                    cmd.Parameters.AddWithValue("@Imposable", BulletinPaie.Imposable);
                    cmd.Parameters.AddWithValue("@ImpotLiquidatif", BulletinPaie.ImpotLiquidatif);
                    cmd.Parameters.AddWithValue("@JourBase", BulletinPaie.JourBase);
                    cmd.Parameters.AddWithValue("@LibelleBanque", BulletinPaie.LibelleBanque);
                    cmd.Parameters.AddWithValue("@LibelleDepartement", BulletinPaie.LibelleDepartement);
                    cmd.Parameters.AddWithValue("@LibelleFonction", BulletinPaie.LibelleFonction);
                    cmd.Parameters.AddWithValue("@LibellePeriode", BulletinPaie.LibellePeriode);
                    cmd.Parameters.AddWithValue("@MatriculeAssuranceGroupe", BulletinPaie.MatriculeAssuranceGroupe);
                    cmd.Parameters.AddWithValue("@MatriculeCnss", BulletinPaie.MatriculeCNSS);
                    cmd.Parameters.AddWithValue("@MatriculeEmploye", BulletinPaie.MatriculeEmploye);
                    cmd.Parameters.AddWithValue("@MontantCavis", BulletinPaie.MontantCavis);
                    cmd.Parameters.AddWithValue("@MontantPlafondAssuranceGroupe", BulletinPaie.MontantPlafondAssuranceGroupe);
                    cmd.Parameters.AddWithValue("@MontantRedevanceCompensation", BulletinPaie.MontantRedevanceCompensation);
                    cmd.Parameters.AddWithValue("@NombrePersonneAcharge", BulletinPaie.NombrePersonneACharge);
                    cmd.Parameters.AddWithValue("@NomEmploye", BulletinPaie.NomEmploye);
                    cmd.Parameters.AddWithValue("@Notes", BulletinPaie.Notes);
                    cmd.Parameters.AddWithValue("@NumeroBulletin", BulletinPaie.NumeroBulletin);
                    cmd.Parameters.AddWithValue("@RedevanceCompensation", BulletinPaie.RedevanceCompensation);
                    cmd.Parameters.AddWithValue("@Rib", BulletinPaie.RIB);
                    cmd.Parameters.AddWithValue("@SalaireBase", BulletinPaie.SalaireBase);
                    cmd.Parameters.AddWithValue("@SalaireNet", BulletinPaie.SalaireNet);
                    cmd.Parameters.AddWithValue("@Smig", BulletinPaie.Smig);
                    cmd.Parameters.AddWithValue("@SoldeConge", BulletinPaie.SoldeConge);
                    cmd.Parameters.AddWithValue("@TotalDeduction", BulletinPaie.TotalDeduction);
                    cmd.Parameters.AddWithValue("@Valide", BulletinPaie.Valide);
                    //cmd.Parameters.AddWithValue("@VirementDetails", BulletinPaie.VIREMENT_DETAIL);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
