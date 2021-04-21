using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.PLAN_PAIE_Dto
{
    public class PlanPaieResponseDto
    {
        [Required]
        public string CodePlan { get; set; }
        public string LibellePlan { get; set; }

        public virtual ICollection<PLAN_PAIE_DETAILdto> PLAN_PAIE_DETAIL { get; set; }
    }
}
