using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.SITE_Dto
{
    public class SiteResponseDto
    {
        [Required]
        public string CodeSite { get; set; }
        public string LibelleSite { get; set; }
    }
}
