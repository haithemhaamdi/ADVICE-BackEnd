// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Dto.DTO
{
    public partial class VIREMENT_DETAILdto
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

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
        public virtual BULLETIN_PAIEdto NumeroBulletinNavigation { get; set; }
        public virtual VIREMENTdto NumeroVirementNavigation { get; set; }
    }
}