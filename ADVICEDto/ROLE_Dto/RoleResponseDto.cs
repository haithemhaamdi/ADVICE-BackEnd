using ADVICEDomaine.Entities;
using ADVICEDto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADVICEDto.ROLE_Dto
{
    public class RoleResponseDto
    {
        [Required]
        public string CodeRole { get; set; }
        public string Name { get; set; }
    }
}
