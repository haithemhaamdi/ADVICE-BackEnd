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
    
    public partial class ECRITURE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECRITURE()
        {
            this.ECRITURE_DETAIL = new HashSet<ECRITURE_DETAIL>();
        }
    
        public string NumeroEcriture { get; set; }
        public System.DateTime DateEcriture { get; set; }
        public string CodeJournalComptable { get; set; }
        public string Reference { get; set; }
        public string CodeUtilisateur { get; set; }
        public Nullable<System.DateTime> DateSaisie { get; set; }
        public bool Valide { get; set; }
        public string Origine { get; set; }
        public string SousOrigine { get; set; }
        public bool Ouverture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECRITURE_DETAIL> ECRITURE_DETAIL { get; set; }
        public virtual JOURNAL_COMPTABLE JOURNAL_COMPTABLE { get; set; }
    }
}
