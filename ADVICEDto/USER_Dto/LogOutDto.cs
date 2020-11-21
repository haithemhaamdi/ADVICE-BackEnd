using System;
using System.Collections.Generic;
using System.Text;

namespace ADVICEDto.USER_Dto
{
    public class LogOutDto
    {
        public string Token { get; set; }
        public bool RevokeAll { get; set; }
    }
}
