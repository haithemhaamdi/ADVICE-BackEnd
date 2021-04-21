using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class AddUserDto
    {
        [Required]
        public string codeEmploye { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string username { get; set; }
        public string login { get; set; }
        public string AdresseMail { get; set; }
        [Required]
        public string password { get; set; }
        public int connections { get; set; }
        public string macAddress { get; set; }
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
        public bool status { get; set; }
        public string codeRole { get; set; }
        public string authData { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
        public string IpAddress { get; set; }
        public string picture_URL { get; set; }
        public byte[] picture { get; set; }

    }
}
