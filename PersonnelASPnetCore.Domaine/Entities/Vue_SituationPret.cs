// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class Vue_SituationPret
    {
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CodeDepartement { get; set; }
        public string LibelleDepartement { get; set; }
        public string CodePret { get; set; }
        public string LibellePret { get; set; }
        public string CodeTypePret { get; set; }
        public string LibelleTypePret { get; set; }
        public DateTime? DateEffetPret { get; set; }
        public decimal? MontantAccorde { get; set; }
        public decimal? Tranche { get; set; }
        public decimal? MontantRembourse { get; set; }
        public decimal? MontantRestant { get; set; }
    }
}