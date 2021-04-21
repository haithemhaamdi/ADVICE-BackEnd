using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.BULLETIN_PAIE_DETAIL_Dto
{
    public class BulletinPaieDetailResponseDto
    {
        [Required]
        public string NumeroBulletin { get; set; }
        public string CodeRubrique { get; set; }
        public string CodeTypeRubrique { get; set; }
        public string CodeSecondaire { get; set; }
        public decimal MontantBase { get; set; }
        public decimal Taux { get; set; }
        public float Nombre { get; set; }
        public decimal Valeur { get; set; }
        public decimal Montant { get; set; }
        public string LibelleRubrique { get; set; }
        public string LibelleTypeRubrique { get; set; }
        public bool InclureAssuranceGroupe { get; set; }
        public bool InclureSecuriteSociale { get; set; }
        public bool InclureImpot { get; set; }
        public bool IndemniteActive { get; set; }
        public bool InclureIndemniteConge { get; set; }
        public string CodeTypeIndemnite { get; set; }
        public decimal MontantIndemnite { get; set; }
        public decimal BasePonderation { get; set; }
        public bool RubriqueParDefaut { get; set; }
        public bool Actif { get; set; }
        public decimal MontantRubrique { get; set; }
        public decimal MontantPlafondMaximum { get; set; }
        public decimal MontantPlafondMinimum { get; set; }
    }
}
