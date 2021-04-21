using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.DEPARTEMENT_Dto
{
    public class DepatementResponseDto
    {
        [Required]
        public string CodeDepartement { get; set; }
        public string LibelleDepartement { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}
