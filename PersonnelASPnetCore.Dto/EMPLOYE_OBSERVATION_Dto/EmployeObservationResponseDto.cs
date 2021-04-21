using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_OBSERVATION_Dto
{
    public class EmployeObservationResponseDto
    {
        [Required]
        public string CodeObservation { get; set; }
        public string CodeEmploye { get; set; }
        public string ContenuObservation { get; set; }
        public DateTime DateObservation { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
