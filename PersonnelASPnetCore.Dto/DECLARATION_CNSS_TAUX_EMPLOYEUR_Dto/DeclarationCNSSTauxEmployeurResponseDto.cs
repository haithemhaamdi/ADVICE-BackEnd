using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.DECLARATION_CNSS_TAUX_EMPLOYEUR_Dto
{
    public class DeclarationCNSSTauxEmployeurResponseDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public decimal TauxCotisationEmployeur { get; set; }
        public decimal TauxAccidentTravail { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
