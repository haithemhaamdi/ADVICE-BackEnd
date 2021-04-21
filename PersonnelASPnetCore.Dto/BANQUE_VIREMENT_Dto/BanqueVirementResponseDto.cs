using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.BANQUE_VIREMENT_Dto
{
    public class BanqueVirementResponseDto
    {
        [Required]
        public string CodeBanqueVirement { get; set; }
        public string LibelleBanqueVirement { get; set; }
        public string AgenceBanqueVirement { get; set; }
        public string RIBBanqueVirement { get; set; }
        public string ContactBanqueVirement { get; set; }
        public string Adresse { get; set; }
        public string tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NumeroCompteComptable { get; set; }
    }
}
