using System.ComponentModel.DataAnnotations;

namespace ConsultorioMedico.Models
{
    public class MedicoCreacionDTO
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(150)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(80)]
        [Display(Name = "Especialidad")]
        public string Especialidad { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(20)]
        [Display(Name = "Matricula")]
        public string Matricula { get; set; }
    }
}
