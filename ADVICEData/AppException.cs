using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ADVICEData
{
    // Custom exception class for throwing application specific exceptions (e.g. for validation) 
    // that can be caught and handled within the application
    /// <summary>
    /// ASP.NET Core App Exception
    /// </summary>
    public class AppException : Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
