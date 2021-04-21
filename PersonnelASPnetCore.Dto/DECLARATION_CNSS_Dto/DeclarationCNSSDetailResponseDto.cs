using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.DECLARATION_CNSS_Dto
{
    public class DeclarationCNSSDetailResponseDto
    {
        public int Annee { get; set; }
        public int Trimestre { get; set; }
        public decimal TauxCotisationEmployeur { get; set; }
        public decimal TauxAccidentTravail { get; set; }
        public string CodeEmploye { get; set; }
        public string MatriculeSecuriteSociale { get; set; }
        public string NomEmploye { get; set; }
        public string MatriculeEmploye { get; set; }
        public string CIN { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public int NumeroPage { get; set; }
        public int NumeroLigne { get; set; }
        public decimal Mois1 { get; set; }
        public decimal Mois2 { get; set; }
        public decimal Mois3 { get; set; }
        public decimal TotalEmploye { get; set; }
        public decimal TauxCotisationEmploye1 { get; set; }
        public decimal TauxCotisationEmploye2 { get; set; }
        public decimal TauxCotisationEmploye3 { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
        public virtual DECLARATION_CNSSdto DECLARATION_CNSS { get; set; }
    }
}
