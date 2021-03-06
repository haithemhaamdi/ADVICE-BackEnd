using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_ABSENCE_Dto
{
    public class EmployeAbsenceResponseDto
    {
        [Required]
        public string CodeAbsence { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleAbsence { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public float NombreAbsence { get; set; }
        public bool Justifie { get; set; }
        public string Note { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }
        public string CodePeriode { get; set; }
        public int AnneeAbsence { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
