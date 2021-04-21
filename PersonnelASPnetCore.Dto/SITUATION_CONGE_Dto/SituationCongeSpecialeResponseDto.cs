using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.SITUATION_CONGE_Dto
{
    public class SituationCongeSpecialeResponseDto
    {
        public string CodeRubrique { get; set; }
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CodeDepartement { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public string LibelleDepartement { get; set; }
        public string LibelleRubrique { get; set; }
        public decimal PlafondConge { get; set; }
        public decimal? CongePercuSpecial { get; set; }
    }
}
