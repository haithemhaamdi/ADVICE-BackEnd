using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADVICEDto.CONNECTIONS_HISTORY_Dto
{
    public class AddConnectionHistoryDto
    {
        public int Id { get; set; }
        public string CodeEmploye { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int Connections { get; set; }
        public DateTime SignInDate { get; set; }
        public DateTime? SignOutDate { get; set; }
        public string Hostname { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }

        public virtual USER CodeEmployeNavigation { get; set; }
        public virtual REFRESH_TOKEN IdNavigation { get; set; }

    }
}
