// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Dto.DTO
{
    public partial class MODELE_PAIE_DETAILdto
    {
        public string CodeModele { get; set; }
        public string CodeTypeRubrique { get; set; }
        public string CodeRubrique { get; set; }
        public string LibelleRubrique { get; set; }

        public virtual RUBRIQUEdto Code { get; set; }
        public virtual MODELE_PAIEdto CodeModeleNavigation { get; set; }
    }
}