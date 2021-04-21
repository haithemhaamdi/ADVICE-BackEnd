using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.ACTIVITE_Dto
{
    public class ActiviteResponseDto
    {
        [Required]
        public string CodeActivite { get; set; }
        public string LibelleActivite { get; set; }
    }
}
