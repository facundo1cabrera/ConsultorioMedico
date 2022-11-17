using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioMedico.Models
{
    public class PacienteCreacionDTO
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(75)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(75)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "DNI tiene que ser un numero mayor a 0")]
        [Display(Name = "DNI")]
        public int DNI { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}
