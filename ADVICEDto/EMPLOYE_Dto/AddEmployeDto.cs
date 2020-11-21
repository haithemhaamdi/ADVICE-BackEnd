using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADVICEDto.EMPLOYE_Dto
{
    public class AddEmployeDto
    {
        [Required]
        public string CodeEmploye { get; set; }
        public string MatriculeEmploye { get; set; }
        public string CodeAppellation { get; set; }
        public string NomEmploye { get; set; }
        public string CIN { get; set; }
        public DateTime DateCIN { get; set; }
        public string Passeport { get; set; }
        public DateTime DatePasseport { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public string CodeFonction { get; set; }
        public string CodeDepartement { get; set; }
        public decimal SalaireBase { get; set; }
        public decimal TauxHoraire { get; set; }
        public string CodeGrille { get; set; }
        public string CodeSituation { get; set; }
        public DateTime? DateSituation { get; set; }
        public bool ChefFamille { get; set; }
        public decimal CongeAnnuel { get; set; }
        public decimal CongeAnterieur { get; set; }
        public string MatriculeSecuriteSociale { get; set; }
        public string MatriculeAssuranceGroupe { get; set; }
        public string NumeroPermisConduite { get; set; }
        public string CodeModePaiement { get; set; }
        public string CodeBanque { get; set; }
        public string AgenceBanque { get; set; }
        public string RIB { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string AdresseMail { get; set; }
        public string Nationalite { get; set; }
        public byte[] PhotoEmploye { get; set; }
        public int TaillePhoto { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateModification { get; set; }
        public string CodePlan { get; set; }
        public string Notes { get; set; }
        public string CodeNaturePaiement { get; set; }
        public decimal TauxJournalier { get; set; }
        public bool Imposable { get; set; }
        public bool CotisationSociale { get; set; }
        public bool AssuranceGroupe { get; set; }
        public bool ImpotLiquidatif { get; set; }
        public bool Smig { get; set; }
        public bool RedevanceCompensation { get; set; }
        public decimal MontantPlafondAssuranceGroupe { get; set; }
        public decimal ImposableAnterieur { get; set; }
        public decimal ImpotAnterieur { get; set; }
        public string AnneeImpotAnterieur { get; set; }
        public bool Cavis { get; set; }
        public string Suffixe { get; set; }
        public int SituationFamilialle { get; set; }
    }
}
