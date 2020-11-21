using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADVICEDto.USER_Dto
{
    public class AuthenticateRequestDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        public bool isAuthenticated { get; set; }
        public string message { get; set; }

        //public string message => isAuthenticated == false ? message : "Authenticate failed";

        public bool RevokeAll { get; set; }

    }
}
