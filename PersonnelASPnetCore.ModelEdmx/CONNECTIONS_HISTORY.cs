//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonnelASPnetCore.ModelEdmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONNECTIONS_HISTORY
    {
        public int Id { get; set; }
        public string CodeEmploye { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int Connections { get; set; }
        public System.DateTime SignInDate { get; set; }
        public Nullable<System.DateTime> SignOutDate { get; set; }
        public string Hostname { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
    
        public virtual REFRESH_TOKEN REFRESH_TOKEN { get; set; }
        public virtual USER USER { get; set; }
    }
}
