using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class LogOutDto
    {
        public string Token { get; set; }
        public bool RevokeAll { get; set; }
    }
}
