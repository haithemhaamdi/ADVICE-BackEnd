using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.DECOMPTE_MONNAIE_Dto
{
    public class DecompteMonnaieResponseDto
    {
        public int? Annee { get; set; }
        public int? Mois { get; set; }
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public DateTime? DateSortie { get; set; }
        public string MatriculeEmploye { get; set; }
        public decimal? SalaireNet { get; set; }
        public decimal? yMontant { get; set; }
        public int? Nombre50D { get; set; }
        public int? Nombre20D { get; set; }
        public int? Nombre10D { get; set; }
        public int? Nombre5D { get; set; }
        public int? Nombre1D { get; set; }
        public int? Nombre500M { get; set; }
        public int? Nombre100M { get; set; }
        public int? Nombre50M { get; set; }
        public int? Nombre20M { get; set; }
        public int? Nombre10M { get; set; }
        public int? Residu { get; set; }
    }
}
