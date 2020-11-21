using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    //public interface IRoleRepository<T> where T : class
    public interface IRoleRepository
    {
        IEnumerable<ROLE> GetAllRolesPS();
        Task<ROLE> GetRoleByUserCodePS(string codeEmploye);

        //void IncrementConnectionPS(string codeEmploye, int connection);
        //Task CreateUserPSAsync(User User);
        //void UpdateUserPS(User User);
        //User GetUserDetailsPS(string codeEmploye);
        //Task<USER> GetUserPSbyID(string codeEmploye);
        //void DeleteUserPS(string codeEmploye);

        //Task<T> SaveAsync(T entity);
    }
}
