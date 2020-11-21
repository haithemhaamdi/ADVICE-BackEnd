using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class EmployeRepository : RepositoryBase<EMPLOYE>, IEmployeRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;

        public EmployeRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
            : base(repositoryContext)
        {
            _ConnectionString = configuration;
        }
        #endregion
        public async Task CreateEmployePSAsync(EMPLOYE Employe)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CREATE_Employe", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmploye", Employe.CodeEmploye);
                cmd.Parameters.AddWithValue("@MatriculeEmploye", Employe.MatriculeEmploye);
                cmd.Parameters.AddWithValue("@CodeAppellation", Employe.CodeAppellation);
                cmd.Parameters.AddWithValue("@NomEmploye", Employe.NomEmploye);
                cmd.Parameters.AddWithValue("@Cin", Employe.CIN);
                cmd.Parameters.AddWithValue("@DateCin", Employe.DateCIN);
                cmd.Parameters.AddWithValue("@Passeport", Employe.Passeport);
                cmd.Parameters.AddWithValue("@DatePasseport", Employe.DatePasseport);
                cmd.Parameters.AddWithValue("@DateEntree", Employe.DateEntree);
                cmd.Parameters.AddWithValue("@DateSortie", Employe.DateSortie);
                cmd.Parameters.AddWithValue("@CodeFonction", Employe.CodeFonction);
                cmd.Parameters.AddWithValue("@CodeDepartement", Employe.CodeDepartement);
                cmd.Parameters.AddWithValue("@SalaireBase", Employe.SalaireBase);
                cmd.Parameters.AddWithValue("@TauxHoraire", Employe.TauxHoraire);
                cmd.Parameters.AddWithValue("@CodeGrille", Employe.CodeGrille);
                cmd.Parameters.AddWithValue("@CodeSituation", Employe.CodeSituation);
                cmd.Parameters.AddWithValue("@DateSituation", Employe.DateSituation);
                cmd.Parameters.AddWithValue("@ChefFamille", Employe.ChefFamille);
                cmd.Parameters.AddWithValue("@CongeAnnuel", Employe.CongeAnnuel);
                cmd.Parameters.AddWithValue("@CongeAnterieur", Employe.CongeAnterieur);
                cmd.Parameters.AddWithValue("@MatriculeSecuriteSociale", Employe.MatriculeSecuriteSociale);
                cmd.Parameters.AddWithValue("@MatriculeAssuranceGroupe", Employe.MatriculeAssuranceGroupe);
                cmd.Parameters.AddWithValue("@NumeroPermisConduite", Employe.NumeroPermisConduite);
                cmd.Parameters.AddWithValue("@CodeModePaiement", Employe.CodeModePaiement);
                cmd.Parameters.AddWithValue("@CodeBanque", Employe.CodeBanque);
                cmd.Parameters.AddWithValue("@AgenceBanque", Employe.AgenceBanque);
                cmd.Parameters.AddWithValue("@Rib", Employe.RIB);
                cmd.Parameters.AddWithValue("@DateNaissance", Employe.DateNaissance);
                cmd.Parameters.AddWithValue("@LieuNaissance", Employe.LieuNaissance);
                cmd.Parameters.AddWithValue("@Adresse", Employe.Adresse);
                cmd.Parameters.AddWithValue("@Ville", Employe.Ville);
                cmd.Parameters.AddWithValue("@CodePostal", Employe.CodePostal);
                cmd.Parameters.AddWithValue("@Telephone1", Employe.Telephone1);
                cmd.Parameters.AddWithValue("@Telephone2", Employe.Telephone2);
                cmd.Parameters.AddWithValue("@AdresseMail", Employe.AdresseMail);
                cmd.Parameters.AddWithValue("@Nationalite", Employe.Nationalite);
                cmd.Parameters.AddWithValue("@PhotoEmploye", Employe.PhotoEmploye);
                cmd.Parameters.AddWithValue("@TaillePhoto", Employe.TaillePhoto);
                cmd.Parameters.AddWithValue("@CodeOperateur", Employe.CodeOperateur);
                cmd.Parameters.AddWithValue("@DateModification", Employe.DateModification);
                cmd.Parameters.AddWithValue("@CodePlan", Employe.CodePlan);
                cmd.Parameters.AddWithValue("@Notes", Employe.Notes);
                cmd.Parameters.AddWithValue("@CodeNaturePaiement", Employe.CodeNaturePaiement);
                cmd.Parameters.AddWithValue("@TauxJournalier", Employe.TauxJournalier);
                cmd.Parameters.AddWithValue("@Imposable", Employe.Imposable);
                cmd.Parameters.AddWithValue("@CotisationSociale", Employe.CotisationSociale);
                cmd.Parameters.AddWithValue("@AssuranceGroupe", Employe.AssuranceGroupe);
                cmd.Parameters.AddWithValue("@ImpotLiquidatif", Employe.ImpotLiquidatif);
                cmd.Parameters.AddWithValue("@Smig", Employe.Smig);
                cmd.Parameters.AddWithValue("@RedevanceCompensation", Employe.RedevanceCompensation);
                cmd.Parameters.AddWithValue("@MontantPlafondAssuranceGroupe", Employe.MontantPlafondAssuranceGroupe);
                cmd.Parameters.AddWithValue("@ImposableAnterieur", Employe.ImposableAnterieur);
                cmd.Parameters.AddWithValue("@ImpotAnterieur", Employe.ImpotAnterieur);
                cmd.Parameters.AddWithValue("@AnneeImpotAnterieur", Employe.AnneeImpotAnterieur);
                cmd.Parameters.AddWithValue("@Cavis", Employe.Cavis);
                cmd.Parameters.AddWithValue("@Suffixe", Employe.Suffixe);
                cmd.Parameters.AddWithValue("@SituationFamilialle", Employe.SituationFamilialle);
                con.Open();
                await cmd.ExecuteNonQueryAsync();
                con.Close();
            }
        }

        public void DeleteEmployePS(string id)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_DELETE_Employe", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeEmploye", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<EMPLOYE> GetAllEmployesPS()
        {
            List<EMPLOYE> lstEmployes = new List<EMPLOYE>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_EMPLOYE", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    EMPLOYE Employe = new EMPLOYE();
                    Employe.CodeEmploye = sdr["CodeEmploye"].ToString();
                    Employe.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    Employe.CodeAppellation = sdr["CodeAppellation"].ToString();
                    Employe.CIN = sdr["Cin"].ToString();
                    Employe.DateCIN = Convert.ToDateTime(sdr["DateCin"]);
                    Employe.Passeport = sdr["Passeport"].ToString();
                    Employe.DatePasseport = Convert.ToDateTime(sdr["DatePasseport"]);
                    Employe.DateEntree = Convert.ToDateTime(sdr["DateEntree"]);
                    Employe.DateSortie = Convert.ToDateTime(sdr["DateSortie"]);
                    Employe.CodeFonction = sdr["CodeFonction"].ToString();
                    Employe.CodeDepartement = sdr["CodeDepartement"].ToString();
                    Employe.SalaireBase = Convert.ToDecimal(sdr["SalaireBase"]);
                    Employe.TauxHoraire = Convert.ToDecimal(sdr["TauxHoraire"]);
                    Employe.CodeGrille = sdr["CodeGrille"].ToString();
                    Employe.CodeSituation = sdr["CodeSituation"].ToString();
                    Employe.DateSituation = Convert.ToDateTime(sdr["DateSituation"]);
                    Employe.ChefFamille = Convert.ToBoolean(sdr["ChefFamille"]);
                    Employe.CongeAnnuel = Convert.ToDecimal(sdr["CongeAnnuel"]);
                    Employe.CongeAnterieur = Convert.ToDecimal(sdr["CongeAnterieur"]);
                    Employe.MatriculeSecuriteSociale = sdr["MatriculeSecuriteSociale"].ToString();
                    Employe.MatriculeAssuranceGroupe = sdr["MatriculeAssuranceGroupe"].ToString();
                    Employe.NumeroPermisConduite = sdr["NumeroPermisConduite"].ToString();
                    Employe.CodeModePaiement = sdr["CodeModePaiement"].ToString();
                    Employe.CodeBanque = sdr["CodeBanque"].ToString();
                    Employe.AgenceBanque = sdr["AgenceBanque"].ToString();
                    Employe.RIB = sdr["Rib"].ToString();
                    Employe.DateNaissance = Convert.ToDateTime(sdr["DateNaissance"]);
                    Employe.LieuNaissance = sdr["LieuNaissance"].ToString();
                    Employe.Adresse = sdr["Adresse"].ToString();
                    Employe.Ville = sdr["Ville"].ToString();
                    Employe.CodePostal = sdr["CodePostal"].ToString();
                    Employe.Telephone1 = sdr["Telephone1"].ToString();
                    Employe.Telephone2 = sdr["Telephone2"].ToString();
                    Employe.AdresseMail = sdr["AdresseMail"].ToString();
                    Employe.Nationalite = sdr["Nationalite"].ToString();
                    Employe.PhotoEmploye = (Byte[])sdr["PhotoEmploye"];
                    Employe.TaillePhoto = (int)sdr["TaillePhoto"];
                    Employe.DateModification = Convert.ToDateTime(sdr["DateModification"]);
                    Employe.CodePlan = sdr["CodePlan"].ToString();
                    Employe.Notes = sdr["Notes"].ToString();
                    Employe.CodeNaturePaiement = sdr["CodeNaturePaiement"].ToString();
                    Employe.TauxJournalier = Convert.ToDecimal(sdr["TauxJournalier"]);
                    Employe.Imposable = Convert.ToBoolean(sdr["Imposable"]);
                    Employe.CotisationSociale = Convert.ToBoolean(sdr["CotisationSociale"]);
                    Employe.AssuranceGroupe = Convert.ToBoolean(sdr["AssuranceGroupe"]);
                    Employe.ImpotLiquidatif = Convert.ToBoolean(sdr["ImpotLiquidatif"]);
                    Employe.Smig = Convert.ToBoolean(sdr["Smig"]);
                    Employe.RedevanceCompensation = Convert.ToBoolean(sdr["RedevanceCompensation"]);
                    Employe.MontantPlafondAssuranceGroupe = Convert.ToDecimal(sdr["MontantPlafondAssuranceGroupe"]);
                    Employe.ImpotAnterieur = Convert.ToDecimal(sdr["ImpotAnterieur"]);
                    Employe.ImposableAnterieur = Convert.ToDecimal(sdr["ImposableAnterieur"]);
                    Employe.AnneeImpotAnterieur = sdr["AnneeImpotAnterieur"].ToString();
                    Employe.Cavis = Convert.ToBoolean(sdr["Cavis"]);
                    Employe.Suffixe = sdr["Suffixe"].ToString();
                    Employe.SituationFamilialle = (int)sdr["SituationFamilialle"];

                    lstEmployes.Add(Employe);
                }
                con.Close();
            }
            return lstEmployes;
        }

        public async Task<EMPLOYE> GetEmployeByIDAsync(string codeEmp)
        {
         var Employee = await FindByConditionAync(o => o.CodeEmploye.Equals(codeEmp));
            return Employee.DefaultIfEmpty(new EMPLOYE())
                    .FirstOrDefault();
        }

        public EMPLOYE GetEmployeDetailsPS(string id)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            EMPLOYE Employe = new EMPLOYE();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_EmployeByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeEmp", id);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Employe.CodeEmploye = sdr["CodeEmploye"].ToString();
                    Employe.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    Employe.CodeAppellation = sdr["CodeAppellation"].ToString();
                    Employe.CIN = sdr["Cin"].ToString();
                    Employe.DateCIN = Convert.ToDateTime(sdr["DateCin"]);
                    Employe.Passeport = sdr["Passeport"].ToString();
                    Employe.DatePasseport = Convert.ToDateTime(sdr["DatePasseport"]);
                    Employe.DateEntree = Convert.ToDateTime(sdr["DateEntree"]);
                    Employe.DateSortie = Convert.ToDateTime(sdr["DateSortie"]);
                    Employe.CodeFonction = sdr["CodeFonction"].ToString();
                    Employe.CodeDepartement = sdr["CodeDepartement"].ToString();
                    Employe.SalaireBase = Convert.ToDecimal(sdr["SalaireBase"]);
                    Employe.TauxHoraire = Convert.ToDecimal(sdr["TauxHoraire"]);
                    Employe.CodeGrille = sdr["CodeGrille"].ToString();
                    Employe.CodeSituation = sdr["CodeSituation"].ToString();
                    Employe.DateSituation = Convert.ToDateTime(sdr["DateSituation"]);
                    Employe.ChefFamille = Convert.ToBoolean(sdr["ChefFamille"]);
                    Employe.CongeAnnuel = Convert.ToDecimal(sdr["CongeAnnuel"]);
                    Employe.CongeAnterieur = Convert.ToDecimal(sdr["CongeAnterieur"]);
                    Employe.MatriculeSecuriteSociale = sdr["MatriculeSecuriteSociale"].ToString();
                    Employe.MatriculeAssuranceGroupe = sdr["MatriculeAssuranceGroupe"].ToString();
                    Employe.NumeroPermisConduite = sdr["NumeroPermisConduite"].ToString();
                    Employe.CodeModePaiement = sdr["CodeModePaiement"].ToString();
                    Employe.CodeBanque = sdr["CodeBanque"].ToString();
                    Employe.AgenceBanque = sdr["AgenceBanque"].ToString();
                    Employe.RIB = sdr["Rib"].ToString();
                    Employe.DateNaissance = Convert.ToDateTime(sdr["DateNaissance"]);
                    Employe.LieuNaissance = sdr["LieuNaissance"].ToString();
                    Employe.Adresse = sdr["Adresse"].ToString();
                    Employe.Ville = sdr["Ville"].ToString();
                    Employe.CodePostal = sdr["CodePostal"].ToString();
                    Employe.Telephone1 = sdr["Telephone1"].ToString();
                    Employe.Telephone2 = sdr["Telephone2"].ToString();
                    Employe.AdresseMail = sdr["AdresseMail"].ToString();
                    Employe.Nationalite = sdr["Nationalite"].ToString();
                    Employe.PhotoEmploye = (Byte[])sdr["PhotoEmploye"];
                    Employe.TaillePhoto = (int)sdr["TaillePhoto"];
                    Employe.DateModification = Convert.ToDateTime(sdr["DateModification"]);
                    Employe.CodePlan = sdr["CodePlan"].ToString();
                    Employe.Notes = sdr["Notes"].ToString();
                    Employe.CodeNaturePaiement = sdr["CodeNaturePaiement"].ToString();
                    Employe.TauxJournalier = Convert.ToDecimal(sdr["TauxJournalier"]);
                    Employe.Imposable = Convert.ToBoolean(sdr["Imposable"]);
                    Employe.CotisationSociale = Convert.ToBoolean(sdr["CotisationSociale"]);
                    Employe.AssuranceGroupe = Convert.ToBoolean(sdr["AssuranceGroupe"]);
                    Employe.ImpotLiquidatif = Convert.ToBoolean(sdr["ImpotLiquidatif"]);
                    Employe.Smig = Convert.ToBoolean(sdr["Smig"]);
                    Employe.RedevanceCompensation = Convert.ToBoolean(sdr["RedevanceCompensation"]);
                    Employe.MontantPlafondAssuranceGroupe = Convert.ToDecimal(sdr["MontantPlafondAssuranceGroupe"]);
                    Employe.ImpotAnterieur = Convert.ToDecimal(sdr["ImpotAnterieur"]);
                    Employe.ImposableAnterieur = Convert.ToDecimal(sdr["ImposableAnterieur"]);
                    Employe.AnneeImpotAnterieur = sdr["AnneeImpotAnterieur"].ToString();
                    Employe.Cavis = Convert.ToBoolean(sdr["Cavis"]);
                    Employe.Suffixe = sdr["Suffixe"].ToString();
                    Employe.SituationFamilialle = (int)sdr["SituationFamilialle"];
                }
            }
            return Employe;
        }


        public EMPLOYE GetEmployesPSbyID(string codeEmp)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            EMPLOYE Employe = new EMPLOYE();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_EMPLOYEbyCode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmp", codeEmp);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Employe.CodeEmploye = sdr["CodeEmploye"].ToString();
                    Employe.MatriculeEmploye = sdr["MatriculeEmploye"].ToString();
                    Employe.CodeAppellation = sdr["CodeAppellation"].ToString();
                    Employe.CIN = sdr["Cin"].ToString();
                    Employe.DateCIN = Convert.ToDateTime(sdr["DateCin"]);
                    Employe.Passeport = sdr["Passeport"].ToString();
                    Employe.DatePasseport = Convert.ToDateTime(sdr["DatePasseport"]);
                    Employe.DateEntree = Convert.ToDateTime(sdr["DateEntree"]);
                    Employe.DateSortie = Convert.ToDateTime(sdr["DateSortie"]);
                    Employe.CodeFonction = sdr["CodeFonction"].ToString();
                    Employe.CodeDepartement = sdr["CodeDepartement"].ToString();
                    Employe.SalaireBase = Convert.ToDecimal(sdr["SalaireBase"]);
                    Employe.TauxHoraire = Convert.ToDecimal(sdr["TauxHoraire"]);
                    Employe.CodeGrille = sdr["CodeGrille"].ToString();
                    Employe.CodeSituation = sdr["CodeSituation"].ToString();
                    Employe.DateSituation = Convert.ToDateTime(sdr["DateSituation"]);
                    Employe.ChefFamille = Convert.ToBoolean(sdr["ChefFamille"]);
                    Employe.CongeAnnuel = Convert.ToDecimal(sdr["CongeAnnuel"]);
                    Employe.CongeAnterieur = Convert.ToDecimal(sdr["CongeAnterieur"]);
                    Employe.MatriculeSecuriteSociale = sdr["MatriculeSecuriteSociale"].ToString();
                    Employe.MatriculeAssuranceGroupe = sdr["MatriculeAssuranceGroupe"].ToString();
                    Employe.NumeroPermisConduite = sdr["NumeroPermisConduite"].ToString();
                    Employe.CodeModePaiement = sdr["CodeModePaiement"].ToString();
                    Employe.CodeBanque = sdr["CodeBanque"].ToString();
                    Employe.AgenceBanque = sdr["AgenceBanque"].ToString();
                    Employe.RIB = sdr["Rib"].ToString();
                    Employe.DateNaissance = Convert.ToDateTime(sdr["DateNaissance"]);
                    Employe.LieuNaissance = sdr["LieuNaissance"].ToString();
                    Employe.Adresse = sdr["Adresse"].ToString();
                    Employe.Ville = sdr["Ville"].ToString();
                    Employe.CodePostal = sdr["CodePostal"].ToString();
                    Employe.Telephone1 = sdr["Telephone1"].ToString();
                    Employe.Telephone2 = sdr["Telephone2"].ToString();
                    Employe.AdresseMail = sdr["AdresseMail"].ToString();
                    Employe.Nationalite = sdr["Nationalite"].ToString();
                    Employe.PhotoEmploye = (Byte[])sdr["PhotoEmploye"];
                    Employe.TaillePhoto = (int)sdr["TaillePhoto"];
                    Employe.DateModification = Convert.ToDateTime(sdr["DateModification"]);
                    Employe.CodePlan = sdr["CodePlan"].ToString();
                    Employe.Notes = sdr["Notes"].ToString();
                    Employe.CodeNaturePaiement = sdr["CodeNaturePaiement"].ToString();
                    Employe.TauxJournalier = Convert.ToDecimal(sdr["TauxJournalier"]);
                    Employe.Imposable = Convert.ToBoolean(sdr["Imposable"]);
                    Employe.CotisationSociale = Convert.ToBoolean(sdr["CotisationSociale"]);
                    Employe.AssuranceGroupe = Convert.ToBoolean(sdr["AssuranceGroupe"]);
                    Employe.ImpotLiquidatif = Convert.ToBoolean(sdr["ImpotLiquidatif"]);
                    Employe.Smig = Convert.ToBoolean(sdr["Smig"]);
                    Employe.RedevanceCompensation = Convert.ToBoolean(sdr["RedevanceCompensation"]);
                    Employe.MontantPlafondAssuranceGroupe = Convert.ToDecimal(sdr["MontantPlafondAssuranceGroupe"]);
                    Employe.ImpotAnterieur = Convert.ToDecimal(sdr["ImpotAnterieur"]);
                    Employe.ImposableAnterieur = Convert.ToDecimal(sdr["ImposableAnterieur"]);
                    Employe.AnneeImpotAnterieur = sdr["AnneeImpotAnterieur"].ToString();
                    Employe.Cavis = Convert.ToBoolean(sdr["Cavis"]);
                    Employe.Suffixe = sdr["Suffixe"].ToString();
                    Employe.SituationFamilialle = (int)sdr["SituationFamilialle"];

                }
                con.Close();
            }
            return Employe;
        }

        public void IncrementConnectionPS(string codeEmp, int connection)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_INCREMENT_CONNECTION_EMP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeEmploye", codeEmp);

                cmd.Parameters.AddWithValue("@Connections", connection);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateEmployePS(EMPLOYE Employe)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_Employe", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeEmploye", Employe.CodeEmploye);
                cmd.Parameters.AddWithValue("@MatriculeEmploye", Employe.MatriculeEmploye);
                cmd.Parameters.AddWithValue("@CodeAppellation", Employe.CodeAppellation);
                cmd.Parameters.AddWithValue("@NomEmploye", Employe.NomEmploye);
                cmd.Parameters.AddWithValue("@Cin", Employe.CIN);
                cmd.Parameters.AddWithValue("@DateCin", Employe.DateCIN);
                cmd.Parameters.AddWithValue("@Passeport", Employe.Passeport);
                cmd.Parameters.AddWithValue("@DatePasseport", Employe.DatePasseport);
                cmd.Parameters.AddWithValue("@DateEntree", Employe.DateEntree);
                cmd.Parameters.AddWithValue("@DateSortie", Employe.DateSortie);
                cmd.Parameters.AddWithValue("@CodeFonction", Employe.CodeFonction);
                cmd.Parameters.AddWithValue("@CodeDepartement", Employe.CodeDepartement);
                cmd.Parameters.AddWithValue("@SalaireBase", Employe.SalaireBase);
                cmd.Parameters.AddWithValue("@TauxHoraire", Employe.TauxHoraire);
                cmd.Parameters.AddWithValue("@CodeGrille", Employe.CodeGrille);
                cmd.Parameters.AddWithValue("@CodeSituation", Employe.CodeSituation);
                cmd.Parameters.AddWithValue("@DateSituation", Employe.DateSituation);
                cmd.Parameters.AddWithValue("@ChefFamille", Employe.ChefFamille);
                cmd.Parameters.AddWithValue("@CongeAnnuel", Employe.CongeAnnuel);
                cmd.Parameters.AddWithValue("@CongeAnterieur", Employe.CongeAnterieur);
                cmd.Parameters.AddWithValue("@MatriculeSecuriteSociale", Employe.MatriculeSecuriteSociale);
                cmd.Parameters.AddWithValue("@MatriculeAssuranceGroupe", Employe.MatriculeAssuranceGroupe);
                cmd.Parameters.AddWithValue("@NumeroPermisConduite", Employe.NumeroPermisConduite);
                cmd.Parameters.AddWithValue("@CodeModePaiement", Employe.CodeModePaiement);
                cmd.Parameters.AddWithValue("@CodeBanque", Employe.CodeBanque);
                cmd.Parameters.AddWithValue("@AgenceBanque", Employe.AgenceBanque);
                cmd.Parameters.AddWithValue("@Rib", Employe.RIB);
                cmd.Parameters.AddWithValue("@DateNaissance", Employe.DateNaissance);
                cmd.Parameters.AddWithValue("@LieuNaissance", Employe.LieuNaissance);
                cmd.Parameters.AddWithValue("@Adresse", Employe.Adresse);
                cmd.Parameters.AddWithValue("@Ville", Employe.Ville);
                cmd.Parameters.AddWithValue("@CodePostal", Employe.CodePostal);
                cmd.Parameters.AddWithValue("@Telephone1", Employe.Telephone1);
                cmd.Parameters.AddWithValue("@Telephone2", Employe.Telephone2);
                cmd.Parameters.AddWithValue("@AdresseMail", Employe.AdresseMail);
                cmd.Parameters.AddWithValue("@Nationalite", Employe.Nationalite);
                cmd.Parameters.AddWithValue("@PhotoEmploye", Employe.PhotoEmploye);
                cmd.Parameters.AddWithValue("@TaillePhoto", Employe.TaillePhoto);
                cmd.Parameters.AddWithValue("@CodeOperateur", Employe.CodeOperateur);
                cmd.Parameters.AddWithValue("@DateModification", Employe.DateModification);
                cmd.Parameters.AddWithValue("@CodePlan", Employe.CodePlan);
                cmd.Parameters.AddWithValue("@Notes", Employe.Notes);
                cmd.Parameters.AddWithValue("@CodeNaturePaiement", Employe.CodeNaturePaiement);
                cmd.Parameters.AddWithValue("@TauxJournalier", Employe.TauxJournalier);
                cmd.Parameters.AddWithValue("@Imposable", Employe.Imposable);
                cmd.Parameters.AddWithValue("@CotisationSociale", Employe.CotisationSociale);
                cmd.Parameters.AddWithValue("@AssuranceGroupe", Employe.AssuranceGroupe);
                cmd.Parameters.AddWithValue("@ImpotLiquidatif", Employe.ImpotLiquidatif);
                cmd.Parameters.AddWithValue("@Smig", Employe.Smig);
                cmd.Parameters.AddWithValue("@RedevanceCompensation", Employe.RedevanceCompensation);
                cmd.Parameters.AddWithValue("@MontantPlafondAssuranceGroupe", Employe.MontantPlafondAssuranceGroupe);
                cmd.Parameters.AddWithValue("@ImposableAnterieur", Employe.ImposableAnterieur);
                cmd.Parameters.AddWithValue("@ImpotAnterieur", Employe.ImpotAnterieur);
                cmd.Parameters.AddWithValue("@AnneeImpotAnterieur", Employe.AnneeImpotAnterieur);
                cmd.Parameters.AddWithValue("@Cavis", Employe.Cavis);
                cmd.Parameters.AddWithValue("@Suffixe", Employe.Suffixe);
                cmd.Parameters.AddWithValue("@SituationFamilialle", Employe.SituationFamilialle);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
