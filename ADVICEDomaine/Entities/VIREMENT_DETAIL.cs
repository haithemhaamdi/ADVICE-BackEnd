﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class VIREMENT_DETAIL
    {
        public string NumeroVirement { get; set; }
        public string NumeroBulletin { get; set; }
        public string CodePeriode { get; set; }
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CodeBanque { get; set; }
        public string AgenceBanque { get; set; }
        public string RIB { get; set; }
        public decimal Montant { get; set; }

        public virtual EMPLOYE CodeEmployeNavigation { get; set; }
        public virtual BULLETIN_PAIE NumeroBulletinNavigation { get; set; }
        public virtual VIREMENT NumeroVirementNavigation { get; set; }
    }
}