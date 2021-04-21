using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_DISCIPLINE_Dto
{
    public class EmployeDiscplineResponseDto
    {
        [Required]
        public string CodeDiscipline { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleDiscipline { get; set; }
        public DateTime DateDiscipline { get; set; }
        public string DecisionDiscipline { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
