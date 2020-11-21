using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class UpdateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
