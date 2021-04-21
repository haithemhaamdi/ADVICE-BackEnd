using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.RUBRIQUE_Dto
{
    public class TypeRubriqueResponseDto
    {
        [Required]
        public string CodeTypeRubrique { get; set; }
        public string LibelleOrigine { get; set; }
        public string LibelleTypeRubrique { get; set; }
    }
}
