using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.SITUATION_CONGE_Dto
{
    public class SituationCongeResponseDto
    {
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CodeDepartement { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public string LibelleDepartement { get; set; }
        public decimal? CongeAnterieur { get; set; }
        public decimal CongeAnnuel { get; set; }
        public decimal? PresenceAnnuelle { get; set; }
        public decimal? PresenceDue { get; set; }
        public decimal? PresenceEffective { get; set; }
        public decimal? CongePercu { get; set; }
        public decimal? DroitConge { get; set; }
        public decimal? SoldeConge { get; set; }
    }
}
