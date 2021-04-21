using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.POINTAGE_Dto
{
    public class PointageResponseDto
    {
        [Required]
        public string NumeroPointage { get; set; }
        public DateTime DatePointage { get; set; }
        public string NumeroBordereau { get; set; }
        public string CodeEmploye { get; set; }
        public string DateJour { get; set; }
        public string CodeJour { get; set; }
        public string LibelleJour { get; set; }
        public string CodeSemaine { get; set; }
        public DateTime DateDebutPointage { get; set; }
        public DateTime DateFinPointage { get; set; }
        public decimal NombreHeure { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
