using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.EMPLOYE_VENTILATION_Dto
{
    public class EmployeVentilationResponseDto
    {
        public string CodeEmploye { get; set; }
        public string CodeActivite { get; set; }
        public string CodeDepartement { get; set; }
        public string CodeFonction { get; set; }
        public decimal Coefficient { get; set; }
    }
}
