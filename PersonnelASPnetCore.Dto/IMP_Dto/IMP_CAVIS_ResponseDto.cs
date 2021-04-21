using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.IMP_Dto
{
    public class IMP_CAVIS_ResponseDto
    {
        public string CodeEmploye { get; set; }
        public int? Annee { get; set; }
        public int? Trimestre { get; set; }
        public string MatriculeSecuriteSociale { get; set; }
        public string NomEmploye { get; set; }
        public string MatriculeEmploye { get; set; }
        public string CIN { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public decimal? Mois1 { get; set; }
        public decimal? Mois2 { get; set; }
        public decimal? Mois3 { get; set; }
        public decimal? TotalEmploye { get; set; }
    }
}
