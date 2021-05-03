using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PersonnelASPnetCore.Data.Helper;
using PersonnelASPnetCore.Data.IRepositoriesDAL;
using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.CONNECTIONS_HISTORY_Dto;
using PersonnelASPnetCore.Dto.USER_Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelASPnetCore.Data.RepositoriesDAL
{
    public class UserRepository<T> : IUserRepository<T> where T : class
    {

        #region CONFIGURATION
        //put your connection string here
        private readonly AppSettings _appSettings;
        IConfiguration _ConnectionString;
        protected ARTIPERSONNEL_SOC001Context _repositoryContext { get; set; }
        public UserRepository(IConfiguration configuration, ARTIPERSONNEL_SOC001Context repositoryContext, IOptions<AppSettings> appSettings)
        {
            _repositoryContext = repositoryContext;
            _ConnectionString = configuration;
            _appSettings = appSettings.Value;
        }
        #endregion

        #region PS CRUD OPERATION
        //To View all User details ( USER + EMPLOYE + ROLE )    
        public Tuple<List<USER>, List<EMPLOYE>, List<ROLE>> GetAllUsersRefEmplRefRolePS()
        {
            List<USER> lstUsers = new List<USER>();
            List<ROLE> lstRole = new List<ROLE>();
            List<EMPLOYE> lstEmploye = new List<EMPLOYE>();

            //var allRecord = new List<Tuple<IEnumerable<USER>, IEnumerable<EMPLOYE>, IEnumerable<ROLE>>>();

            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    USER User = new USER();

                    User.CodeEmploye = sdr["CodeEmploye"].ToString();
                    User.Login = sdr["Login"].ToString();
                    User.Password = sdr["Password"].ToString();
                    User.MacAddress = sdr["MacAddress"].ToString();
                    User.Status = Convert.ToBoolean(sdr["Status"]);
                    User.ModifyDate = Convert.ToDateTime(sdr["ModifyDate"]);
                    User.CreateDate = Convert.ToDateTime(sdr["CreateDate"]);
                    User.Connections = Convert.ToInt32(sdr["Connections"]);
                    User.CodeRole = sdr["CodeRole"].ToString();
                    User.Picture_URL = sdr["Picture_URL"].ToString();
                    //Authentification status
                    User.IsDisconnected = Convert.ToBoolean(sdr["IsDisconnected"]);
                    User.IsAuthenticated = Convert.ToBoolean(sdr["IsAuthenticated"]);

                    //User.CodeRoleNavigation.Name = sdr["Name"].ToString();
                    //User.CodeEmployeNavigation.NomEmploye = sdr["NomEmploye"].ToString();

                    lstUsers.Add(User);
                }
                sdr.NextResult();
                while (sdr.Read())
                {
                    EMPLOYE Employe = new EMPLOYE();
                    Employe.NomEmploye = sdr["NomEmploye"].ToString();
                    lstEmploye.Add(Employe);
                }
                sdr.NextResult();
                while (sdr.Read())
                {
                    ROLE Role = new ROLE();
                    Role.Name = sdr["Name"].ToString();
                    lstRole.Add(Role);
                }
                con.Close();
            }
            return Tuple.Create(lstUsers, lstEmploye, lstRole);

            //return allRecord(lstUsers,lstRole, lstEmploye);
        }
        //To View all User details      
        public IEnumerable<USER> GetAllUsersPS()
        {
            List<USER> lstUsers = new List<USER>();

            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    USER User = new USER();
                    User.Login = sdr["Login"].ToString();
                    User.Password = sdr["Password"].ToString();
                    User.MacAddress = sdr["MacAddress"].ToString();
                    User.IpAddress = sdr["IpAddress"].ToString();
                    User.Status = Convert.ToBoolean(sdr["Status"]);
                    User.ModifyDate = Convert.ToDateTime(sdr["ModifyDate"]);
                    User.CreateDate = Convert.ToDateTime(sdr["CreateDate"]);
                    User.Connections = Convert.ToInt32(sdr["Connections"]);
                    User.CodeRole = sdr["CodeRole"].ToString();
                    User.Picture_URL = sdr["Picture_URL"].ToString();
                    User.CodeEmploye = sdr["CodeEmploye"].ToString();
                    User.FirstName = sdr["FirstName"].ToString();
                    User.LastName = sdr["LastName"].ToString();
                    User.Username = sdr["Username"].ToString();
                    User.AuthData = sdr["AuthData"].ToString();
                    //Authentification status
                    User.IsDisconnected = Convert.ToBoolean(sdr["IsDisconnected"]);
                    User.IsAuthenticated = Convert.ToBoolean(sdr["IsAuthenticated"]);

                    lstUsers.Add(User);
                }
                con.Close();
            }
            return lstUsers;
        }
        //To Add new User record      
        public async Task CreateUserPSAsync(USER User, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_repositoryContext.USER.Any(x => x.Username == User.Username))
                throw new AppException("Username \"" + User.Username + "\" is already taken");

            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            User.Password = Helper.Helper.base64Encode(User.Password);

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            User.PasswordHash = passwordHash;
            User.PasswordSalt = passwordSalt;

            User.Login = User.Username;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CREATE_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@CodeUser", User.CodeEmploye);
                    cmd.Parameters.AddWithValue("@Username", User.Username);
                    cmd.Parameters.AddWithValue("@FirstName", User.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", User.LastName);
                    cmd.Parameters.AddWithValue("@PasswordHash", User.PasswordHash);
                    cmd.Parameters.AddWithValue("@PasswordSalt", User.PasswordSalt);
                    cmd.Parameters.AddWithValue("@Login", User.Login);
                    cmd.Parameters.AddWithValue("@Password", User.Password);
                    cmd.Parameters.AddWithValue("@AdresseMail", User.AdresseMail);
                    cmd.Parameters.AddWithValue("@Connections", 0);
                    cmd.Parameters.AddWithValue("@MacAddress", User.MacAddress);
                    cmd.Parameters.AddWithValue("@CreateDate", User.CreateDate);
                    cmd.Parameters.AddWithValue("@ModifyDate", User.ModifyDate);
                    cmd.Parameters.AddWithValue("@Status", User.Status);
                    //cmd.Parameters.AddWithValue("@Picture", User.Picture);
                    cmd.Parameters.AddWithValue("@Picture_URL", User.Picture_URL);
                    cmd.Parameters.AddWithValue("@CodeRole", User.CodeRole);
                    cmd.Parameters.AddWithValue("@IpAddress", User.IpAddress);
                    //Authentification status
                    cmd.Parameters.AddWithValue("@IsDisconnected", User.IsDisconnected);
                    cmd.Parameters.AddWithValue("@IsAuthenticated", User.IsAuthenticated);

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

        public void UpdateUserTokenPS(USER User, string codeEmploye, string token)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            DateTime date = DateTime.Now;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_USER_TOKEN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeUser", codeEmploye);
                cmd.Parameters.AddWithValue("@Token", token);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
        }


        //To Update the records of a particluar User    
        public void UpdateUserPS(USER User, string password = null)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            DateTime date = DateTime.Now;
            //var pwd = Helper.Helper.base64Encode(User.Password);
            //User.Password = pwd;

            //byte[] passwordHash, passwordSalt;
            //CreatePasswordHash(password, out passwordHash, out passwordSalt);

            //User.PasswordHash = passwordHash;
            //User.PasswordSalt = passwordSalt;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_UPDATE_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeUser", User.CodeEmploye);
                //cmd.Parameters.AddWithValue("@Login", User.Login);
                cmd.Parameters.AddWithValue("@FirstName", User.FirstName);
                cmd.Parameters.AddWithValue("@LastName", User.LastName);
                cmd.Parameters.AddWithValue("@Username", User.Username);
                //cmd.Parameters.AddWithValue("@Password", User.Password);
                //cmd.Parameters.AddWithValue("@PasswordHash", User.PasswordHash);
                //cmd.Parameters.AddWithValue("@PasswordSalt", User.PasswordSalt);
                cmd.Parameters.AddWithValue("@MacAddress", User.MacAddress);
                cmd.Parameters.AddWithValue("@ModifyDate", User.ModifyDate);
                cmd.Parameters.AddWithValue("@Status", User.Status);
                cmd.Parameters.AddWithValue("@Picture", User.Picture);
                cmd.Parameters.AddWithValue("@Picture_URL", User.Picture_URL);
                cmd.Parameters.AddWithValue("@CodeRole", User.CodeRole);
                //Authentification status
                cmd.Parameters.AddWithValue("@IsDisconnected", User.IsDisconnected);
                cmd.Parameters.AddWithValue("@IsAuthenticated", User.IsAuthenticated);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
        }
        //Get the details of a particular User    
        public USER GetUserDetailsPS(string codeEmploye)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            USER User = new USER();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_USERByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeUser", codeEmploye);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    //User.CodeUser = sdr["CodeUser"].ToString();
                    User.Login = sdr["Login"].ToString();
                    User.Password = sdr["Password"].ToString();
                    User.MacAddress = sdr["MacAddress"].ToString();
                    User.Status = Convert.ToBoolean(sdr["Status"]);
                    User.ModifyDate = Convert.ToDateTime(sdr["ModifyDate"]);
                    User.CreateDate = Convert.ToDateTime(sdr["CreateDate"]);
                    User.Connections = Convert.ToInt32(sdr["Connections"]);
                    User.CodeRole = sdr["CodeRole"].ToString();
                    User.Picture_URL = sdr["Picture_URL"].ToString();
                    User.CodeEmploye = sdr["CodeEmploye"].ToString();
                    //Authentification status
                    User.IsDisconnected = Convert.ToBoolean(sdr["IsDisconnected"]);
                    User.IsAuthenticated = Convert.ToBoolean(sdr["IsAuthenticated"]);
                }
            }
            return User;
        }
        //To Delete the record on a particular User    
        public void DeleteUserPS(string codeEmploye)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_DELETE_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeUser", codeEmploye);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void IncrementConnectionPS(string codeEmploye, int connection)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            USER User = new USER();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_INCREMENT_CONNECTION_USER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodeUser", codeEmploye);

                cmd.Parameters.AddWithValue("@Connections", connection);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public async Task<USER> GetUserPSbyID(string codeEmploye)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            USER User = new USER();

            await using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_SELECT_USERbyCode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeUser", codeEmploye);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {

                    while (sdr.Read())
                    {
                        User.CodeEmploye = sdr["CodeEmploye"].ToString();
                        User.Login = sdr["Login"].ToString();
                        User.Username = sdr["Username"].ToString();
                        User.FirstName = sdr["FirstName"].ToString();
                        User.LastName = sdr["LastName"].ToString();
                        User.AdresseMail = sdr["AdresseMail"].ToString();
                        User.MacAddress = sdr["MacAddress"].ToString();
                        User.Status = Convert.ToBoolean(sdr["Status"]);
                        User.Picture_URL = sdr["Picture_URL"].ToString();
                        User.ModifyDate = Convert.ToDateTime(sdr["ModifyDate"]);
                        User.CreateDate = Convert.ToDateTime(sdr["CreateDate"]);
                        User.Connections = Convert.ToInt32(sdr["Connections"]);
                        User.CodeRole = sdr["CodeRole"].ToString();
                        User.AuthData = sdr["AuthData"].ToString();
                        //Authentification status
                        User.IsDisconnected = Convert.ToBoolean(sdr["IsDisconnected"]);
                        User.IsAuthenticated = Convert.ToBoolean(sdr["IsAuthenticated"]);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
            return User;
        }
        public async Task<T> SaveAsync(T entity)
        {
            await _repositoryContext.SaveChangesAsync();
            return entity;
        }
        public void Commit()
        {
            _repositoryContext.SaveChanges();
        }
        public void Dispose()
        {
            _repositoryContext.Dispose();
        }
        #endregion

        #region PRIVATE HELPER METHODS

        public AuthenticateResponseDto Authenticate(
            string username, string password,
            string ipAddress, string message, bool isAuthenticated, bool isDisconnected ,bool flag)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            var user = _repositoryContext.USER.SingleOrDefault(x => x.Username == username);
            // check if username exists
            if (user == null)
            {
                isAuthenticated = false;
                isDisconnected = true;
                message = $"No Accounts Registered with {username}.";
                return new AuthenticateResponseDto(null, "", "", new DateTime(), message, false, true, true);                
            }
            // check if password is correct
            if (!VerifyPasswordHash(Helper.Helper.base64Decode(password), user.PasswordHash, user.PasswordSalt)) {
                message = $"Password is incorrect";
                return new AuthenticateResponseDto(null, "", "", new DateTime(), message, false, true,true);
            }
            isAuthenticated = true;
            isDisconnected = false;
            message = $"Authenticate Successfully with {username}.";

            user.IsAuthenticated = isAuthenticated;
            user.IsDisconnected = isDisconnected;

            // authentication successful so generate jwt and refresh tokens

            //var jwtToken = generateJwtToken(user);
            var refreshToken = generateRefreshToken(ipAddress);

            // save refresh token

            user.REFRESH_TOKEN.Add(refreshToken);
            user.AuthData = refreshToken.Token;
            refreshToken.IsActive = true;

            // pour quel raison ? todo test..
            //user.Token = jwtToken;

            _repositoryContext.Update(user);
            _repositoryContext.SaveChanges();

            //return user;
            return new AuthenticateResponseDto(user, user.Token, refreshToken.Token, refreshToken.Expires.Value, message, true,false,flag);
        }

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

        public AuthenticateResponseDto RefreshToken(string token, string ipAddress)
        {
            var user = _repositoryContext.USER.SingleOrDefault(u => u.REFRESH_TOKEN.Any(t => t.Token == token));
            var RefreshTokens = _repositoryContext.REFRESH_TOKEN.ToList();
            var FindTokens = RefreshTokens.Select(a => a.Token == token);

            // return null if no user found with token
            if (user == null) return null;

            var refreshToken = user.REFRESH_TOKEN.Single(x => x.Token == token);

            // return null if token is no longer active
            if (!refreshToken.IsActive.HasValue) return null;

            refreshToken.IsActive = false;
            refreshToken.IsExpired = true;

            //revoke the old token
            //ChecKActiveToken(true);

            // replace old refresh token with a new one and save
            var newRefreshToken = generateRefreshToken(ipAddress);
            refreshToken.Revoked = DateTime.Now;
            refreshToken.RevokedByIp = ipAddress;
            refreshToken.ReplacedByToken = newRefreshToken.Token;

            user.REFRESH_TOKEN.Add(newRefreshToken);
            user.AuthData = newRefreshToken.Token;
            _repositoryContext.Update(user);
            _repositoryContext.SaveChanges();

            // generate new jwt
            var jwtToken = generateJwtToken(user);

            return new AuthenticateResponseDto(user, jwtToken, newRefreshToken.Token, newRefreshToken.Expires.Value, "Token refreshed", true, false, false);
        }
        public bool RevokeToken(string token, string ipAddress)
        {
            var user = _repositoryContext.USER.SingleOrDefault(u => u.REFRESH_TOKEN.Any(t => t.Token == token));
            var RefreshTokens = _repositoryContext.REFRESH_TOKEN.ToList();
            var FindTokens = RefreshTokens.Select(a => a.Token == token);

            var UserByToken = _repositoryContext.USER.SingleOrDefault(x => x.REFRESH_TOKEN == FindTokens);

            //var FindRefreshTokenWithUser = UserByToken.REFRESH_TOKEN.Single(t => t.Token == token);
            // return false if no user found with token
            if (user == null) return false;

            var refreshToken = user.REFRESH_TOKEN.Single(x => x.Token == token);

            // return false if token is not active
            if (!refreshToken.IsActive.HasValue) return false;

            // revoke token and save
            refreshToken.Revoked = DateTime.Now;
            refreshToken.RevokedByIp = ipAddress;
            refreshToken.IsActive = false;
            refreshToken.IsExpired = true;
            //ChecKActiveToken(true);

            //Authentification status
            user.IsAuthenticated = false;
            user.IsDisconnected = true;

            _repositoryContext.Update(user);
            _repositoryContext.SaveChanges();
            return true;
        }

        private string generateJwtToken(USER user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.CodeEmploye.ToString())
                }),
                Expires = DateTime.Now.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private REFRESH_TOKEN generateRefreshToken(string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                var dateDate = DateTime.Now;
                var expireDate = DateTime.Now.AddMinutes(5);


                return new REFRESH_TOKEN
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Expires = expireDate,
                    Created = DateTime.Now,
                    CreatedByIp = ipAddress,
                    IsExpired = DateTime.Now >= expireDate,
                    IsActive = true
                };
            }
        }

        public void ChecKActiveToken(bool RevokeAll)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_CHECK_ISACTIVE_TOKEN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RevokeAll", RevokeAll);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }

        }

        public async Task<USER> GetUserWithTokenReferences(string username)
        {
            USER _uSER = new USER();
            REFRESH_TOKEN _rEFRESH_TOKEN = new REFRESH_TOKEN();

            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            await using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_GetUSER_WithToken_Ref", con);



                SqlCommand cmd1 = new SqlCommand("SELECT U.[CodeEmploye]" +
                    ",U.[Username]" +
                    ",R.[Id] " +
                    ", R.[Token]" +
                    ", R.[Expires]" +
                    ", R.[IsExpired]" +
                    ", R.[Created]" +
                    ", R.[CreatedByIp]" +
                    ", R.[Revoked]" +
                    ", R.[RevokedByIp]" +
                    ", R.[ReplacedByToken]" +
                    ", R.[IsActive] from [dbo].[USER] as U " +
                    "INNER JOIN [dbo].[REFRESH_TOKEN] AS R " +
                    "ON U.CodeEmploye = R.CodeEmploye " +
                    "WHERE" +
                    " U.Username = @Username", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {

                    while (sdr.Read())
                    {
                        _uSER.CodeEmploye = sdr["CodeEmploye"].ToString();
                        _uSER.Username = sdr["Username"].ToString();

                    }

                    if (sdr.NextResult())
                    {
                        while (sdr.Read())
                        {

                            _rEFRESH_TOKEN.Id = (int)sdr["Id"];
                            //_rEFRESH_TOKEN.CodeEmploye = sdr["CodeEmploye"].ToString();
                            _rEFRESH_TOKEN.Token = sdr["Token"].ToString();
                            _rEFRESH_TOKEN.Expires = Convert.ToDateTime(sdr["Expires"]);
                            _rEFRESH_TOKEN.IsExpired = Convert.ToBoolean(sdr["IsExpired"]);
                            _rEFRESH_TOKEN.Created = Convert.ToDateTime(sdr["Created"]);
                            _rEFRESH_TOKEN.CreatedByIp = sdr["CreatedByIp"].ToString();
                            _rEFRESH_TOKEN.Revoked = Convert.ToDateTime(sdr["Revoked"]);
                            _rEFRESH_TOKEN.RevokedByIp = sdr["RevokedByIp"].ToString();
                            _rEFRESH_TOKEN.ReplacedByToken = sdr["ReplacedByToken"].ToString();
                            _rEFRESH_TOKEN.IsActive = Convert.ToBoolean(sdr["IsActive"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
            return _uSER;
        }

        public string GetActiveRefreshToken(string username, bool isActive)
        {
            var connectionString = _ConnectionString.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            REFRESH_TOKEN refresh_token = new REFRESH_TOKEN();

             using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("dbo.PROC_GET_ISACTIVE_REFRESH_TOKEN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@isActive", isActive);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {

                    while (sdr.Read())
                    {
                        refresh_token.Token = sdr["Token"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DB" + ex.Message);
                }
                con.Close();
            }
            return refresh_token.Token.ToString();
        }

        #endregion
    }
}
