using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.PLAN_PAIE_DETAIL_Dto
{
    public class PlanPaieDetailResponseDto
    {
        [Required]
        public string CodePlan { get; set; }
        public string CodePeriode { get; set; }
        public string CodeTypePeriode { get; set; }
        public string LibellePeriode { get; set; }
        public int JourBase { get; set; }
        public int HeureBase { get; set; }
        public string DatePaye { get; set; }
        public string CodeModele { get; set; }

        public virtual MODELE_PAIEdto CodeModeleNavigation { get; set; }
        public virtual PLAN_PAIEdto CodePlanNavigation { get; set; }
        public virtual ICollection<BORDEREAUdto> BORDEREAU { get; set; }
        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}
