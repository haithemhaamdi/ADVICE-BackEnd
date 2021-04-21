using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_AVANCE_Dto
{
    public class EmployeAvanceResponseDto
    {
        [Required]
        public string CodeAvance { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleAvance { get; set; }
        public DateTime DateAvance { get; set; }
        public decimal MontantDemande { get; set; }
        public decimal MontantAccorde { get; set; }
        public string Note { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
