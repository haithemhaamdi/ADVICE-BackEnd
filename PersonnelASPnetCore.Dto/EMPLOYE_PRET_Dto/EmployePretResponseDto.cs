using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_PRET_Dto
{
    public class EmployePretResponseDto
    {
        [Required]
        public string CodePret { get; set; }
        public string CodeEmploye { get; set; }
        public string LibellePret { get; set; }
        public string CodeTypePret { get; set; }
        public DateTime DateDemande { get; set; }
        public decimal MontantDemande { get; set; }
        public decimal MontantAccorde { get; set; }
        public DateTime DatePret { get; set; }
        public DateTime DateEffetPret { get; set; }
        public decimal Tranche { get; set; }
        public bool Actif { get; set; }
        public DateTime? DateAcceptation { get; set; }
        public string MotifRefus { get; set; }
        public string Note { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
        public virtual TYPE_PRETdto CodeTypePretNavigation { get; set; }
    }
}
