// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class ROLE
    {
        public ROLE()
        {
            USER = new HashSet<USER>();
        }

        public string CodeRole { get; set; }
        public string Name { get; set; }

        public virtual ICollection<USER> USER { get; set; }
    }
}