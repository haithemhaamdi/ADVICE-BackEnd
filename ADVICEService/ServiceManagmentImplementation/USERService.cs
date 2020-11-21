using ADVICEData;
using ADVICEData.Infrastructure;
using ADVICEDomaine.Entities;
using ADVICEService.Helper;
using ADVICEService.ServiceManagmentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVICEService.ServiceManagmentImplementation
{
    public class USERService : IUSERService
    {
        private readonly ARTIPERSONNEL_SOC001Context _context;
        DatabaseFactory dbFactory = null;
        IUnitOfWork uow = null;

        public USERService(ARTIPERSONNEL_SOC001Context context)
        {
            _context = context;
            dbFactory = new DatabaseFactory();
            uow = new UnitOfWork(dbFactory);
        }

        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<USER> _users = new List<USER>
        {
            new USER { 
                CodeEmploye = "EMP01",
                Login = "Test",
                Connections = 1,
                MacAddress = "0.0.0.0" ,
                Password = "test" ,
                CreateDate = DateTime.Now,
                ModifyDate = DateTime.Now,
                CodeRole="R001",
                Username = "Test",
                FirstName = "Test",
                LastName = "Test"
            }
        };

        //public async Task<USER> Authenticate(string userLogin, string userPassword)
        //{
        //    var user = await Task.Run(() => _users.SingleOrDefault(x => x.Login == userLogin && x.Password == userPassword));

        //    // return null if user not found
        //    if (user == null)
        //        return null;

        //    // authentication successful so return user details without password
        //    return user.WithoutPassword();
        //}

        public USER Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user =  _context.USER.SingleOrDefault(x => x.Username == username);

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // authentication successful
            return user;
        }

        public void Commit()
        {
            //_context.SaveChanges();
            try
            {
                uow.commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public USER Create(USER user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_context.USER.Any(x => x.Username == user.Username))
                throw new AppException("Username \"" + user.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.USER.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void CreateUser(USER User)
        {
            throw new NotImplementedException();
        }

        public void Delete(string code)
        {
            var user = _context.USER.Find(code);
            if (user != null)
            {
                _context.USER.Remove(user);
                _context.SaveChanges();
            }
        }

        public void DeleteUser(USER user)
        {
            var us = _context.USER.Find(user);
            if (user != null)
            {
                _context.USER.Remove(us);
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<IEnumerable<USER>> GetAllUsers()
        {
            return await Task.Run(() => _users.WithoutPasswords());
        }

        public IEnumerable<USER> GetAll()
        {
            return _context.USER;
        }

        public USER GetUserByCode(string code)
        {
            return _context.USER.Find(code);
        }

        public USER GetUserByName(string prenom)
        {
            return _context.USER.Find(prenom);
        }

        public void Update(USER userParam, string password = null)
        {
            var user = _context.USER.Find(userParam.CodeEmploye);

            if (user == null)
                throw new AppException("User not found");

            // update username if it has changed
            if (!string.IsNullOrWhiteSpace(userParam.Username) && userParam.Username != user.Username)
            {
                // throw error if the new username is already taken
                if (_context.USER.Any(x => x.Username == userParam.Username))
                    throw new AppException("Username " + userParam.Username + " is already taken");

                user.Username = userParam.Username;
            }

            // update user properties if provided
            if (!string.IsNullOrWhiteSpace(userParam.FirstName))
                user.FirstName = userParam.FirstName;

            if (!string.IsNullOrWhiteSpace(userParam.LastName))
                user.LastName = userParam.LastName;

            // update password if provided
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _context.USER.Update(user);
            _context.SaveChanges();
        }

        public void UpdateUser(USER User)
        {
            throw new NotImplementedException();
        }

        // private helper methods

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }
}
