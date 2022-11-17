using System;
using System.Collections.Generic;

namespace ConsultorioMedico.Models
{
    public class EstudioCreacionDTO
    {
        public string Nombre { get; set; }
        public string Resultado { get; set; }
        public DateTime FechayHora { get; set; }
        public int PacienteId { get; set; }
        public List<int> MedicosAsociados { get; set; }
    }
}
