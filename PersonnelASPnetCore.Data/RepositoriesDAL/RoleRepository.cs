using Microsoft.Extensions.Configuration;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class RoleRepository : IRoleRepository
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;
        protected ARTIPERSONNEL_SOC001Context _repositoryContext { get; set; }

        public RoleRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _ConnectionString = configuration;
        }
        #endregion
        public IEnumerable<ROLE> GetAllRolesPS()
        {
            List<ROLE> lstRoles = new List<ROLE>();
            //List<USER> lstUsers = new List<USER>();

            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ROLE role = new ROLE();
                    //USER user = new USER();

                    role.CodeRole = sdr["CodeRole"].ToString();
                    role.Name = sdr["Name"].ToString();
                    //role.USER = sdr[]
                    //user.CodeEmploye = sdr["CodeEmploye"].ToString();

                    lstRoles.Add(role);
                    //lstUsers.Add(user);
                }
                con.Close();
            }
            return lstRoles;
        }

        public async Task<ROLE> GetRoleByUserCodePS(string codeEmploye)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            ROLE role = new ROLE();

            await using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_USER_ROLE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmploye", codeEmploye);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {

                    while (sdr.Read())
                    {
                        role.Name = sdr["Name"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
            return role;
        }
    }
}
