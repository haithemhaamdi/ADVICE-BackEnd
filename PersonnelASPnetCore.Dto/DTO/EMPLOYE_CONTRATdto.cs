// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Dto.DTO
{
    public partial class EMPLOYE_CONTRATdto
    {
        public string CodeContratEmploye { get; set; }
        public string CodeEmploye { get; set; }
        public string CodeTypeContrat { get; set; }
        public DateTime DateDebutContrat { get; set; }
        public DateTime? DateFinContrat { get; set; }
        public DateTime? DateDebutPeriodeEssai { get; set; }
        public DateTime? DateFinPeriodeEssai { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
        public virtual TYPE_CONTRATdto CodeTypeContratNavigation { get; set; }
    }
}