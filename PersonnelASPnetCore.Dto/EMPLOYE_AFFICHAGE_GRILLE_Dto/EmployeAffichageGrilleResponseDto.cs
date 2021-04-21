using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_AFFICHAGE_GRILLE_Dto
{
    public class EmployeAffichageGrilleResponseDto
    {
        [Required]
        public string CodeOperateur { get; set; }
        public string ColonneEmploye { get; set; }
        public short Ordre { get; set; }
        public short Largeur { get; set; }
    }
}
