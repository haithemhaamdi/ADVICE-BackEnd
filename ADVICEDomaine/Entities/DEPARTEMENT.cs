﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class DEPARTEMENT
    {
        public DEPARTEMENT()
        {
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIE>();
        }

        public string CodeDepartement { get; set; }
        public string LibelleDepartement { get; set; }

        public virtual ICollection<BULLETIN_PAIE> BULLETIN_PAIE { get; set; }
    }
}