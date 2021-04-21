using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.BANQUE_Dto
{
    public class BanqueResponseDto
    {
        [Required]
        public string CodeBanque { get; set; }
        public string LibelleBanque { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIEdto { get; set; }
    }
}
