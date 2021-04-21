using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.TYPE_PRET_Dto
{
    public class TypePretResponseDto
    {
        [Required]
        public string CodeTypePret { get; set; }
        public string LibelleTypePret { get; set; }

        public virtual ICollection<EMPLOYE_PRETdto> EMPLOYE_PRET { get; set; }
    }
}
