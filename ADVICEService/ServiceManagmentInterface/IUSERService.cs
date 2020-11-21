using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEService.ServiceManagmentInterface
{
    public interface IUSERService
    {
        USER Authenticate(string userLogin, string userPassword);
        void CreateUser(USER User);
        USER Create(USER user, string password);
        USER GetUserByCode(string code);
        USER GetUserByName(string prenom);
        Task<IEnumerable<USER>> GetAllUsers();
        IEnumerable<USER> GetAll();
        void UpdateUser(USER User);
        void Update(USER user, string password = null);
        void DeleteUser(USER User);
        void Delete(string code);
        void Commit();
        void Dispose();        
    

    }
}
