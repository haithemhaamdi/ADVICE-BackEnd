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
    
    public partial class EMPLOYE_OBSERVATION
    {
        public string CodeObservation { get; set; }
        public string CodeEmploye { get; set; }
        public string ContenuObservation { get; set; }
        public System.DateTime DateObservation { get; set; }
        public string CodeOperateur { get; set; }
        public System.DateTime DateOperation { get; set; }
    
        public virtual EMPLOYE EMPLOYE { get; set; }
    }
}
