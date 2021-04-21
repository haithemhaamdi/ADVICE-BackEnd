using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.MODE_PAIEMENT_Dto
{
    public class ModePaiementResponseDto
    {
        [Required]
        public string CodeModePaiement { get; set; }
        public string LibelleModePaiement { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}
