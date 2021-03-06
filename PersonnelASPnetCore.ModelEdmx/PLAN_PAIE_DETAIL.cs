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
    
    public partial class PLAN_PAIE_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLAN_PAIE_DETAIL()
        {
            this.BORDEREAU = new HashSet<BORDEREAU>();
            this.BULLETIN_PAIE = new HashSet<BULLETIN_PAIE>();
        }
    
        public string CodePlan { get; set; }
        public string CodePeriode { get; set; }
        public string CodeTypePeriode { get; set; }
        public string LibellePeriode { get; set; }
        public int JourBase { get; set; }
        public int HeureBase { get; set; }
        public string DatePaye { get; set; }
        public string CodeModele { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORDEREAU> BORDEREAU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BULLETIN_PAIE> BULLETIN_PAIE { get; set; }
        public virtual MODELE_PAIE MODELE_PAIE { get; set; }
        public virtual PLAN_PAIE PLAN_PAIE { get; set; }
    }
}
