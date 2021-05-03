using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.USER_Dto
{
    public class LogOutDto
    {
        public string Token { get; set; }
        public bool RevokeAll { get; set; }
        public bool IsDisconnected { get; set; }
        public bool IsAuthenticated { get; set; }

        //To get the code of employee when he want to logout.
        public string CodeEmploye { get; set; }


    }
}
