using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.USER_Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.IRepositoriesDAL
{
    public interface IUserRepository<T> where T : class
    {
        //USER Authenticate(string username, string password, string ipAddress);
        AuthenticateResponseDto Authenticate(string username, string password, string ipAddress, string message, bool isAuthenticated, bool isDisconnected, bool flag);
        AuthenticateResponseDto RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<USER> GetAllUsersPS();
        void IncrementConnectionPS(string codeEmploye, int connection);
        Task CreateUserPSAsync(USER User, string password);
        void UpdateUserPS(USER User, string password = null);
        void UpdateUserTokenPS(USER User, string codeEmploye, string token);
        USER GetUserDetailsPS(string codeEmploye);
        Task<USER> GetUserPSbyID(string codeEmploye);
        void DeleteUserPS(string codeEmploye);
        Tuple<List<USER>, List<EMPLOYE>, List<ROLE>> GetAllUsersRefEmplRefRolePS();
        Task<T> SaveAsync(T entity);
        void ChecKActiveToken(bool RevokeAll);
        Task<USER> GetUserWithTokenReferences(string username);
        string GetActiveRefreshToken(string username, bool isActive);
        void Commit();
        void Dispose();
    }
}
