using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.MODELE_PAIE_Dto
{
    public class ModellePaieResponseDto
    {
        [Required]
        public string CodeModele { get; set; }
        public string LibelleModele { get; set; }
        public bool InclurePret { get; set; }
        public bool InclureIndemnite { get; set; }
        public bool CalculLiquidatif { get; set; }
        public bool InclureAvance { get; set; }
        public string TitreBulletin { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
        public virtual ICollection<MODELE_PAIE_DETAILdto> MODELE_PAIE_DETAIL { get; set; }
        public virtual ICollection<PLAN_PAIE_DETAILdto> PLAN_PAIE_DETAIL { get; set; }
    }
}
