using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.VIREMENT_DETAIL_Dto
{
    public class VirementDetailResponseDto
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
