using ADVICEDomaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADVICEDto.EMPLOYE_Dto
{
    public class EmployeResponseDto
    {
        public EmployeResponseDto()
        {
            BORDEREAU = new HashSet<BORDEREAU>();
            BULLETIN_PAIE = new HashSet<BULLETIN_PAIE>();
            DECLARATION_CNSS_DETAIL = new HashSet<DECLARATION_CNSS_DETAIL>();
            DECLARATION_CNSS_TAUX_EMPLOYEUR = new HashSet<DECLARATION_CNSS_TAUX_EMPLOYEUR>();
            EMPLOYE_ABSENCE = new HashSet<EMPLOYE_ABSENCE>();
            EMPLOYE_AJUSTEMENT_CONGE = new HashSet<EMPLOYE_AJUSTEMENT_CONGE>();
            EMPLOYE_AVANCE = new HashSet<EMPLOYE_AVANCE>();
            EMPLOYE_A_CHARGE = new HashSet<EMPLOYE_A_CHARGE>();
            EMPLOYE_CONGE = new HashSet<EMPLOYE_CONGE>();
            EMPLOYE_CONTRAT = new HashSet<EMPLOYE_CONTRAT>();
            EMPLOYE_CORRESPONDANCE = new HashSet<EMPLOYE_CORRESPONDANCE>();
            EMPLOYE_DEDUCTION = new HashSet<EMPLOYE_DEDUCTION>();
            EMPLOYE_DISCIPLINE = new HashSet<EMPLOYE_DISCIPLINE>();
            EMPLOYE_DOCUMENT = new HashSet<EMPLOYE_DOCUMENT>();
            EMPLOYE_FORMATION = new HashSet<EMPLOYE_FORMATION>();
            EMPLOYE_OBSERVATION = new HashSet<EMPLOYE_OBSERVATION>();
            EMPLOYE_PRET = new HashSet<EMPLOYE_PRET>();
            EMPLOYE_RUBRIQUE = new HashSet<EMPLOYE_RUBRIQUE>();
            POINTAGE = new HashSet<POINTAGE>();
            VIREMENT_DETAIL = new HashSet<VIREMENT_DETAIL>();
        }
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

        public virtual USER USER { get; set; }
        public virtual ICollection<BORDEREAU> BORDEREAU { get; set; }
        public virtual ICollection<BULLETIN_PAIE> BULLETIN_PAIE { get; set; }
        public virtual ICollection<DECLARATION_CNSS_DETAIL> DECLARATION_CNSS_DETAIL { get; set; }
        public virtual ICollection<DECLARATION_CNSS_TAUX_EMPLOYEUR> DECLARATION_CNSS_TAUX_EMPLOYEUR { get; set; }
        public virtual ICollection<EMPLOYE_ABSENCE> EMPLOYE_ABSENCE { get; set; }
        public virtual ICollection<EMPLOYE_AJUSTEMENT_CONGE> EMPLOYE_AJUSTEMENT_CONGE { get; set; }
        public virtual ICollection<EMPLOYE_AVANCE> EMPLOYE_AVANCE { get; set; }
        public virtual ICollection<EMPLOYE_A_CHARGE> EMPLOYE_A_CHARGE { get; set; }
        public virtual ICollection<EMPLOYE_CONGE> EMPLOYE_CONGE { get; set; }
        public virtual ICollection<EMPLOYE_CONTRAT> EMPLOYE_CONTRAT { get; set; }
        public virtual ICollection<EMPLOYE_CORRESPONDANCE> EMPLOYE_CORRESPONDANCE { get; set; }
        public virtual ICollection<EMPLOYE_DEDUCTION> EMPLOYE_DEDUCTION { get; set; }
        public virtual ICollection<EMPLOYE_DISCIPLINE> EMPLOYE_DISCIPLINE { get; set; }
        public virtual ICollection<EMPLOYE_DOCUMENT> EMPLOYE_DOCUMENT { get; set; }
        public virtual ICollection<EMPLOYE_FORMATION> EMPLOYE_FORMATION { get; set; }
        public virtual ICollection<EMPLOYE_OBSERVATION> EMPLOYE_OBSERVATION { get; set; }
        public virtual ICollection<EMPLOYE_PRET> EMPLOYE_PRET { get; set; }
        public virtual ICollection<EMPLOYE_RUBRIQUE> EMPLOYE_RUBRIQUE { get; set; }
        public virtual ICollection<POINTAGE> POINTAGE { get; set; }
        public virtual ICollection<VIREMENT_DETAIL> VIREMENT_DETAIL { get; set; }
    }
}
