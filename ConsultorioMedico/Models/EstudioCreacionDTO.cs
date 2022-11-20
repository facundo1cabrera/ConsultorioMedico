using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioMedico.Models
{
    public class EstudioCreacionDTO
    {
        [Required(ErrorMessage = "El nombre del estudio es requerido")]
        [Display(Name = "Nombre del estudio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El resultado del estudio es requerido")]
        [Display(Name = "Resultado del estudio")]
        public string Resultado { get; set; }
        [Required(ErrorMessage = "La fecha del estudio es requerida")]
        [Display(Name = "Fecha y hora del estudio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechayHora { get; set; }
        [Required(ErrorMessage = "El nombre del paciente es requerido")]
        [Display( Name = "Nombre del paciente")]
        public int PacienteId { get; set; }
        [Required(ErrorMessage = "Es necesario seleccionar al menos 1 medico asociado")]
        [Display(Name = "Medicos asociados")]
        public List<int> MedicosAsociados { get; set; }
    }
}
