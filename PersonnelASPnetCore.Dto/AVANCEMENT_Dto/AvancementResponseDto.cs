using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.AVANCEMENT_Dto
{
    public class AvancementResponseDto
    {
        [Required]
        public string NumeroAvancement { get; set; }
        public DateTime DateAvancement { get; set; }
        public DateTime DateOperation { get; set; }
        public bool Valide { get; set; }
    }
}
