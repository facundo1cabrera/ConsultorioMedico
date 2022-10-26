using System;
using System.Collections.Generic;

namespace ConsultorioMedico.Models
{
    public class Estudio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Resultado { get; set; }
        public DateTime FechayHora { get; set; }
        public List<MedicosEstudios> MedicosEstudios { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}
