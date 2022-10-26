using ConsultorioMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultorioMedico
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estudio> Estudios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<MedicosEstudios> MedicosEstudios { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
    }
}
