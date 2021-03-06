//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonnelASPnetCore.ModelEdmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class DECLARATION_CNSS_DETAIL
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
        public System.DateTime DateEntree { get; set; }
        public Nullable<System.DateTime> DateSortie { get; set; }
        public int NumeroPage { get; set; }
        public int NumeroLigne { get; set; }
        public decimal Mois1 { get; set; }
        public decimal Mois2 { get; set; }
        public decimal Mois3 { get; set; }
        public decimal TotalEmploye { get; set; }
        public decimal TauxCotisationEmploye1 { get; set; }
        public decimal TauxCotisationEmploye2 { get; set; }
        public decimal TauxCotisationEmploye3 { get; set; }
    
        public virtual DECLARATION_CNSS DECLARATION_CNSS { get; set; }
        public virtual EMPLOYE EMPLOYE { get; set; }
    }
}
