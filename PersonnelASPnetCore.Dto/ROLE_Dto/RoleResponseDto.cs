using PersonnelASPnetCore.Domaine.Entities;
using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.ROLE_Dto
{
    public class RoleResponseDto
    {
        [Required]
        public string CodeRole { get; set; }
        public string Name { get; set; }
    }
}
