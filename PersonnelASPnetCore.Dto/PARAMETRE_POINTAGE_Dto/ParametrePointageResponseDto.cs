using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.PARAMETRE_POINTAGE_Dto
{
    public class ParametrePointageResponseDto
    {
        public int ID { get; set; }
        public double NombreHeureSemaine { get; set; }
        public string RubriqueHeurePresenceNormale { get; set; }
        public string RubriqueHeureSupplementaire25 { get; set; }
        public double NombreHeureMax25 { get; set; }
        public string RubriqueHeureSupplementaire50 { get; set; }
        public string RubriqueJourFerie { get; set; }
        public string RubriqueDimanche { get; set; }
    }
}
