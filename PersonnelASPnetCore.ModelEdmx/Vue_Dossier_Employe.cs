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
    
    public partial class Vue_Dossier_Employe
    {
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CIN { get; set; }
        public System.DateTime DateCIN { get; set; }
        public string Passeport { get; set; }
        public System.DateTime DatePasseport { get; set; }
        public string MatriculeSecuriteSociale { get; set; }
        public string MatriculeAssuranceGroupe { get; set; }
        public string NumeroPermisConduite { get; set; }
        public System.DateTime DateEntree { get; set; }
        public Nullable<System.DateTime> DateSortie { get; set; }
        public string CodeFonction { get; set; }
        public string CodeDepartement { get; set; }
        public decimal SalaireBase { get; set; }
        public decimal TauxHoraire { get; set; }
        public string CodeGrille { get; set; }
        public string CodeSituation { get; set; }
        public Nullable<System.DateTime> DateSituation { get; set; }
        public decimal CongeAnnuel { get; set; }
        public decimal CongeAnterieur { get; set; }
        public decimal TauxJournalier { get; set; }
        public string MatriculeEmploye { get; set; }
        public decimal MontantPlafondAssuranceGroupe { get; set; }
        public string LibelleFonction { get; set; }
        public string LibelleSituation { get; set; }
        public string LibelleGrille { get; set; }
        public string LibelleDepartement { get; set; }
        public string LibellePlan { get; set; }
        public string LibelleNaturePaiement { get; set; }
        public string AgenceBanque { get; set; }
        public string RIB { get; set; }
        public bool Imposable { get; set; }
        public bool CotisationSociale { get; set; }
        public bool AssuranceGroupe { get; set; }
        public bool ImpotLiquidatif { get; set; }
        public bool Smig { get; set; }
        public bool RedevanceCompensation { get; set; }
        public decimal ImposableAnterieur { get; set; }
        public decimal ImpotAnterieur { get; set; }
        public string AnneeImpotAnterieur { get; set; }
        public string LibelleModePaiement { get; set; }
        public string LibelleBanque { get; set; }
        public bool ChefFamille { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Nationalite { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string AdresseMail { get; set; }
        public byte[] PhotoEmploye { get; set; }
    }
}