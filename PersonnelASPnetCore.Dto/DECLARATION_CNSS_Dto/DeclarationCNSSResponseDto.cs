using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.DECLARATION_CNSS_Dto
{
    public class DeclarationCNSSResponseDto
    {
        public int Annee { get; set; }
        public int Trimestre { get; set; }
        public DateTime DateDeclaration { get; set; }
        public bool Valide { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }
        public string ModePaiement { get; set; }
        public string NumeroCheque { get; set; }
        public string LibelleBanqueVirement { get; set; }
        public decimal Montant { get; set; }
        public string CodeBanqueVirement { get; set; }
        public string NumeroCompteComptable { get; set; }
        public decimal TauxSecurite { get; set; }
        public decimal TauxAccidentTravail { get; set; }

        public virtual ICollection<DECLARATION_CNSS_DETAILdto> DECLARATION_CNSS_DETAIL { get; set; }
    }
}
