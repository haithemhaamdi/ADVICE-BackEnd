using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.JOURNAL_COMPTABLE_Dto
{
    public class JournalComptableResponseDto
    {
        [Required]
        public string CodeJournalComptable { get; set; }
        public string LibelleJournalComptable { get; set; }
        public string NumeroCompteComptable { get; set; }

        public virtual ICollection<ECRITUREdto> ECRITURE { get; set; }
    }
}
