using PersonnelASPnetCore.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.COMPTE_COMPTABLE_Dto
{
    public class CompteComptableResponseDto
    {
        [Required]
        public string NumeroCompteComptable { get; set; }
        public string LibelleCompteComptable { get; set; }
        public bool Collectif { get; set; }
        public CompteComptableResponseDto(COMPTE_COMPTABLE compteComptable ,string numero, string libelle, bool collectif)
        {

            numero = compteComptable.NumeroCompteComptable;
            libelle = compteComptable.LibelleCompteComptable;
            collectif = compteComptable.Collectif;

        }
    }
}
