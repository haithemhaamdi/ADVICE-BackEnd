using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_DEDUCTION_Dto
{
    public class EmployeDeductionResponseDto
    {
        [Required]
        public string CodeDeduction { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleDeduction { get; set; }
        public decimal MontantAnnuel { get; set; }
        public DateTime DateValidite { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
