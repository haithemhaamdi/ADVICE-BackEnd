using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.ECRITURE_Dto
{
    public class EcritureDetailResponseDto
    {
        [Required]
        public string NumeroEcriture { get; set; }
        public string NumeroCompteComptable { get; set; }
        public string LibelleEcriture { get; set; }
        public decimal MontantDebit { get; set; }
        public decimal MontantCredit { get; set; }
        public string Lettre { get; set; }

        public virtual ECRITUREdto NumeroEcritureNavigation { get; set; }
    }
}
