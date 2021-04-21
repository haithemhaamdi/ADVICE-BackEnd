using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.VIREMENT_Dto
{
    public class VirementResponseDto
    {
        [Required]
        public string NumeroVirement { get; set; }
        public DateTime DateVirement { get; set; }
        public string CodeBanqueVirement { get; set; }
        public decimal TotalVirement { get; set; }
        public string CodeBCT { get; set; }
        public int? CodeISO { get; set; }

        public virtual ICollection<VIREMENT_DETAILdto> VIREMENT_DETAIL { get; set; }
    }
}
