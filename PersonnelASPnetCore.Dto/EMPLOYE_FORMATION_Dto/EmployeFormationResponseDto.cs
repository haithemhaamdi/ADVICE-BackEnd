using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_FORMATION_Dto
{
    public class EmployeFormationResponseDto
    {
        [Required]
        public string CodeFormation { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleFormation { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string LieuFormation { get; set; }
        public string Note { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
