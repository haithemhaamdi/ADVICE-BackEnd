// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class FONCTION
    {
        public FONCTION()
        {
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIE>();
        }

        public string CodeFonction { get; set; }
        public string LibelleFonction { get; set; }

        public virtual ICollection<BULLETIN_PAIE> BULLETIN_PAIE { get; set; }
    }
}