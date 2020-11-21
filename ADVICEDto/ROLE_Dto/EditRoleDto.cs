using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADVICEDto.ROLE_Dto
{
    public class EditRoleDto
    {
        [Required]
        public string CodeRole { get; set; }
        public string Name { get; set; }
    }
}
