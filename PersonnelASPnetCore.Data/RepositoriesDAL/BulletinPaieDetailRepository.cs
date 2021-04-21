using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PersonnelASPnetCore.Data.Infrastructure;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class BulletinPaieDetailRepository<T> : IBulletinPaieDetailRepository<T> where T : class

    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        /// <summary>
        /// Utilisé pour générer des paramètres de configuration basés sur des clés/valeurs 
        /// à utiliser dans une application.
        /// </summary>
        IConfiguration _ConnectionString;
        private readonly AppSettings _appSettings;
        protected ARTIPERSONNEL_SOC001Context _repositoryContext { get; set; }

        public BulletinPaieDetailRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext, IOptions<AppSettings> appSettings)
        {
            _repositoryContext = repositoryContext;
            _ConnectionString = configuration;
            _appSettings = appSettings.Value;
        }
        #endregion

        public IEnumerable<BULLETIN_PAIE_DETAIL> GetAllBulletinPaieDetailsPS()
        {
            List<BULLETIN_PAIE_DETAIL> lstBulletinsPaieDetails = new List<BULLETIN_PAIE_DETAIL>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BULLETINS_PAIE_DETAILS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BULLETIN_PAIE_DETAIL BulletinPaieDetail = new BULLETIN_PAIE_DETAIL();

                    BulletinPaieDetail.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    BulletinPaieDetail.BasePonderation = Convert.ToDecimal(sdr["BasePonderation"]);
                    BulletinPaieDetail.InclureImpot = Convert.ToBoolean(sdr["InclureImpot"]);
                    BulletinPaieDetail.InclureAssuranceGroupe = Convert.ToBoolean(sdr["InclureAssuranceGroupe"]);
                    BulletinPaieDetail.InclureIndemniteConge = Convert.ToBoolean(sdr["InclureIndemniteConge"]);
                    BulletinPaieDetail.InclureSecuriteSociale = Convert.ToBoolean(sdr["InclureSecuriteSociale"]);
                    BulletinPaieDetail.CodeTypeIndemnite = sdr["CodeTypeIndemnite"].ToString();
                    BulletinPaieDetail.IndemniteActive = Convert.ToBoolean(sdr["IndemniteActive"]);
                    BulletinPaieDetail.RubriqueParDefaut = Convert.ToBoolean(sdr["RubriqueParDefaut"]);
                    BulletinPaieDetail.CodeRubrique = sdr["CodeRubrique"].ToString();
                    BulletinPaieDetail.CodeSecondaire = sdr["CodeSecondaire"].ToString();
                    BulletinPaieDetail.LibelleRubrique = sdr["LibelleRubrique"].ToString();
                    BulletinPaieDetail.CodeTypeRubrique = sdr["CodeTypeRubrique"].ToString();
                    BulletinPaieDetail.LibelleTypeRubrique = sdr["LibelleTypeRubrique"].ToString();
                    BulletinPaieDetail.Montant = Convert.ToDecimal(sdr["Montant"]);
                    BulletinPaieDetail.MontantBase = Convert.ToDecimal(sdr["MontantBase"]);
                    BulletinPaieDetail.MontantIndemnite = Convert.ToDecimal(sdr["MontantIndemnite"]);
                    BulletinPaieDetail.MontantPlafondMaximum = Convert.ToDecimal(sdr["MontantPlafondMaximum"]);
                    BulletinPaieDetail.MontantPlafondMinimum = Convert.ToDecimal(sdr["MontantPlafondMinimum"]);
                    BulletinPaieDetail.MontantRubrique = Convert.ToDecimal(sdr["MontantRubrique"]);
                    BulletinPaieDetail.Nombre = (float)sdr["Nombre"];
                    BulletinPaieDetail.Taux = Convert.ToDecimal(sdr["Taux"]);
                    BulletinPaieDetail.Valeur = Convert.ToDecimal(sdr["Valeur"]);
                    BulletinPaieDetail.Actif = Convert.ToBoolean(sdr["Actif"]);


                    lstBulletinsPaieDetails.Add(BulletinPaieDetail);
                }
                connection.Close();
            }
            return lstBulletinsPaieDetails;
        }

        public async Task<IEnumerable<BULLETIN_PAIE_DETAIL>> GetAllBulletinPaieDetailsPSAsync()
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            List<BULLETIN_PAIE_DETAIL> lstBulletinsPaieDetailsAsync = new List<BULLETIN_PAIE_DETAIL>();

            await using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BULLETINS_PAIE_DETAILS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BULLETIN_PAIE_DETAIL BulletinPaieDetailAsync = new BULLETIN_PAIE_DETAIL();

                    BulletinPaieDetailAsync.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    BulletinPaieDetailAsync.CodeRubrique = sdr["CodeRubrique"].ToString();
                    BulletinPaieDetailAsync.CodeTypeRubrique = sdr["CodeTypeRubrique"].ToString();
                    BulletinPaieDetailAsync.CodeSecondaire = sdr["CodeSecondaire"].ToString();
                    BulletinPaieDetailAsync.MontantBase = Convert.ToDecimal(sdr["MontantBase"]);
                    BulletinPaieDetailAsync.Taux = Convert.ToDecimal(sdr["Taux"]);
                    BulletinPaieDetailAsync.Nombre = (float)sdr["Nombre"];
                    BulletinPaieDetailAsync.Valeur = Convert.ToDecimal(sdr["Valeur"]);
                    BulletinPaieDetailAsync.Montant = Convert.ToDecimal(sdr["Montant"]);
                    BulletinPaieDetailAsync.LibelleRubrique = sdr["LibelleRubrique"].ToString();
                    BulletinPaieDetailAsync.LibelleTypeRubrique = sdr["LibelleTypeRubrique"].ToString();
                    BulletinPaieDetailAsync.InclureAssuranceGroupe = Convert.ToBoolean(sdr["InclureAssuranceGroupe"]);
                    BulletinPaieDetailAsync.InclureSecuriteSociale = Convert.ToBoolean(sdr["InclureSecuriteSociale"]);
                    BulletinPaieDetailAsync.InclureImpot = Convert.ToBoolean(sdr["InclureImpot"]);
                    BulletinPaieDetailAsync.IndemniteActive = Convert.ToBoolean(sdr["IndemniteActive"]);
                    BulletinPaieDetailAsync.InclureIndemniteConge = Convert.ToBoolean(sdr["InclureIndemniteConge"]);
                    BulletinPaieDetailAsync.CodeTypeIndemnite = sdr["CodeTypeIndemnite"].ToString();
                    BulletinPaieDetailAsync.MontantIndemnite = Convert.ToDecimal(sdr["MontantIndemnite"]);
                    BulletinPaieDetailAsync.BasePonderation = Convert.ToDecimal(sdr["BasePonderation"]);
                    BulletinPaieDetailAsync.RubriqueParDefaut = Convert.ToBoolean(sdr["RubriqueParDefaut"]);
                    BulletinPaieDetailAsync.Actif = Convert.ToBoolean(sdr["Actif"]);
                    BulletinPaieDetailAsync.MontantRubrique = Convert.ToDecimal(sdr["MontantRubrique"]);
                    BulletinPaieDetailAsync.MontantPlafondMaximum = Convert.ToDecimal(sdr["MontantPlafondMaximum"]);
                    BulletinPaieDetailAsync.MontantPlafondMinimum = Convert.ToDecimal(sdr["MontantPlafondMinimum"]);

                    lstBulletinsPaieDetailsAsync.Add(BulletinPaieDetailAsync);
                }
                connection.Close();
            }
            return lstBulletinsPaieDetailsAsync;
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindALLByConditionAync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsynchrone()
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", string includeProperties2 = "", string includeProperties3 = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BULLETIN_PAIE_DETAIL> GetALLBulletinPaieDetailPSbyNumeroBulletin(string NumeroBulletin)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            List<BULLETIN_PAIE_DETAIL> LstBulletinPaieDetail = new List<BULLETIN_PAIE_DETAIL>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BULLETIN_PAIE_DETAILbyNumeroBulletin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroBulletin", NumeroBulletin);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {

                    while (sdr.Read())
                    {
                        BULLETIN_PAIE_DETAIL BulletinPaieDetails = new BULLETIN_PAIE_DETAIL();

                        BulletinPaieDetails.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                        BulletinPaieDetails.CodeRubrique = sdr["CodeRubrique"].ToString();
                        BulletinPaieDetails.CodeTypeRubrique = sdr["CodeTypeRubrique"].ToString();
                        BulletinPaieDetails.CodeSecondaire = sdr["CodeSecondaire"].ToString();
                        BulletinPaieDetails.MontantBase = Convert.ToDecimal(sdr["MontantBase"]);
                        BulletinPaieDetails.Taux = Convert.ToDecimal(sdr["Taux"]);
                        BulletinPaieDetails.Nombre = (float)sdr["Nombre"];
                        BulletinPaieDetails.Valeur = Convert.ToDecimal(sdr["Valeur"]);
                        BulletinPaieDetails.Montant = Convert.ToDecimal(sdr["Montant"]);
                        BulletinPaieDetails.LibelleRubrique = sdr["LibelleRubrique"].ToString();
                        BulletinPaieDetails.LibelleTypeRubrique = sdr["LibelleTypeRubrique"].ToString();
                        BulletinPaieDetails.InclureAssuranceGroupe = Convert.ToBoolean(sdr["InclureAssuranceGroupe"]);
                        BulletinPaieDetails.InclureSecuriteSociale = Convert.ToBoolean(sdr["InclureSecuriteSociale"]);
                        BulletinPaieDetails.InclureImpot = Convert.ToBoolean(sdr["InclureImpot"]);
                        BulletinPaieDetails.IndemniteActive = Convert.ToBoolean(sdr["IndemniteActive"]);
                        BulletinPaieDetails.InclureIndemniteConge = Convert.ToBoolean(sdr["InclureIndemniteConge"]);
                        BulletinPaieDetails.CodeTypeIndemnite = sdr["CodeTypeIndemnite"].ToString();
                        BulletinPaieDetails.MontantIndemnite = Convert.ToDecimal(sdr["MontantIndemnite"]);
                        BulletinPaieDetails.BasePonderation = Convert.ToDecimal(sdr["BasePonderation"]);
                        BulletinPaieDetails.RubriqueParDefaut = Convert.ToBoolean(sdr["RubriqueParDefaut"]);
                        BulletinPaieDetails.Actif = Convert.ToBoolean(sdr["Actif"]);
                        BulletinPaieDetails.MontantRubrique = Convert.ToDecimal(sdr["MontantRubrique"]);
                        BulletinPaieDetails.MontantPlafondMaximum = Convert.ToDecimal(sdr["MontantPlafondMaximum"]);
                        BulletinPaieDetails.MontantPlafondMinimum = Convert.ToDecimal(sdr["MontantPlafondMinimum"]);

                        LstBulletinPaieDetail.Add(BulletinPaieDetails);


                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
            return LstBulletinPaieDetail;
        }
    }
}