using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class AuthenticateResponseDto
    {
        public string CodeEmploye { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        public string AuthData { get; set; }

        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }
        public int Connections { get; set; }

        public string Message { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }

        public bool IsAuthenticated { get; set; }

        public AuthenticateResponseDto(USER user, string jwtToken, string refreshToken, DateTime refreshTokenExpiration, string message,bool isAuthenticated )
        {
            CodeEmploye = user.CodeEmploye;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Connections = user.Connections;
            Token = jwtToken;
            AuthData = user.AuthData;
            RefreshToken = refreshToken;
            RefreshTokenExpiration = refreshTokenExpiration;
            Message = message;
            IsAuthenticated = isAuthenticated;
        }
    }
}
