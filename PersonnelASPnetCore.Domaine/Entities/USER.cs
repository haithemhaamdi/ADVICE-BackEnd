﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class USER
    {
        public USER()
        {
            CONNECTIONS_HISTORY = new HashSet<CONNECTIONS_HISTORY>();
            REFRESH_TOKEN = new HashSet<REFRESH_TOKEN>();
        }

        public string CodeEmploye { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Connections { get; set; }
        public string MacAddress { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool Status { get; set; }
        public string CodeRole { get; set; }
        public string AuthData { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Token { get; set; }
        public string IpAddress { get; set; }
        public string AdresseMail { get; set; }
        public string Picture_URL { get; set; }
        public byte[] Picture { get; set; }
        public bool? IsAuthenticated { get; set; }
        public bool? IsDisconnected { get; set; }

        public virtual EMPLOYE CodeEmployeNavigation { get; set; }
        public virtual ROLE CodeRoleNavigation { get; set; }
        public virtual ICollection<CONNECTIONS_HISTORY> CONNECTIONS_HISTORY { get; set; }
        public virtual ICollection<REFRESH_TOKEN> REFRESH_TOKEN { get; set; }
    }
}