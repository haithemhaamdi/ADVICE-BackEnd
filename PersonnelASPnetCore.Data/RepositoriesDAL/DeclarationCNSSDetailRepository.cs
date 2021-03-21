using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class DeclarationCNSSDetailRepository : RepositoryBase<DECLARATION_CNSS_DETAIL>, IDeclarationCNSSDetailRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;

        public DeclarationCNSSDetailRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
            : base(repositoryContext)
        {
            _ConnectionString = configuration;
        }

        #endregion

        //public async Task CreateDeclarationCNSSDetailPSAsync(DECLARATION_CNSS_DETAIL DeclarationCNSSDetail)
        //{
        //    var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("dbo.PROC_CREATE_DECLARATION_CNSS_DETAIL", connection);

        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@CodeEmploye", DeclarationCNSSDetail.CodeEmploye);
        //        cmd.Parameters.AddWithValue("@DateEntree", DeclarationCNSSDetail.DateEntree);
        //        cmd.Parameters.AddWithValue("@DateSortie", DeclarationCNSSDetail.DateSortie);
        //        cmd.Parameters.AddWithValue("@CIN", DeclarationCNSSDetail.CIN);
        //        cmd.Parameters.AddWithValue("@Annee", DeclarationCNSSDetail.Annee);
        //        cmd.Parameters.AddWithValue("@MatriculeEmploye", DeclarationCNSSDetail.MatriculeEmploye);
        //        cmd.Parameters.AddWithValue("@MatriculeSecuriteSociale", DeclarationCNSSDetail.MatriculeSecuriteSociale);
        //        cmd.Parameters.AddWithValue("@Mois1", DeclarationCNSSDetail.Mois1);
        //        cmd.Parameters.AddWithValue("@Mois2", DeclarationCNSSDetail.Mois2);
        //        cmd.Parameters.AddWithValue("@Mois3", DeclarationCNSSDetail.Mois3);
        //        cmd.Parameters.AddWithValue("@NomEmploye", DeclarationCNSSDetail.NomEmploye);
        //        cmd.Parameters.AddWithValue("@NumeroLigne", DeclarationCNSSDetail.NumeroLigne);
        //        cmd.Parameters.AddWithValue("@NumeroPage", DeclarationCNSSDetail.NumeroPage);
        //        cmd.Parameters.AddWithValue("@TauxAccidentTravail", DeclarationCNSSDetail.TauxAccidentTravail);
        //        cmd.Parameters.AddWithValue("@TauxCotisationEmploye1", DeclarationCNSSDetail.TauxCotisationEmploye1);
        //        cmd.Parameters.AddWithValue("@TauxCotisationEmploye2", DeclarationCNSSDetail.TauxCotisationEmploye2);
        //        cmd.Parameters.AddWithValue("@TauxCotisationEmploye3", DeclarationCNSSDetail.TauxCotisationEmploye3);
        //        cmd.Parameters.AddWithValue("@TauxCotisationEmployeur", DeclarationCNSSDetail.TauxCotisationEmployeur);
        //        cmd.Parameters.AddWithValue("@TotalEmploye", DeclarationCNSSDetail.TotalEmploye);
        //        cmd.Parameters.AddWithValue("@Trimestre", DeclarationCNSSDetail.Trimestre);
        //        connection.Open();
        //        await cmd.ExecuteNonQueryAsync();
        //        connection.Close();
        //    }
        //}

        public void DeleteDeclarationCNSSDetailPS(int Annee, int Trimestre)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_DELETE_DECLARATION_CNSS_DETAIL", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Annee", Annee);
                cmd.Parameters.AddWithValue("@Trimestre", Trimestre);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<DECLARATION_CNSS_DETAIL> GetAllDeclarationCNSSDetailsPS()
        {
            List<DECLARATION_CNSS_DETAIL> lstDeclarationCNSS = new List<DECLARATION_CNSS_DETAIL>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BULLETINS_PAIE", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    DECLARATION_CNSS_DETAIL DeclarationCNSS = new DECLARATION_CNSS_DETAIL();

                    DeclarationCNSS.CodeEmploye = sdr["CodeEmploye"].ToString();
                    DeclarationCNSS.DateEntree = Convert.ToDateTime(sdr["DateEntree"]);
                    DeclarationCNSS.DateSortie = Convert.ToDateTime(sdr["DateSortie"]);
                    DeclarationCNSS.CIN = sdr["CIN"].ToString();
                    DeclarationCNSS.Annee = Convert.ToInt32(sdr["Annee"]);
                    DeclarationCNSS.MatriculeEmploye  = sdr["MatriculeEmploye"].ToString();
                    DeclarationCNSS.MatriculeSecuriteSociale = sdr["MatriculeSecuriteSociale"].ToString();
                    DeclarationCNSS.Mois1 = Convert.ToDecimal(sdr["Mois1"]);
                    DeclarationCNSS.Mois2 = Convert.ToDecimal(sdr["Mois2"]);
                    DeclarationCNSS.Mois3= Convert.ToDecimal(sdr["Mois3"]);
                    DeclarationCNSS.NomEmploye = sdr["NomEmploye"].ToString();
                    DeclarationCNSS.NumeroLigne = Convert.ToInt32(sdr["NumeroLigne"]);
                    DeclarationCNSS.NumeroPage = Convert.ToInt32(sdr["NumeroPage"]);
                    DeclarationCNSS.TauxAccidentTravail  = Convert.ToDecimal(sdr["TauxAccidentTravail"]);
                    DeclarationCNSS.TauxCotisationEmploye1  = Convert.ToDecimal(sdr["TauxCotisationEmploye1"]);
                    DeclarationCNSS.TauxCotisationEmploye2 = Convert.ToDecimal(sdr["TauxCotisationEmploye2"]);
                    DeclarationCNSS.TauxCotisationEmploye3 = Convert.ToDecimal(sdr["TauxCotisationEmploye3"]);
                    DeclarationCNSS.TauxCotisationEmployeur = Convert.ToDecimal(sdr["TauxCotisationEmployeur"]);
                    DeclarationCNSS.TotalEmploye = Convert.ToDecimal(sdr["TotalEmploye"]);
                    DeclarationCNSS.Trimestre = Convert.ToInt32(sdr["Trimestre"]);

                    lstDeclarationCNSS.Add(DeclarationCNSS);
                }
                connection.Close();
            }
            return lstDeclarationCNSS;
        }

        public DECLARATION_CNSS_DETAIL GetDeclarationCNSSDetailsPS(string MatriculeSecuriteSociale)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            DECLARATION_CNSS_DETAIL DeclarationCNSSDetail = new DECLARATION_CNSS_DETAIL();
            //BulletinPaie BulletinPaie = new BulletinPaie();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_DECLARATION_CNSS_DETAILS_BY_Matricule", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MatriculeSecuriteSociale", MatriculeSecuriteSociale);

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
                    DeclarationCNSSDetail.CodeEmploye = sdr["CodeEmploye"].ToString();
                    DeclarationCNSSDetail.DateEntree = Convert.ToDateTime(sdr["DateEntree"]);
                    DeclarationCNSSDetail.DateSortie = Convert.ToDateTime(sdr["DateSortie"]);
                    DeclarationCNSSDetail.CIN = sdr["CIN"].ToString();
                    DeclarationCNSSDetail.Annee = (int)sdr["Annee"];
                    DeclarationCNSSDetail.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    DeclarationCNSSDetail.MatriculeSecuriteSociale = sdr["MatriculeSecuriteSociale"].ToString();
                    DeclarationCNSSDetail.Mois1 = Convert.ToDecimal(sdr["Mois1"]);
                    DeclarationCNSSDetail.Mois2  = Convert.ToDecimal(sdr["Mois2"]);
                    DeclarationCNSSDetail.Mois3  = Convert.ToDecimal(sdr["Mois3"]);
                    DeclarationCNSSDetail.NomEmploye = sdr["NomEmploye"].ToString();
                    DeclarationCNSSDetail.NumeroLigne = (int)sdr["NumeroLigne"];
                    DeclarationCNSSDetail.NumeroPage = (int)sdr["NumeroPage"];
                    DeclarationCNSSDetail.TauxAccidentTravail = Convert.ToDecimal(sdr["TauxAccidentTravail"]);
                    DeclarationCNSSDetail.TauxCotisationEmploye1 = Convert.ToDecimal(sdr["TauxCotisationEmploye1"]);
                    DeclarationCNSSDetail.TauxCotisationEmploye2 = Convert.ToDecimal(sdr["TauxCotisationEmploye2"]);
                    DeclarationCNSSDetail.TauxCotisationEmploye3 = Convert.ToDecimal(sdr["TauxCotisationEmploye3"]);
                    DeclarationCNSSDetail.TauxCotisationEmployeur = Convert.ToDecimal(sdr["TauxCotisationEmployeur"]);
                    DeclarationCNSSDetail.TotalEmploye = Convert.ToDecimal(sdr["TotalEmploye"]);
                    DeclarationCNSSDetail.Trimestre =(int)sdr["Trimestre"];
                    
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
            return DeclarationCNSSDetail;
        }

        public void UpdateDeclarationCNSSDetailPS(DECLARATION_CNSS_DETAIL DeclarationCNSSDetail)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_DECLARATION_CNSS_DETAIL", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@CodeEmploye", DeclarationCNSSDetail.CodeEmploye);
                    cmd.Parameters.AddWithValue("@DateEntree", DeclarationCNSSDetail.DateEntree);
                    cmd.Parameters.AddWithValue("@DateSortie", DeclarationCNSSDetail.DateSortie);
                    cmd.Parameters.AddWithValue("@CIN", DeclarationCNSSDetail.CIN);
                    cmd.Parameters.AddWithValue("@Annee", DeclarationCNSSDetail.Annee);
                    cmd.Parameters.AddWithValue("@MatriculeEmploye", DeclarationCNSSDetail.MatriculeEmploye);
                    cmd.Parameters.AddWithValue("@MatriculeSecuriteSociale", DeclarationCNSSDetail.MatriculeSecuriteSociale);
                    cmd.Parameters.AddWithValue("@Mois1", DeclarationCNSSDetail.Mois1);
                    cmd.Parameters.AddWithValue("@Mois2", DeclarationCNSSDetail.Mois2);
                    cmd.Parameters.AddWithValue("@Mois3", DeclarationCNSSDetail.Mois3);
                    cmd.Parameters.AddWithValue("@NomEmploye", DeclarationCNSSDetail.NomEmploye);
                    cmd.Parameters.AddWithValue("@NumeroLigne", DeclarationCNSSDetail.NumeroLigne);
                    cmd.Parameters.AddWithValue("@NumeroPage", DeclarationCNSSDetail.NumeroPage);
                    cmd.Parameters.AddWithValue("@TauxAccidentTravail", DeclarationCNSSDetail.TauxAccidentTravail);
                    cmd.Parameters.AddWithValue("@TauxCotisationEmploye1", DeclarationCNSSDetail.TauxCotisationEmploye1);
                    cmd.Parameters.AddWithValue("@TauxCotisationEmploye2", DeclarationCNSSDetail.TauxCotisationEmploye2);
                    cmd.Parameters.AddWithValue("@TauxCotisationEmploye3", DeclarationCNSSDetail.TauxCotisationEmploye3);
                    cmd.Parameters.AddWithValue("@TauxCotisationEmployeur", DeclarationCNSSDetail.TauxCotisationEmployeur);
                    cmd.Parameters.AddWithValue("@TotalEmploye", DeclarationCNSSDetail.TotalEmploye);
                    cmd.Parameters.AddWithValue("@Trimestre", DeclarationCNSSDetail.Trimestre);
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