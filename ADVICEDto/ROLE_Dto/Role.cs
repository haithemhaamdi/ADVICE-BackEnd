﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADVICEDto.ROLE_Dto
{
    public static class Role
    {
        public const string Admin = "ADMIN";
        public const string User = "USER";
        public const string AdministratorOrUser = Admin + "," + User;

    }

}
