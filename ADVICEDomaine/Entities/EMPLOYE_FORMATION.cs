﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ADVICEDomaine.Entities
{
    public partial class EMPLOYE_FORMATION
    {
        public string CodeFormation { get; set; }
        public string CodeEmploye { get; set; }
        public string LibelleFormation { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string LieuFormation { get; set; }
        public string Note { get; set; }
        public string CodeOperateur { get; set; }
        public DateTime DateOperation { get; set; }

        public virtual EMPLOYE CodeEmployeNavigation { get; set; }
    }
}