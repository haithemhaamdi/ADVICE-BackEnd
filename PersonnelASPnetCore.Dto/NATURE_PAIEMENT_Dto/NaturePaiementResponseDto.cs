using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.NATURE_PAIEMENT_Dto
{
    public class NaturePaiementResponseDto
    {
        [Required]
        public string CodeNaturePaiement { get; set; }
        public string LibelleNaturePaiement { get; set; }
    }
}
