﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PersonnelASPnetCore.Domaine.Entities
{
    public partial class EMPLOYE_A_CHARGE
    {
        public string CodeEmploye { get; set; }
        public string CodePersonne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Parente { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime? DateLimite { get; set; }
        public byte[] PhotoPersonne { get; set; }
        public int TaillePhoto { get; set; }

        public virtual EMPLOYE CodeEmployeNavigation { get; set; }
    }
}