using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_CORRESPONDANCE_Dto
{
    public class EmployeCorrespondanceResponseDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        public string CodeDocument { get; set; }
        public string CodeDocumentModele { get; set; }
        public DateTime DateDocument { get; set; }
        public byte[] DocumentCorrespondance { get; set; }
        public long TailleFichier { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual MODELE_CORRESPONDANCEdto CodeDocumentModeleNavigation { get; set; }
        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
