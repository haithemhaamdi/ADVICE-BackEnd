using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.IMP_Dto
{
    public class IMP_DeclarationMensuelImpotResponseDto
    {
        public int? TauxTFP { get; set; }
        public int? TauxFOPROLOS { get; set; }
        public int? Mois { get; set; }
        public int? Annee { get; set; }
        public decimal? BaseRetenueSource { get; set; }
        public decimal? MontantImpot { get; set; }
        public decimal? MontantRedevanceCompensation { get; set; }
        public decimal? BaseTFP { get; set; }
        public decimal? MontantTFP { get; set; }
        public decimal? BaseFOPROLOS { get; set; }
        public decimal? MontantFOPROLOS { get; set; }
    }
}
