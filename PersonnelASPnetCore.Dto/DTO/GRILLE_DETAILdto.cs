// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Dto.DTO
{
    public partial class GRILLE_DETAILdto
    {
        public GRILLE_DETAILdto()
        {
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIEdto>();
        }

        public string CodeGrille { get; set; }
        public string CodeSituation { get; set; }
        public string LibelleSituation { get; set; }
        public decimal SalaireBase { get; set; }
        public decimal TauxHoraire { get; set; }
        public short DureeAnciennete { get; set; }

        public virtual GRILLEdto CodeGrilleNavigation { get; set; }
        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}