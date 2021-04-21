using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.IMP_Dto
{
    public class IMP_DeclarationAssurenceResponseDto
    {
        public string CodeEmploye { get; set; }
        public int? Annee { get; set; }
        public int? Trimestre { get; set; }
        public string MatriculeSecuriteSociale { get; set; }
        public string MatriculeAssuranceGroupe { get; set; }
        public string NomEmploye { get; set; }
        public string CodeFonction { get; set; }
        public string LibelleFonction { get; set; }
        public string MatriculeEmploye { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public int NumeroOrdre { get; set; }
        public decimal? Mois1 { get; set; }
        public decimal? Mois2 { get; set; }
        public decimal? Mois3 { get; set; }
        public decimal? TotalEmploye { get; set; }
    }
}
