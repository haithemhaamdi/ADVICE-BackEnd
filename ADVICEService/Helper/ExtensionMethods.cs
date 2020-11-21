using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADVICEService.Helper
{
    public static class ExtensionMethods
    {
        public static IEnumerable<USER> WithoutPasswords(this IEnumerable<USER> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static USER WithoutPassword(this USER user)
        {
            user.Password = null;
            return user;
        }
    }
}
