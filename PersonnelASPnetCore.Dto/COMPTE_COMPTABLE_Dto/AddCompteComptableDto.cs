using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.COMPTE_COMPTABLE_Dto
{
    public class AddCompteComptableDto
    {
        [Required]
        public string NumeroCompteComptable { get; set; }
        public string LibelleCompteComptable { get; set; }
        public bool Collectif { get; set; }
    }
}
