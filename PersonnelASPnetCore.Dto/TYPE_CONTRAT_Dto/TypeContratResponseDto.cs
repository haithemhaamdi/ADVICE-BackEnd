using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.TYPE_CONTRAT_Dto
{
    public class TypeContratResponseDto
    {
        [Required]
        public string CodeTypeContrat { get; set; }
        public string LibelleTypeContrat { get; set; }

        public virtual ICollection<EMPLOYE_CONTRATdto> EMPLOYE_CONTRAT { get; set; }
    }
}
