﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class Vue_Mouvement_Conge
    {
        public string CodeEmploye { get; set; }
        public string NomEmploye { get; set; }
        public string CodeDepartement { get; set; }
        public string LibelleDepartement { get; set; }
        public decimal? CongeAnnuel { get; set; }
        public int? TotalPresence { get; set; }
        public string NumeroMouvement { get; set; }
        public DateTime DateMouvement { get; set; }
        public int? PresenceObligatoire { get; set; }
        public double? Presence { get; set; }
        public double? CongePercu { get; set; }
        public decimal? DroitConge { get; set; }
    }
}