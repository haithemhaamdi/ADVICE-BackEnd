﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDto.DTO
{
    public partial class COMPTE_COMPTABLEdto
    {
        public COMPTE_COMPTABLEdto()
        {
            ECRITURE_OUVERTURE = new HashSet<ECRITURE_OUVERTURE>();
        }

        public string NumeroCompteComptable { get; set; }
        public string LibelleCompteComptable { get; set; }
        public bool Collectif { get; set; }

        public virtual ICollection<ECRITURE_OUVERTURE> ECRITURE_OUVERTURE { get; set; }
    }
}