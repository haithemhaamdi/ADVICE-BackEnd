using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_A_CHARGE_Dto
{
    public class Employe_A_ChargeResponseDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        public string CodePersonne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Parente { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime? DateLimite { get; set; }
        public byte[] PhotoPersonne { get; set; }
        public int TaillePhoto { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
