using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_DOCUMENT_Dto
{
    public class EmployeDocumentResponseDto
    {
        [Required]
        public string CodeDocument { get; set; }
        public string CodeEmploye { get; set; }
        public DateTime DateDocument { get; set; }
        public string CodeSecondaire { get; set; }
        public string TitreDocument { get; set; }
        public string ResumeDocument { get; set; }
        public string TexteDocument { get; set; }
        public string TypeDocument { get; set; }
        public byte[] ImageDocument { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public int TailleImageDocument { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
