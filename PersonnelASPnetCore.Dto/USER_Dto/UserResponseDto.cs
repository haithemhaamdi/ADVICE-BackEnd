using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class UserResponseDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        public string Login { get; set; }
        //public string Password { get; set; }
        public int Connections { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool Status { get; set; }
        public string CodeRole { get; set; }
        public string AuthData { get; set; }
        public string Username { get; set; }
        public string AdresseMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Picture_URL { get; set; }
        public byte[] Picture { get; set; }

        //public byte[] PasswordHash { get; set; }
        //public byte[] PasswordSalt { get; set; }

        //public virtual EMPLOYE CodeEmployeNavigation { get; set; }
        //public virtual ROLE CodeRoleNavigation { get; set; }
    }
}
