// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class POINTAGE
    {
        public string NumeroPointage { get; set; }
        public DateTime DatePointage { get; set; }
        public string NumeroBordereau { get; set; }
        public string CodeEmploye { get; set; }
        public string DateJour { get; set; }
        public string CodeJour { get; set; }
        public string LibelleJour { get; set; }
        public string CodeSemaine { get; set; }
        public DateTime DateDebutPointage { get; set; }
        public DateTime DateFinPointage { get; set; }
        public decimal NombreHeure { get; set; }

        public virtual EMPLOYE CodeEmployeNavigation { get; set; }
    }
}