using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.GRILLE_Dto
{
    public class GrilleResponseDto
    {
        [Required]
        public string CodeGrille { get; set; }
        public string LibelleGrille { get; set; }

        public virtual ICollection<GRILLE_DETAILdto> GRILLE_DETAIL { get; set; }
    }
}
