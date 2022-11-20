using ConsultorioMedico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [Route("editar/{estudioId:int}")]
        public async Task<ActionResult> CrearEstudio(int estudioId)
        {
            var estudio = await _context.Estudios.Include(x => x.MedicosEstudios).Where(x => x.Id == estudioId).FirstOrDefaultAsync();
            var estudioCreacionDTO = new EstudioCreacionDTO()
            {
                FechayHora = estudio.FechayHora,
                Nombre = estudio.Nombre,
                MedicosAsociados = estudio.MedicosEstudios.Select(x => x.MedicoId).ToList(),
                PacienteId = estudio.PacienteId,
                Resultado = estudio.Resultado
            };
            var medicos = await _context.Medicos.ToListAsync();
            ViewBag.Medicos = medicos.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = x.Id.ToString()
            });

            var pacientes = await _context.Paciente.ToListAsync();
            ViewBag.Pacientes = pacientes.Select(x => new SelectListItem
            {
                Text = x.Nombre + " " + x.Apellido,
                Value = x.Id.ToString()
            });

            return View(estudioCreacionDTO);
        }
        [Route("crear")]
        public async Task<ActionResult> CrearEstudio()
        {
            var medicos = await _context.Medicos.ToListAsync();
            ViewBag.Medicos = medicos.Select(x => new SelectListItem
            {
                Text = x.Nombre,
                Value = x.Id.ToString()
            });

            var pacientes = await _context.Paciente.ToListAsync();
            ViewBag.Pacientes = pacientes.Select(x => new SelectListItem
            {
                Text = x.Nombre + " " + x.Apellido,
                Value = x.Id.ToString()
            });

            return View();
        }
        [Route("crear")]
        [HttpPost]
        public async Task<IActionResult> CrearEstudio(EstudioCreacionDTO estudioCreacionDTO)
        {
            try
            {
                List<Medico> medicos;
                List<Paciente> pacientes;
                if (ModelState.IsValid)
                {
                    var medicosIds = await _context.Medicos.Where(medicoDb => estudioCreacionDTO.MedicosAsociados.Contains(medicoDb.Id))
                        .Select(x => x.Id).ToListAsync();
                    // TODO: Validar paciente no tenga un estudio en el mismo horario
                    
                    if (estudioCreacionDTO.MedicosAsociados.Count != medicosIds.Count)
                    {
                        medicos = await _context.Medicos.ToListAsync();
                        ViewBag.Medicos = medicos.Select(x => new SelectListItem
                        {
                            Text = x.Nombre,
                            Value = x.Id.ToString()
                        });

                        pacientes = await _context.Paciente.Where(x => x.Id == estudioCreacionDTO.PacienteId).ToListAsync();
                        ViewBag.Pacientes = pacientes.Select(x => new SelectListItem
                        {
                            Text = x.Nombre + " " + x.Apellido,
                            Value = x.Id.ToString()
                        });
                        ViewBag.Alerta = "Hubo un problema con alguno de los medicos asociados. Intenta denuevo.";
                        return View();
                    }

                    var estudiosXPaciente = await _context.Estudios.Where(x => x.PacienteId == estudioCreacionDTO.PacienteId).ToListAsync();
                    var fechasEstudiosXPaciente = estudiosXPaciente.Select(x => x.FechayHora);
                    if (fechasEstudiosXPaciente.Contains(estudioCreacionDTO.FechayHora))
                    {
                        medicos = await _context.Medicos.ToListAsync();
                        ViewBag.Medicos = medicos.Select(x => new SelectListItem
                        {
                            Text = x.Nombre,
                            Value = x.Id.ToString()
                        });

                        pacientes = await _context.Paciente.Where(x => x.Id == estudioCreacionDTO.PacienteId).ToListAsync();
                        ViewBag.Pacientes = pacientes.Select(x => new SelectListItem
                        {
                            Text = x.Nombre + " " + x.Apellido,
                            Value = x.Id.ToString()
                        });
                        ViewBag.Alerta = "Este paciente ya tiene un estudio creado en ese horario. Intentá con otro horario";
                        return View();
                    }

                    var medicosEstudios = new List<MedicosEstudios>();
                    foreach(var id in medicosIds)
                    {
                        medicosEstudios.Add(new MedicosEstudios()
                        {
                            MedicoId = id
                        });
                    }

                    var estudio = new Estudio()
                    {
                        Nombre = estudioCreacionDTO.Nombre,
                        FechayHora = estudioCreacionDTO.FechayHora,
                        PacienteId = estudioCreacionDTO.PacienteId,
                        Resultado = estudioCreacionDTO.Resultado,
                        MedicosEstudios = medicosEstudios
                    };

                    _context.Add(estudio);
                    await _context.SaveChangesAsync();

                    return Redirect("/estudios");
                }
                medicos = await _context.Medicos.ToListAsync();
                ViewBag.Medicos = medicos.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.Id.ToString()
                });

                pacientes = await _context.Paciente.ToListAsync();
                ViewBag.Pacientes = pacientes.Select(x => new SelectListItem
                {
                    Text = x.Nombre + " " + x.Apellido,
                    Value = x.Id.ToString()
                });
                return View(estudioCreacionDTO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}