using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.DECLARATION_EMPLOYEUR_Dto
{
    public class DeclarationEmployeurResponseDto
    {
        public int? Annee { get; set; }
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CIN { get; set; }
        public string MatriculeEmploye { get; set; }
        public string MatriculeSecuriteSociale { get; set; }
        public string CodeFonction { get; set; }
        public string LibelleFonction { get; set; }
        public string Adresse { get; set; }
        public string SituationFamilliale { get; set; }
        public decimal? NombreMois { get; set; }
        public decimal? Imposable { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? Impot { get; set; }
        public decimal? RedevanceCompensation { get; set; }
        public decimal? Net { get; set; }
    }
}
