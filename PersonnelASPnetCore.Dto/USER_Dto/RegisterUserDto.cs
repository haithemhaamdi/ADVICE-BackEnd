using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class RegisterUserDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        public string AdresseMail { get; set; }
        [Required]
        public string Password { get; set; }
        public int Connections { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Picture_URL { get; set; }
        public byte[] Picture { get; set; }
        public string CodeRole { get; set; }

    }
}
