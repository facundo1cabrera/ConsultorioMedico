using ConsultorioMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ConsultorioMedico.Controllers
{
    [Route("medicos")]
    public class MedicosController: Controller
    {
        private readonly ApplicationDbContext _context;
        public MedicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var medicos = await _context.Medicos.ToListAsync();

            var model = new MedicosViewModel()
            {
                Medicos = medicos
            };

            return View(model);
        }
        [Route("crear")]
        public async Task<ActionResult> CrearMedico()
        {
            return View();
        }
        [Route("crear")]
        [HttpPost]
        public async Task<IActionResult> CrearMedico(MedicoCreacionDTO medicoCreacionDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var medico = new Medico()
                    {
                        Nombre = medicoCreacionDTO.Nombre,
                        Matricula = medicoCreacionDTO.Matricula,
                        Especialidad = medicoCreacionDTO.Especialidad
                    };

                    _context.Add(medico);
                    await _context.SaveChangesAsync();

                    return Redirect("/medicos");
                }

                return View(medicoCreacionDTO);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
