﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDto.DTO
{
    public partial class BANQUEdto
    {
        public BANQUEdto()
        {
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIEdto>();
        }

        public string CodeBanque { get; set; }
        public string LibelleBanque { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}