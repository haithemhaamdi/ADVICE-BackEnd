using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.TYPE_INDEMNITE_Dto
{
    public class TypeIndemniteResponseDto
    {
        [Required]
        public string CodeTypeIndemnite { get; set; }
        public string LibelleTypeIndemnite { get; set; }
    }
}
