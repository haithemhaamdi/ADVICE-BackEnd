using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.BORDEREAU_Dto
{
    public class BordereauResponseDto
    {
        [Required]
        public string NumeroBordereau { get; set; }
        public DateTime DateBordereau { get; set; }
        public string CodePeriode { get; set; }
        public string CodeEmploye { get; set; }
        public string CodeRubrique { get; set; }
        public string CodePlan { get; set; }
        public decimal Valeur { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
        public virtual PLAN_PAIE_DETAILdto CodeP { get; set; }
    }
}
