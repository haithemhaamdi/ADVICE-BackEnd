﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDto.DTO
{
    public partial class VIREMENTdto
    {
        public VIREMENTdto()
        {
            VIREMENT_DETAIL = new HashSet<VIREMENT_DETAILdto>();
        }

        public string NumeroVirement { get; set; }
        public DateTime DateVirement { get; set; }
        public string CodeBanqueVirement { get; set; }
        public decimal TotalVirement { get; set; }
        public string CodeBCT { get; set; }
        public int? CodeISO { get; set; }

        public virtual ICollection<VIREMENT_DETAILdto> VIREMENT_DETAIL { get; set; }
    }
}