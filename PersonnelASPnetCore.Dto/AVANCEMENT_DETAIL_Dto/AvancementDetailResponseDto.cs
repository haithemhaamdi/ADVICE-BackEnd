using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.AVANCEMENT_DETAIL_Dto
{
    public class AvancementDetailResponseDto
    {
        [Required]
        public string NumeroAvancement { get; set; }
        public string CodeEmploye { get; set; }
        public string CodeSituationAncien { get; set; }
        public DateTime DateSituationAncien { get; set; }
        public decimal SalaireBaseAncien { get; set; }
        public decimal TauxHoraireAncien { get; set; }
        public string MatriculeEmploye { get; set; }
        public string CodeFonction { get; set; }
        public string CodeDepartement { get; set; }
        public string CodeSituationNouveau { get; set; }
        public decimal SalaireBaseNouveau { get; set; }
        public decimal TauxHoraireNouveau { get; set; }
    }
}
