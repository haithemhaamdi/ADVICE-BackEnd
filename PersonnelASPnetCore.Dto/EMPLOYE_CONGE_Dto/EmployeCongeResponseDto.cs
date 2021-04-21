﻿using PersonnelASPnetCore.Dto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_CONGE_Dto
{
    public class EmployeCongeResponseDto
    {
        [Required]
        public string CodeConge { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleConge { get; set; }
        public DateTime DateDemande { get; set; }
        public DateTime DateDebutDemande { get; set; }
        public DateTime DateFinDemande { get; set; }
        public float NombreCongeDemande { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public float NombreConge { get; set; }
        public bool Actif { get; set; }
        public string MotifRefus { get; set; }
        public string Note { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }
        public string CodePeriode { get; set; }
        public int AnneeConge { get; set; }

        public virtual EMPLOYEdto CodeEmployeNavigation { get; set; }
    }
}
