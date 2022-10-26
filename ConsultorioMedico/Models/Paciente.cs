using System;
using System.Collections.Generic;

namespace ConsultorioMedico.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Estudio> Estudios { get; set; }
    }
}
