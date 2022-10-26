using System.Collections.Generic;

namespace ConsultorioMedico.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        public List<MedicosEstudios> MedicosEstudios { get; set; }
    }
}
