using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.MODELE_PAIE_DETAIL_Dto
{
    public class ModellePaieDetailResponseDto
    {
        [Required]
        public string CodeModele { get; set; }
        public string CodeTypeRubrique { get; set; }
        public string CodeRubrique { get; set; }
        public string LibelleRubrique { get; set; }

        public virtual RUBRIQUEdto Code { get; set; }
        public virtual MODELE_PAIEdto CodeModeleNavigation { get; set; }
    }
}
