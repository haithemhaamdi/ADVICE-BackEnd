using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;
using ADVICEData.Infrastructure;
using ADVICEData.IRepositories;
using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEData.Repositories
{
    public class UserRepository : RepositoryBase<USER>, IUserRepository, IDisposable
    {
        IConfiguration _ConnectionString;


        public UserRepository(ARTIPERSONNEL_SOC001Context repositoryContext, IConfiguration configuration)
    : base(repositoryContext)
        {
            _ConnectionString = configuration;
        }

        public void CreateUser(USER User)
        {
            Add(User);
            Save();
        }

        public async Task CreateUserAsync(USER User)
        {
            Add(User);
            await SaveAsync();
        }

        public async Task DeleteUserAsync(USER User)
        {
            Delete(User);
            await SaveAsync();
        }

        public void DeleteUser(USER User)
        {
            Delete(User);
            Save();
        }

        public IEnumerable<USER> GetAllUsers()
        {
            return GetAll()
                .OrderBy(emp => emp.CodeEmploye);
        }
        public async Task<IEnumerable<USER>> GetAllUsersAsync()
        {
            var Users = await FindAllAsync();
            return Users.OrderBy(x => x.CodeEmploye);
        }
        public USER GetUserByID(string code)
        {
            return FindByCondition(user => user.CodeEmploye.Equals(code))
                    .DefaultIfEmpty(new USER())
                    .FirstOrDefault();
        }
        public async Task<USER> GetUserByIDAsync(string Code)
        {
            var User = await FindByConditionAync(user => user.CodeEmploye.Equals(Code));
            return User.DefaultIfEmpty(new USER())
                    .FirstOrDefault();
        }
        public USER GetUserByName(string Prenom)
        {
            return FindByCondition(user => user.CodeEmploye.Equals(Prenom))
        .DefaultIfEmpty(new USER())
        .FirstOrDefault();
        }
        public async Task UpdateUserAsync(USER User)
        {
            Update(User);
            await SaveAsync();
        }
        public void UpdateUser(USER User)
        {
            Update(User);
            Save();
        }

        public void Dispose()
        {
            RepositoryContext.DisposeAsync();
        }

        public IEnumerable<USER> GetAllWithRefernces()
        {
            return Get(includeProperties: "Employe", includeProperties2:"Role");
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }

    //    private readonly DatabaseFactory connectionFactory;
    //    private readonly  Logger _logger;
    //    //public static IEnumerable<Employe> AllUserByRle(this IRepositoryBaseAsync<Employe> repository)
    //    //{
    //    //    return repository.GetAll();
    //    //}

    //    #region EmployeesByPayslip & HighestPaidEmployeesByRegion
    //    //public static IEnumerable<USER> UsersByRole(this IRepositoryBaseAsync<Role> repository, string CodeUser)
    //    //{
    //    //    return repository.GetById(CodeUser).Users;

    //    //}
    //    //public static IEnumerable<USER> HighestPaidEmployeesByRegion(this IRepositoryBaseAsync<Role> repository, string CodeUser)
    //    //{
    //    //    return repository.UsersByRole(CodeUser)
    //    //        .OrderBy (b => b.CodeUser)
    //    //        .Take(5)
    //    //        .AsEnumerable();
    //    //}
    //    #endregion

    //    #region PS
    //    public async Task<IEnumerable<USER>> GetItemsFromCriteria(User input)
    //    {

    //        List<USER> result = new List<USER>();
    //        using (SqlConnection connection = await connectionFactory.GetSqlConnectionAsync())
    //        using (SqlCommand command = connectionFactory.GetSqlCommand(connection, "dbo.SearchItems"))
    //        {
    //            DatabaseFactory.AddParamToCommand<string>(command, "@COD_TRA", input.Login);
    //            //DatabaseFactory.AddParamToCommand<string>(command, "@Client_TRA", input.Client);
    //            //DatabaseFactory.AddParamToCommand<string>(command, "@FROM_PAYS", input.Departure);
    //            //DatabaseFactory.AddParamToCommand<string>(command, "@FROM_LIEU", input.Departure);
    //            //DatabaseFactory.AddParamToCommand<string>(command, "@TO_PAYS", input.Destination);
    //            //DatabaseFactory.AddParamToCommand<string>(command, "@TO_LIEU", input.Destination);

    //            using (SqlDataReader reader = await command.ExecuteReaderAsync())
    //            {
    //                if (reader.Read())
    //                {
    //                    result.Add(CreateUserDetail(reader));
    //                }
    //            }
    //        }
    //        return result;
    //    }


    //    private  User CreateUserDetail(SqlDataReader reader)
    //    {
    //        return new User()
    //        {

    //            CreateDate = DatabaseFactory.GetValueSafe<DateTime>(reader, "DAT_LIV_CAR")
    //            //,ModifyDate = DatabaseFactory.GetValueSafe<DateTime>(reader, "DAT_DOS_CAR"),
    //            //Password = DatabaseFactory.GetValueSafe<string>(reader, "COD_ART"),
    //            //Connections = DatabaseFactory.GetValueSafe<int>(reader, "NUM_CAR"),
    //            //Login = DatabaseFactory.GetValueSafe<string>(reader, "COD_CDE"),           
    //        };
    //    }
    //    #endregion

    //}

}
