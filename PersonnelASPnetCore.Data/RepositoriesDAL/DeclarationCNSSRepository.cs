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
    public class DeclarationCNSSRepository : RepositoryBase<DECLARATION_CNSS>, IDeclarationCNSSRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;

        public DeclarationCNSSRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
            : base(repositoryContext)
        {
            _ConnectionString = configuration;
        }
        #endregion

        public async Task CreateDeclarationCNSSPSAsync(DECLARATION_CNSS DeclarationCNSS)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CREATE_DECLARATION_CNSS", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroCompteComptable", DeclarationCNSS.NumeroCompteComptable);
                cmd.Parameters.AddWithValue("@DateDeclaration", DeclarationCNSS.DateDeclaration);
                cmd.Parameters.AddWithValue("@CodeOperateur", DeclarationCNSS.CodeOperateur);
                cmd.Parameters.AddWithValue("@DateOperation", DeclarationCNSS.DateOperation);
                cmd.Parameters.AddWithValue("@Trimestre", DeclarationCNSS.Trimestre);
                cmd.Parameters.AddWithValue("@Annee", DeclarationCNSS.Annee);
                cmd.Parameters.AddWithValue("@CodeBanqueVirement", DeclarationCNSS.CodeBanqueVirement);
                cmd.Parameters.AddWithValue("@LibelleBanqueVirement", DeclarationCNSS.LibelleBanqueVirement);
                cmd.Parameters.AddWithValue("@ModePaiement", DeclarationCNSS.ModePaiement);
                cmd.Parameters.AddWithValue("@Montant", DeclarationCNSS.Montant);
                cmd.Parameters.AddWithValue("@NumeroCheque", DeclarationCNSS.NumeroCheque);
                cmd.Parameters.AddWithValue("@TauxAccidentTravail", DeclarationCNSS.TauxAccidentTravail);
                cmd.Parameters.AddWithValue("@TauxSecurite", DeclarationCNSS.TauxSecurite);
                cmd.Parameters.AddWithValue("@Valide", DeclarationCNSS.Valide);
                connection.Open();
                await cmd.ExecuteNonQueryAsync();
                connection.Close();
            }
        }

        public void DeleteDeclarationCNSSPS(int Annee, int Trimestre)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_DELETE_DECLARATION_CNSS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Annee", Annee);
                cmd.Parameters.AddWithValue("@Trimestre", Trimestre);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<DECLARATION_CNSS> GetAllDeclarationCNSSsPS()
        {
            List<DECLARATION_CNSS> lstDeclarationCNSSs = new List<DECLARATION_CNSS>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_DECLARATION_CNSS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    DECLARATION_CNSS DeclarationCNSS = new DECLARATION_CNSS();

                    DeclarationCNSS.NumeroCompteComptable = sdr["NumeroCompteComptable"].ToString();
                    DeclarationCNSS.DateDeclaration = Convert.ToDateTime(sdr["DateDeclaration"]);
                    DeclarationCNSS.CodeOperateur = sdr["CodeOperateur"].ToString();
                    DeclarationCNSS.DateOperation = Convert.ToDateTime(sdr["DateOperation"]);
                    DeclarationCNSS.Trimestre = Convert.ToInt32(sdr["Trimestre"]);
                    DeclarationCNSS.Annee = Convert.ToInt32(sdr["Annee"]);
                    DeclarationCNSS.CodeBanqueVirement = sdr["CodeBanqueVirement"].ToString();
                    DeclarationCNSS.LibelleBanqueVirement = sdr["LibelleBanqueVirement"].ToString();
                    DeclarationCNSS.ModePaiement = sdr["ModePaiement"].ToString();
                    DeclarationCNSS.Montant = Convert.ToDecimal(sdr["Montant"]);
                    DeclarationCNSS.NumeroCheque = sdr["NumeroCheque"].ToString();
                    DeclarationCNSS.TauxAccidentTravail = Convert.ToDecimal(sdr["TauxAccidentTravail"]);
                    DeclarationCNSS.TauxSecurite = Convert.ToDecimal(sdr["TauxSecurite"]);
                    DeclarationCNSS.Valide = Convert.ToBoolean(sdr["Valide"]);

                    lstDeclarationCNSSs.Add(DeclarationCNSS);
                }
                connection.Close();
            }
            return lstDeclarationCNSSs;
        }

        public DECLARATION_CNSS_DETAIL GetDeclarationCNSSDetailsPS(string MatriculeSecuriteSociale)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            DECLARATION_CNSS_DETAIL DeclarationCNSSDetail = new DECLARATION_CNSS_DETAIL();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_DECLARATION_CNSS_DETAIL_By_DateOperation", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MatriculeSecuriteSociale", MatriculeSecuriteSociale);

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    #region DCNSSD
                    DeclarationCNSSDetail.CodeEmploye = sdr["CodeEmploye"].ToString();
                    DeclarationCNSSDetail.DateEntree = Convert.ToDateTime(sdr["DateEntree"]);
                    DeclarationCNSSDetail.DateSortie = Convert.ToDateTime(sdr["DateSortie"]);
                    DeclarationCNSSDetail.CIN = sdr["CIN"].ToString();
                    DeclarationCNSSDetail.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    DeclarationCNSSDetail.MatriculeSecuriteSociale = sdr["MatriculeSecuriteSociale"].ToString();
                    DeclarationCNSSDetail.Mois1 = Convert.ToDecimal(sdr["Mois1"]);
                    DeclarationCNSSDetail.Mois2 = Convert.ToDecimal(sdr["Mois2"]);
                    DeclarationCNSSDetail.Mois3 = Convert.ToDecimal(sdr["Mois3"]);
                    DeclarationCNSSDetail.NomEmploye = sdr["NomEmploye"].ToString();
                    DeclarationCNSSDetail.NumeroLigne = (int)sdr["NumeroLigne"];
                    DeclarationCNSSDetail.NumeroPage = (int)sdr["NumeroPage"];
                    DeclarationCNSSDetail.TauxAccidentTravail = Convert.ToDecimal(sdr["TauxAccidentTravail"]);
                    DeclarationCNSSDetail.TauxCotisationEmploye1 = Convert.ToDecimal(sdr["TauxCotisationEmploye1"]);
                    DeclarationCNSSDetail.TauxCotisationEmploye2 = Convert.ToDecimal(sdr["TauxCotisationEmploye2"]);
                    DeclarationCNSSDetail.TauxCotisationEmploye3 = Convert.ToDecimal(sdr["TauxCotisationEmploye3"]);
                    DeclarationCNSSDetail.TauxCotisationEmployeur = Convert.ToDecimal(sdr["TauxCotisationEmployeur"]);
                    DeclarationCNSSDetail.TotalEmploye = Convert.ToDecimal(sdr["MontantIndemnite"]);
                    DeclarationCNSSDetail.Trimestre = (int)sdr["Trimestre"];
                    DeclarationCNSSDetail.Annee = (int)sdr["Annee"];
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

        public void UpdateDeclarationCNSSPS(DECLARATION_CNSS DeclarationCNSS)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_DECLARATION_CNSS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@NumeroCompteComptable", DeclarationCNSS.NumeroCompteComptable);
                    cmd.Parameters.AddWithValue("@DateDeclaration", DeclarationCNSS.DateDeclaration);
                    cmd.Parameters.AddWithValue("@CodeOperateur", DeclarationCNSS.CodeOperateur);
                    cmd.Parameters.AddWithValue("@DateOperation", DeclarationCNSS.DateOperation);
                    cmd.Parameters.AddWithValue("@Trimestre", DeclarationCNSS.Trimestre);
                    cmd.Parameters.AddWithValue("@Annee", DeclarationCNSS.Annee);
                    cmd.Parameters.AddWithValue("@CodeBanqueVirement", DeclarationCNSS.CodeBanqueVirement);
                    cmd.Parameters.AddWithValue("@LibelleBanqueVirement", DeclarationCNSS.LibelleBanqueVirement);
                    cmd.Parameters.AddWithValue("@ModePaiement", DeclarationCNSS.ModePaiement);
                    cmd.Parameters.AddWithValue("@Montant", DeclarationCNSS.Montant);
                    cmd.Parameters.AddWithValue("@NumeroCheque", DeclarationCNSS.NumeroCheque);
                    cmd.Parameters.AddWithValue("@TauxAccidentTravail", DeclarationCNSS.TauxAccidentTravail);
                    cmd.Parameters.AddWithValue("@TauxSecurite", DeclarationCNSS.TauxSecurite);
                    cmd.Parameters.AddWithValue("@Valide", DeclarationCNSS.Valide);
                    
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