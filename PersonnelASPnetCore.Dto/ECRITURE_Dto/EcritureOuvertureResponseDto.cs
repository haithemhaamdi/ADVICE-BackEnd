using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.ECRITURE_Dto
{
    public class EcritureOuvertureResponseDto
    {
        [Required]
        public string NumeroCompteComptable { get; set; }
        public string LibelleCompteComptable { get; set; }
        public decimal? MontantDebit { get; set; }
        public decimal? MontantCredit { get; set; }
        public string NumeroEcritureOuverture { get; set; }

        public virtual COMPTE_COMPTABLEdto NumeroCompteComptableNavigation { get; set; }
    }
}
