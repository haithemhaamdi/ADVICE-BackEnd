﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class TYPE_PERIODE
    {
        public TYPE_PERIODE()
        {
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIE>();
        }

        public string CodeTypePeriode { get; set; }
        public string LibelleTypePeriode { get; set; }

        public virtual ICollection<BULLETIN_PAIE> BULLETIN_PAIE { get; set; }
    }
}