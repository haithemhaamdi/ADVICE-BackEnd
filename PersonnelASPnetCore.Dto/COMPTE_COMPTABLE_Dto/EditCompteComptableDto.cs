using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.COMPTE_COMPTABLE_Dto
{
    public class EditCompteComptableDto
    {
        [Required]
        public string NumeroCompteComptable { get; set; }
        [Required]
        public string LibelleCompteComptable { get; set; }
        [Required]
        public bool Collectif { get; set; }
    }
}
