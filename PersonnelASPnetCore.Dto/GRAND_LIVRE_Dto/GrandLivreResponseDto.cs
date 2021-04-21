using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.GRAND_LIVRE_Dto
{
    public class GrandLivreResponseDto
    {
        public string NumeroCompteComptable { get; set; }
        public string LibelleCompteComptable { get; set; }
        public string NumeroEcriture { get; set; }
        public DateTime DateEcriture { get; set; }
        public string LibelleEcriture { get; set; }
        public decimal MontantDebit { get; set; }
        public decimal MontantCredit { get; set; }
        public string Reference { get; set; }
        public string Origine { get; set; }
        public bool Valide { get; set; }
        public bool Ouverture { get; set; }
        public string CodeJournalComptable { get; set; }
        public string LibelleJournalComptable { get; set; }
        public string Lettre { get; set; }
    }
}
