﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDto.DTO
{
    public partial class JOURNAL_COMPTABLEdto
    {
        public JOURNAL_COMPTABLEdto()
        {
            ECRITURE = new HashSet<ECRITUREdto>();
        }

        public string CodeJournalComptable { get; set; }
        public string LibelleJournalComptable { get; set; }
        public string NumeroCompteComptable { get; set; }

        public virtual ICollection<ECRITUREdto> ECRITURE { get; set; }
    }
}