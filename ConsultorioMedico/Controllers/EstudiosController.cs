using ConsultorioMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ConsultorioMedico.Controllers
{
    [Route("estudios")]
    public class EstudiosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EstudiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var estudios = await _context.Estudios.Include(x => x.Paciente).ToListAsync();

            var model = new EstudiosViewModel()
            {
                Estudios = estudios
            };

            return View(model);
        }

        [Route("crear")]
        public async Task<ActionResult> CrearEstudio()
        {
            return View();
        }
        [Route("crear")]
        [HttpPost]
        public async Task<IActionResult> CrearEstudio(EstudioCreacionDTO estudioCreacionDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    foreach(var medicoId in estudioCreacionDTO.MedicosAsociados)
                    {
                        var existe = await _context.Medicos.AnyAsync(x => x.Id == medicoId);
                        if (!existe)
                        {
                            // TODO: Return BadRequest, algun medico no existe
                        }
                    }
                    // TODO: Validar paciente no tenga un estudio en el mismo horario
                    

                    var estudio = new Estudio()
                    {
                        Nombre = estudioCreacionDTO.Nombre,
                        FechayHora = estudioCreacionDTO.FechayHora,
                        PacienteId = estudioCreacionDTO.PacienteId,
                        Resultado = estudioCreacionDTO.Resultado
                    };

                    _context.Add(estudio);
                    await _context.SaveChangesAsync();

                    return Redirect("/estudios");
                }

                return View(estudioCreacionDTO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}