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
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class ConnectionHistoryRepository<T> : IConnectionHistoryRepository<T> where T : class
    {
        #region Configuration ConnectionString + DI
        //put your connection string here
        IConfiguration _ConnectionString;
        private readonly AppSettings _appSettings;
        protected ARTIPERSONNEL_SOC001Context _repositoryContext { get; set; }

        public ConnectionHistoryRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext, IOptions<AppSettings> appSettings)
        {
            _repositoryContext = repositoryContext;
            _ConnectionString = configuration;
            _appSettings = appSettings.Value;
        }
        #endregion

        public async Task ConnectionHistoryPSAsync(CONNECTIONS_HISTORY cONNECTIONS_HISTORY)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CONNECTIONS_HISTORY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@Id", cONNECTIONS_HISTORY.Id);
                    cmd.Parameters.AddWithValue("@CodeEmploye", cONNECTIONS_HISTORY.CodeEmploye);
                    cmd.Parameters.AddWithValue("@Username", cONNECTIONS_HISTORY.Username);
                    cmd.Parameters.AddWithValue("@FirstName", cONNECTIONS_HISTORY.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", cONNECTIONS_HISTORY.LastName);
                    cmd.Parameters.AddWithValue("@Role", cONNECTIONS_HISTORY.Role);
                    cmd.Parameters.AddWithValue("@Connections", cONNECTIONS_HISTORY.Connections);
                    cmd.Parameters.AddWithValue("@SignInDate", cONNECTIONS_HISTORY.SignInDate);
                    cmd.Parameters.AddWithValue("@SignOutDate", cONNECTIONS_HISTORY.SignOutDate);
                    cmd.Parameters.AddWithValue("@Hostname", cONNECTIONS_HISTORY.Hostname);
                    cmd.Parameters.AddWithValue("@MacAddress", cONNECTIONS_HISTORY.MacAddress);
                    cmd.Parameters.AddWithValue("@IpAddress", cONNECTIONS_HISTORY.IpAddress);

                    con.Open();
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
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

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _repositoryContext.SaveChangesAsync();
            return entity;
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
    }
}
