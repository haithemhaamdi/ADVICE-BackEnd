﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class DECLARATION_CNSS
    {
        public DECLARATION_CNSS()
        {
            DECLARATION_CNSS_DETAIL = new HashSet<DECLARATION_CNSS_DETAIL>();
        }

        public int Annee { get; set; }
        public int Trimestre { get; set; }
        public DateTime DateDeclaration { get; set; }
        public bool Valide { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }
        public string ModePaiement { get; set; }
        public string NumeroCheque { get; set; }
        public string LibelleBanqueVirement { get; set; }
        public decimal Montant { get; set; }
        public string CodeBanqueVirement { get; set; }
        public string NumeroCompteComptable { get; set; }
        public decimal TauxSecurite { get; set; }
        public decimal TauxAccidentTravail { get; set; }

        public virtual ICollection<DECLARATION_CNSS_DETAIL> DECLARATION_CNSS_DETAIL { get; set; }
    }
}