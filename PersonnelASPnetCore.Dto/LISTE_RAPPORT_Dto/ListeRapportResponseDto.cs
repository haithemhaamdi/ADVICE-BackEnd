using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.LISTE_RAPPORT_Dto
{
    public class ListeRapportResponseDto
    {
        public int IdImpression { get; set; }
        public string Module { get; set; }
        public string Impression { get; set; }
        public string LibelleImpression { get; set; }
        public string NomRapport { get; set; }
    }
}
