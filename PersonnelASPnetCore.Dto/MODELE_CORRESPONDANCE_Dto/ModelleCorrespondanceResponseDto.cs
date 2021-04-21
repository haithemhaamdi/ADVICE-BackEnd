using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.MODELE_CORRESPONDANCE_Dto
{
    public class ModelleCorrespondanceResponseDto
    {
        [Required]
        public string CodeDocument { get; set; }
        public string LibelleDocument { get; set; }
        public byte[] ModeleDocument { get; set; }
        public long TailleFichier { get; set; }

        public virtual ICollection<EMPLOYE_CORRESPONDANCEdto> EMPLOYE_CORRESPONDANCE { get; set; }
    }
}
