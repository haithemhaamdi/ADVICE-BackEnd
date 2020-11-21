
using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositories
{
    public interface IUserRepository
    {
        void CreateUser(USER User);
        Task CreateUserAsync(USER User);
        USER GetUserByID(string code);
        USER GetUserByName(string Prenom);
        IEnumerable<USER> GetAllUsers();
        // Chargement hâtif
        IEnumerable<USER> GetAllWithRefernces();
        Task<IEnumerable<USER>> GetAllUsersAsync();
        Task<USER> GetUserByIDAsync(string Code);
        void UpdateUser(USER User);
        Task UpdateUserAsync(USER User);
        void DeleteUser(USER User);
        Task DeleteUserAsync(USER User);
        Task SaveAsync();
        void Save();
        void Commit();
        Task CommitAsync();
        void Dispose();
    }
}
