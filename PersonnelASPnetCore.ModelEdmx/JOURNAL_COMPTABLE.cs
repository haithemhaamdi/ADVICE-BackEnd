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
    
    public partial class JOURNAL_COMPTABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JOURNAL_COMPTABLE()
        {
            this.ECRITURE = new HashSet<ECRITURE>();
        }
    
        public string CodeJournalComptable { get; set; }
        public string LibelleJournalComptable { get; set; }
        public string NumeroCompteComptable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECRITURE> ECRITURE { get; set; }
    }
}
