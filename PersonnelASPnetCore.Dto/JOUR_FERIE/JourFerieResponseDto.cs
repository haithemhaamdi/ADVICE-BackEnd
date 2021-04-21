using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.JOUR_FERIE
{
    public class JourFerieResponseDto
    {
        [Required]
        public long CodeJourFerie { get; set; }
        public string LibelleJourFerie { get; set; }
        public string DateJourFerie { get; set; }
        public string CodeOperateurJourFerie { get; set; }
        public DateTime DateOperationJourFerie { get; set; }
    }
}
