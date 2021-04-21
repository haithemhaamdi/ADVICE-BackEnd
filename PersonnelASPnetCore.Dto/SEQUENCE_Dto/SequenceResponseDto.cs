using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelASPnetCore.Dto.SEQUENCE_Dto
{
    public class SequenceResponseDto
    {
        public string Annee { get; set; }
        public string TypeDocument { get; set; }
        public short? Numero { get; set; }
        public bool? RecupereNumero { get; set; }
    }
}
