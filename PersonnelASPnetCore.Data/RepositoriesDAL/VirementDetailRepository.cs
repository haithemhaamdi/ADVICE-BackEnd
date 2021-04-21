using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
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
    public class VirementDetailRepository<T> : IVirementDetailRepository<T> where T : class
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

        public VirementDetailRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext, IOptions<AppSettings> appSettings)
        {
            _repositoryContext = repositoryContext;
            _ConnectionString = configuration;
            _appSettings = appSettings.Value;
        }
        #endregion

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
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

        public Task<IEnumerable<T>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindALLByConditionAync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
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

        public Task<T> FindByName(string name)
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

        public IEnumerable<T> GetAll()
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

        public IEnumerable<VIREMENT_DETAIL> GetAllVIREMENT_DETAILsPS()
        {
            List<VIREMENT_DETAIL> lstVirementDetails = new List<VIREMENT_DETAIL>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_VIREMENT_DETAILS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    VIREMENT_DETAIL VirementDetail = new VIREMENT_DETAIL();

                    VirementDetail.NumeroVirement = sdr["NumeroVirement"].ToString();
                    VirementDetail.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    VirementDetail.CodePeriode = sdr["CodePeriode"].ToString();
                    VirementDetail.CodeEmploye = sdr["CodeEmploye"].ToString();
                    VirementDetail.NomEmploye = sdr["NomEmploye"].ToString();
                    VirementDetail.CodeBanque = sdr["CodeBanque"].ToString();
                    VirementDetail.AgenceBanque = sdr["AgenceBanque"].ToString();
                    VirementDetail.RIB = sdr["RIB"].ToString();
                    VirementDetail.Montant = Convert.ToDecimal(sdr["Montant"]);

                    lstVirementDetails.Add(VirementDetail);
                }
                connection.Close();
            }
            return lstVirementDetails;
        }

        public async Task<IEnumerable<VIREMENT_DETAIL>> GetAllVIREMENT_DETAILsPSAsync()
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            List<VIREMENT_DETAIL> lstVirementDetailsAsync = new List<VIREMENT_DETAIL>();

            await using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_VIREMENT_DETAILS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    VIREMENT_DETAIL VirementDetailAsync = new VIREMENT_DETAIL();

                    VirementDetailAsync.NumeroVirement = sdr["NumeroVirement"].ToString();
                    VirementDetailAsync.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                    VirementDetailAsync.CodePeriode = sdr["CodePeriode"].ToString();
                    VirementDetailAsync.CodeEmploye = sdr["CodeEmploye"].ToString();
                    VirementDetailAsync.NomEmploye = sdr["NomEmploye"].ToString();
                    VirementDetailAsync.CodeBanque = sdr["CodeBanque"].ToString();
                    VirementDetailAsync.AgenceBanque = sdr["AgenceBanque"].ToString();
                    VirementDetailAsync.RIB = sdr["RIB"].ToString();
                    VirementDetailAsync.Montant = Convert.ToDecimal(sdr["Montant"]);

                    lstVirementDetailsAsync.Add(VirementDetailAsync);
                }
                connection.Close();
            }
            return lstVirementDetailsAsync;
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public async Task<VIREMENT_DETAIL> GetVIREMENT_DETAILsPSbyNumeroBulletin(string NumeroBulletin)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            VIREMENT_DETAIL VirementDetail = new VIREMENT_DETAIL();

            await using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_VIREMENT_DETAILbyNumeroBulletin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroBulletin", NumeroBulletin);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {

                    while (sdr.Read())
                    {
                        VirementDetail.NumeroVirement = sdr["NumeroVirement"].ToString();
                        VirementDetail.NumeroBulletin = sdr["NumeroBulletin"].ToString();
                        VirementDetail.CodePeriode = sdr["CodePeriode"].ToString();
                        VirementDetail.CodeEmploye = sdr["CodeEmploye"].ToString();
                        VirementDetail.NomEmploye = sdr["NomEmploye"].ToString();
                        VirementDetail.CodeBanque = sdr["CodeBanque"].ToString();
                        VirementDetail.AgenceBanque = sdr["AgenceBanque"].ToString();
                        VirementDetail.RIB = sdr["RIB"].ToString();
                        VirementDetail.Montant = Convert.ToDecimal(sdr["Montant"]);

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
            return VirementDetail;
        }

        public void Save()
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

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}