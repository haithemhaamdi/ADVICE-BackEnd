using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.FONCTION_Dto
{
    public class FonctionResponseDto
    {
        public string CodeFonction { get; set; }
        public string LibelleFonction { get; set; }

        public virtual ICollection<BULLETIN_PAIEdto> BULLETIN_PAIE { get; set; }
    }
}
