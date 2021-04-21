using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.ECRITURE_Dto
{
    public class EcritureResponseDto
    {
        [Required]
        public string NumeroEcriture { get; set; }
        public DateTime DateEcriture { get; set; }
        public string CodeJournalComptable { get; set; }
        public string Reference { get; set; }
        public string CodeUtilisateur { get; set; }
        public DateTime? DateSaisie { get; set; }
        public bool Valide { get; set; }
        public string Origine { get; set; }
        public string SousOrigine { get; set; }
        public bool Ouverture { get; set; }

        public virtual JOURNAL_COMPTABLEdto CodeJournalComptableNavigation { get; set; }
        public virtual ICollection<ECRITURE_DETAIL> ECRITURE_DETAIL { get; set; }
    }
}
