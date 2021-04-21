using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_AJUSTEMENT_CONGE_Dto
{
    public class EmployeAjustementCongeResponseDto
    {
        [Required]
        public string CodeAjustementConge { get; set; }
        public string CodeEmploye { get; set; }
        public DateTime DateAjustementConge { get; set; }
        public string LibelleAjustementConge { get; set; }
        public string DescriptionAjustementConge { get; set; }
        public byte NombreAjustement { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
