using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_RUBRIQUE_Dto
{
    public class EmployeRubriqueResponseDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        public string CodeRubrique { get; set; }
        public string CodeTypeRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public bool Actif { get; set; }
        public decimal MontantRubrique { get; set; }
        public decimal MontantPlafondMaximum { get; set; }
        public decimal MontantPlafondMinimum { get; set; }
        public string CodeTypeIndemnite { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
