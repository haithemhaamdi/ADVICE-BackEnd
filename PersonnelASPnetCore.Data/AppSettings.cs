using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Data
{
    public class AppSettings
    {
        public SmtpConfig SmtpConfig { get; set; }
        public string Secret { get; set; }

    }
    public class SmtpConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Secret { get; set; }

    }
}
