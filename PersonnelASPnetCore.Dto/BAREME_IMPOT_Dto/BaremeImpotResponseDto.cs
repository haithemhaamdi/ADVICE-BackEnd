using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.BAREME_IMPOT_Dto
{
   public class BaremeImpotResponseDto
    {
        public decimal Montant1 { get; set; }
        public decimal Montant2 { get; set; }
        public decimal Taux { get; set; }
    }
}
