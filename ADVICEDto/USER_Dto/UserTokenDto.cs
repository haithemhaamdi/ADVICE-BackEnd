using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADVICEDto.USER_Dto
{
    public class UserTokenDto
    {
        public string CodeEmploye  { get; set; }
        public string Token { get; set; }
        public REFRESH_TOKEN refreshToken { get; set; }

}
}
