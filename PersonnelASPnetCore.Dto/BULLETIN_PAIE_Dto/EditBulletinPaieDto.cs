﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.BULLETIN_PAIE_Dto
{
    public class EditBulletinPaieDto
    {
        [Required]
        public string NumeroBulletin { get; set; }
        public DateTime DatePaye { get; set; }
        public string CodePlan { get; set; }
        public string CodePeriode { get; set; }
        public string LibellePeriode { get; set; }
        public string CodeTypePeriode { get; set; }
        public int JourBase { get; set; }
        public int HeureBase { get; set; }
        public string CodeModele { get; set; }
        public string CodeModePaiement { get; set; }
        public string CodeBanque { get; set; }
        public string LibelleBanque { get; set; }
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public bool Valide { get; set; }
        public decimal SalaireBase { get; set; }
        public decimal SalaireNet { get; set; }
        public string RIB { get; set; }
        public string CIN { get; set; }
        public string MatriculeCNSS { get; set; }
        public string MatriculeAssuranceGroupe { get; set; }
        public string Notes { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }
        public bool ChefFamille { get; set; }
        public int NombrePersonneACharge { get; set; }
        public decimal TotalDeduction { get; set; }
        public string CodeDepartement { get; set; }
        public string LibelleDepartement { get; set; }
        public string CodeFonction { get; set; }
        public string LibelleFonction { get; set; }
        public string CodeGrille { get; set; }
        public string CodeSituation { get; set; }
        public bool Smig { get; set; }
        public bool Imposable { get; set; }
        public bool CotisationSociale { get; set; }
        public bool AssuranceGroupe { get; set; }
        public bool ImpotLiquidatif { get; set; }
        public decimal MontantPlafondAssuranceGroupe { get; set; }
        public decimal MontantRedevanceCompensation { get; set; }
        public string MatriculeEmploye { get; set; }
        public bool RedevanceCompensation { get; set; }
        public decimal MontantCavis { get; set; }
        public bool Cavis { get; set; }
        public decimal SoldeConge { get; set; }
        public string CodeTypeContrat { get; set; }
        public decimal ArrondissementPositif { get; set; }
        public decimal ArrondissementNegatif { get; set; }
    }
}
