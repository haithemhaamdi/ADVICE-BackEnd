// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class ECRITURE_OUVERTURE
    {
        public string NumeroCompteComptable { get; set; }
        public string LibelleCompteComptable { get; set; }
        public decimal? MontantDebit { get; set; }
        public decimal? MontantCredit { get; set; }
        public string NumeroEcritureOuverture { get; set; }

        public virtual COMPTE_COMPTABLE NumeroCompteComptableNavigation { get; set; }
    }
}