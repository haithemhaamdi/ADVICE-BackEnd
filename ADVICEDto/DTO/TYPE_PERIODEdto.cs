﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDto.DTO
{
    public partial class TYPE_PERIODEdto
    {
        public TYPE_PERIODEdto()
        {
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIEdto>();
        }

        public string CodeTypePeriode { get; set; }
        public string LibelleTypePeriode { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}