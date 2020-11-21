﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class RUBRIQUE
    {
        public RUBRIQUE()
        {
            MODELE_PAIE_DETAIL = new HashSet<MODELE_PAIE_DETAIL>();
        }

        public string CodeRubrique { get; set; }
        public string CodeTypeRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public decimal Taux { get; set; }
        public bool InclureAssuranceGroupe { get; set; }
        public bool InclureSecuriteSociale { get; set; }
        public bool InclureImpot { get; set; }
        public bool IndemniteActive { get; set; }
        public bool InclureIndemniteConge { get; set; }
        public string CodeTypeIndemnite { get; set; }
        public decimal MontantIndemnite { get; set; }
        public decimal BasePonderation { get; set; }
        public bool InclureBordereau { get; set; }
        public string TitreBordereau { get; set; }
        public bool RubriqueParDefaut { get; set; }
        public string NumeroCompteComptable { get; set; }
        public bool DetailComptecomptable { get; set; }
        public string SensCompteComptable { get; set; }
        public bool InclureCongeAnnuel { get; set; }
        public decimal PlafondConge { get; set; }

        public virtual ICollection<MODELE_PAIE_DETAIL> MODELE_PAIE_DETAIL { get; set; }
    }
}