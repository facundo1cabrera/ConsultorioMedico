namespace ConsultorioMedico.Models
{
    public class MedicosEstudios
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public int EstudioId { get; set; }
        public Medico Medico { get; set; }
        public Estudio Estudio { get; set; }
    }
}
