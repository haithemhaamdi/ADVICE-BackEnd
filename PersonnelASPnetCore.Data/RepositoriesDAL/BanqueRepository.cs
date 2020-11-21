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
    public class BanqueRepository : RepositoryBase<BANQUE>, IBanqueRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;

        public BanqueRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
            : base(repositoryContext)
        {
            _ConnectionString = configuration;
        }
        #endregion

        public async Task CreateBanquePSAsync(BANQUE Banque)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CREATE_BANQUE", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeBanque", Banque.CodeBanque);
                cmd.Parameters.AddWithValue("@LibelleBanque", Banque.LibelleBanque);
                cmd.Parameters.AddWithValue("@BulletinPaies", Banque.BULLETIN_PAIE);

                connection.Open();
                await cmd.ExecuteNonQueryAsync();
                connection.Close();
            }
        }

        public void DeleteBanquePS(string codeBanque)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_DELETE_BANQUE", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeBanque", codeBanque);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<BANQUE> GetAllBanquesPS()
        {
            List< BANQUE> lstBanques = new List<BANQUE>();
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BANQUE", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BANQUE banque = new BANQUE();

                    banque.CodeBanque = sdr["CodeBanque"].ToString();
                    banque.LibelleBanque = sdr["LibelleBanque"].ToString();
                    lstBanques.Add(banque);
                }
                connection.Close();
            }
            return lstBanques;
        }

        public async Task<BANQUE> GetBanqueByCodeAsync(string codeBanque)
        {
            var Banque = await FindByConditionAync(b => b.CodeBanque.Equals(codeBanque));

            return Banque.DefaultIfEmpty(new BANQUE())
                    .FirstOrDefault();
        }

        public BANQUE GetBanqueDetailsPS(string codeBanque)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            BANQUE Banque = new BANQUE();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_BANQUEByCODE", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeBanque", codeBanque);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Banque.CodeBanque = sdr["CodeBanque"].ToString();
                    Banque.LibelleBanque = sdr["LibelleBanque"].ToString();                  
                }
            }
            return Banque;
        }

        public BANQUE GetBanquesPSbyCode(string codeBanque)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            BANQUE Banque = new BANQUE();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_BANQUEbyCode", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeBanque", codeBanque);

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Banque.CodeBanque = sdr["CodeBanque"].ToString();
                    Banque.LibelleBanque = sdr["LibelleBanque"].ToString();
                }
                connection.Close();
            }
            return Banque;
        }

        public void UpdateBanquePS(BANQUE Banque)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_BANQUE", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeBanque", Banque.CodeBanque);
                cmd.Parameters.AddWithValue("@LibelleBanque", Banque.LibelleBanque);
               
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
