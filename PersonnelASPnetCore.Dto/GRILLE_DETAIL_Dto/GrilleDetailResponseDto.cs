using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.GRILLE_DETAIL_Dto
{
    public class GrilleDetailResponseDto
    {
        [Required]
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
