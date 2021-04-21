using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.TYPE_PERIODE_Dto
{
    public class TypePeriodeResponseDto
    {
        [Required]
        public string CodeTypePeriode { get; set; }
        public string LibelleTypePeriode { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}
