using ConsultorioMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ConsultorioMedico.Controllers
{
    [Route("pacientes")]
    public class PacientesController: Controller
    {
        private readonly ApplicationDbContext _context;
        public PacientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pacientes = await _context.Paciente.ToListAsync();

            var model = new PacientesViewModel()
            {
                Pacientes = pacientes
            };

            return View(model);
        }

        [Route("crear")]
        public async Task<ActionResult> CrearPaciente()
        {
            return View();
        }
        [Route("crear")]
        [HttpPost]
        public async Task<IActionResult> CrearPaciente(PacienteCreacionDTO pacienteCreacionDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var paciente = new Paciente()
                    {
                        Nombre = pacienteCreacionDTO.Nombre,
                        Apellido = pacienteCreacionDTO.Apellido,
                        DNI = pacienteCreacionDTO.DNI,
                        FechaNacimiento = pacienteCreacionDTO.FechaNacimiento
                    };

                    _context.Add(paciente);
                    await _context.SaveChangesAsync();

                    return Redirect("/pacientes");
                }

                return View(pacienteCreacionDTO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
