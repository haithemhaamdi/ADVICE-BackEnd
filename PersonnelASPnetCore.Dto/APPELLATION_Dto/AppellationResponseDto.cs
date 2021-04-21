using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.APPELLATION_Dto
{
    public class AppellationResponseDto
    {
        [Required]
        public string CodeAppellation { get; set; }
        public string LibelleAppellation { get; set; }
    }
}
