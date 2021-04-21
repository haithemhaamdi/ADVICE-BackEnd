using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.RUBRIQUE_Dto
{
    public class RubriqueResponseDto
    {
        [Required]
        public string CodeRubrique { get; set; }
        public string CodeTypeRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public decimal Taux { get; set; }
        public bool InclureAssuranceGroupe { get; set; }
        public bool InclureSecuriteSociale { get; set; }
        public bool InclureImpot { get; set; }
        public bool IndemniteActive { get; set; }
        public bool InclureIndemniteConge { get; set; }
        public string CodeTypeIndemnite { get; set; }
        public decimal MontantIndemnite { get; set; }
        public decimal BasePonderation { get; set; }
        public bool InclureBordereau { get; set; }
        public string TitreBordereau { get; set; }
        public bool RubriqueParDefaut { get; set; }
        public string NumeroCompteComptable { get; set; }
        public bool DetailComptecomptable { get; set; }
        public string SensCompteComptable { get; set; }
        public bool InclureCongeAnnuel { get; set; }
        public decimal PlafondConge { get; set; }

        public virtual ICollection<MODELE_PAIE_DETAILdto> MODELE_PAIE_DETAIL { get; set; }
    }
}
