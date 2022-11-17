using ConsultorioMedico.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsultorioMedico
{
    public static class SeedData
    {
        public static void Seeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>()
                .HasData(
                    new Medico { Id = 1, Especialidad = "Pediatria", Matricula = "XSQER 23123", Nombre = "Fernando Gonzalez" },
                    new Medico { Id = 2, Especialidad = "Medicina interna", Matricula = "SETQW 43253", Nombre = "Leticia Gomez" },
                    new Medico { Id = 3, Especialidad = "Cardiologia", Matricula = "SFRAD 43689", Nombre = "Hugo Kin" },
                    new Medico { Id = 4, Especialidad = "Cirujia toracica", Matricula = "METJA 93452", Nombre = "Joaquin Chew" },
                    new Medico { Id = 5, Especialidad = "Neurologo", Matricula = "ADGTY 32134", Nombre = "Ivan Rueda" },
                    new Medico { Id = 6, Especialidad = "Cirujia ortopedica", Matricula = "READR 36543", Nombre = "Emilia Raineri" }, 
                    new Medico { Id = 7, Especialidad = "Quiropractico", Matricula = "RRATT 68345", Nombre = "Facundo Magico" },
                    new Medico { Id = 8, Especialidad = "Genetica", Matricula = "FJGKK 69450", Nombre = "Martina Humberti" },
                    new Medico { Id = 9, Especialidad = "Oncologia", Matricula = "AAWER 97312", Nombre = "Diego Trelew" }, 
                    new Medico { Id = 10, Especialidad = "Cirujia pie y tobillo", Matricula = "RKASD 34524", Nombre = "Francisco Martini" },
                    new Medico { Id = 11, Especialidad = "Cuidados paleativos", Matricula = "RREAT 03203", Nombre = "Indiana Jackson" }
                );

            modelBuilder.Entity<Estudio>()
                .HasData(
                   new Estudio { Id = 1, Nombre = "Alergología", PacienteId = 1, FechayHora = DateTime.Now.AddMonths(-12), Resultado = "POSITIVO - Maiz" },
                   new Estudio { Id = 2, Nombre = "Amniocentesis", PacienteId = 1, FechayHora = DateTime.Now, Resultado = "POSITIVO" },
                   new Estudio { Id = 3, Nombre = "Alergología", PacienteId = 2, FechayHora = DateTime.Now.AddMonths(-20), Resultado = "NO DETECTABLE" },
                   new Estudio { Id = 4, Nombre = "Análisis de sangre de glucagón", PacienteId = 3, FechayHora = DateTime.Now.AddMonths(-10), Resultado = "POSITIVO - Hipoglucemia" },
                   new Estudio { Id = 5, Nombre = "Biopsia de ganglio centinela", PacienteId = 4, FechayHora = DateTime.Now.AddMonths(1), Resultado = "PENDIENTE" },
                   new Estudio { Id = 6, Nombre = "Densitometría ósea", PacienteId = 4, FechayHora = DateTime.Now.AddMonths(24), Resultado = "PENDIENTE" },
                   new Estudio { Id = 7, Nombre = "Dióxido de carbono (CO2) en la sangre", PacienteId = 5, FechayHora = DateTime.Now.AddMonths(-21), Resultado = "Síndrome de Cushing" },
                   new Estudio { Id = 8, Nombre = "Ecografía", PacienteId = 6, FechayHora = DateTime.Now.AddMonths(-2), Resultado = "Bajo liquido amniotico" },
                   new Estudio { Id = 9, Nombre = "Electrocardiograma", PacienteId = 7, FechayHora = DateTime.Now.AddMonths(-2), Resultado = "Ritmo cardiaco regular" },
                   new Estudio { Id = 10, Nombre = "Estudio del sueño", PacienteId = 8, FechayHora = DateTime.Now.AddMonths(4), Resultado = "PENDIENTE" },
                   new Estudio { Id = 11, Nombre = "Fluoroscopia", PacienteId = 9, FechayHora = DateTime.Now.AddMonths(1).AddDays(4), Resultado = "PENDIENTE" },
                   new Estudio { Id = 12, Nombre = "Hisopado nasal", PacienteId = 10, FechayHora = DateTime.Now.AddMonths(-1), Resultado = "POSITIVO - Covid19" },
                   new Estudio { Id = 13, Nombre = "Prueba de cristales en la orina", PacienteId = 11, FechayHora = DateTime.Now.AddMonths(-3), Resultado = "POSITIVO" },
                   new Estudio { Id = 14, Nombre = "Prueba de cultivo fúngico", PacienteId = 12, FechayHora = DateTime.Now.AddMonths(-11), Resultado = "POSITIVO" },
                   new Estudio { Id = 15, Nombre = "Prueba de cultivo fúngico", PacienteId = 13, FechayHora = DateTime.Now.AddMonths(-12), Resultado = "NEGATIVO" },
                   new Estudio { Id = 16, Nombre = "Alergología", PacienteId = 14, FechayHora = DateTime.Now.AddMonths(-36), Resultado = "POSITIVO - Gatos" },
                   new Estudio { Id = 17, Nombre = "Alergología", PacienteId = 14, FechayHora = DateTime.Now.AddMonths(-3).AddDays(-12), Resultado = "POSITIVO - Lactosa" },
                   new Estudio { Id = 18, Nombre = "Alergología", PacienteId = 15, FechayHora = DateTime.Now.AddMonths(12).AddDays(3), Resultado = "PENDIENTE" }
                );

            modelBuilder.Entity<Paciente>()
                .HasData(
                    new Paciente { Id = 1, DNI = 23129234, Nombre = "Henrique", Apellido = "Lopez", FechaNacimiento = DateTime.Now.AddYears(-54).AddDays(-64) },
                    new Paciente { Id = 2, DNI = 35123432, Nombre = "Emilia", Apellido = "Kim", FechaNacimiento = DateTime.Now.AddYears(-33).AddDays(-64) },
                    new Paciente { Id = 3, DNI = 43185662, Nombre = "Ambar", Apellido = "Ze", FechaNacimiento = DateTime.Now.AddYears(-18).AddDays(-64) },
                    new Paciente { Id = 4, DNI = 21453434, Nombre = "Santiago", Apellido = "Koral", FechaNacimiento = DateTime.Now.AddYears(-56).AddDays(-64) },
                    new Paciente { Id = 5, DNI = 12457234, Nombre = "Milagros", Apellido = "Mazer", FechaNacimiento = DateTime.Now.AddYears(-73).AddDays(-64) },
                    new Paciente { Id = 6, DNI = 33156903, Nombre = "Diego", Apellido = "Cervi", FechaNacimiento = DateTime.Now.AddYears(-45).AddDays(-64) },
                    new Paciente { Id = 7, DNI = 13124884, Nombre = "Juan", Apellido = "Certi", FechaNacimiento = DateTime.Now.AddYears(-83).AddDays(-64) },
                    new Paciente { Id = 8, DNI = 22125684, Nombre = "Junior", Apellido = "Kermelon", FechaNacimiento = DateTime.Now.AddYears(-55).AddDays(-64) },
                    new Paciente { Id = 9, DNI = 40129234, Nombre = "Trevor", Apellido = "Juego", FechaNacimiento = DateTime.Now.AddYears(-16).AddDays(-64) },
                    new Paciente { Id = 10, DNI = 39078012, Nombre = "Tomas", Apellido = "Predeterminado", FechaNacimiento = DateTime.Now.AddYears(-58).AddDays(-64) },
                    new Paciente { Id = 11, DNI = 12343490, Nombre = "Estanislao", Apellido = "Perez", FechaNacimiento = DateTime.Now.AddYears(-54).AddDays(-64) },
                    new Paciente { Id = 12, DNI = 28675666, Nombre = "Romeo", Apellido = "Dorple", FechaNacimiento = DateTime.Now.AddYears(-33).AddDays(-64) },
                    new Paciente { Id = 13, DNI = 45854353, Nombre = "Lucas", Apellido = "Buzzsack", FechaNacimiento = DateTime.Now.AddYears(-19).AddDays(-64) },
                    new Paciente { Id = 14, DNI = 34578634, Nombre = "Thomas", Apellido = "Pzcaecae", FechaNacimiento = DateTime.Now.AddYears(-28).AddDays(-64) },
                    new Paciente { Id = 15, DNI = 23461434, Nombre = "Francisco", Apellido = "Gonzalez", FechaNacimiento = DateTime.Now.AddYears(-61).AddDays(-64) }
                );

            modelBuilder.Entity<MedicosEstudios>()
                .HasData(
                    new MedicosEstudios { Id = 1, MedicoId = 2, EstudioId = 1 },
                    new MedicosEstudios { Id = 2, MedicoId = 2, EstudioId = 16 },
                    new MedicosEstudios { Id = 3, MedicoId = 2, EstudioId = 17 },
                    new MedicosEstudios { Id = 4, MedicoId = 8, EstudioId = 18 },
                    new MedicosEstudios { Id = 5, MedicoId = 8, EstudioId = 16 },
                    new MedicosEstudios { Id = 6, MedicoId = 8, EstudioId = 17 },
                    new MedicosEstudios { Id = 7, MedicoId = 2, EstudioId = 18 },
                    new MedicosEstudios { Id = 8, MedicoId = 1, EstudioId = 2 },
                    new MedicosEstudios { Id = 9, MedicoId = 2, EstudioId = 3 },
                    new MedicosEstudios { Id = 10, MedicoId = 5, EstudioId = 4 },
                    new MedicosEstudios { Id = 11, MedicoId = 9, EstudioId = 5 },
                    new MedicosEstudios { Id = 12, MedicoId = 4, EstudioId = 5 },
                    new MedicosEstudios { Id = 13, MedicoId = 6, EstudioId = 5 },
                    new MedicosEstudios { Id = 14, MedicoId = 7, EstudioId = 6 },
                    new MedicosEstudios { Id = 15, MedicoId = 8, EstudioId = 7 },
                    new MedicosEstudios { Id = 16, MedicoId = 10, EstudioId = 8 },
                    new MedicosEstudios { Id = 17, MedicoId = 11, EstudioId = 9 },
                    new MedicosEstudios { Id = 18, MedicoId = 3, EstudioId = 9 },
                    new MedicosEstudios { Id = 19, MedicoId = 4, EstudioId = 10 },
                    new MedicosEstudios { Id = 20, MedicoId = 5, EstudioId = 11 },
                    new MedicosEstudios { Id = 21, MedicoId = 6, EstudioId = 12 },
                    new MedicosEstudios { Id = 22, MedicoId = 7, EstudioId = 13 },
                    new MedicosEstudios { Id = 23, MedicoId = 9, EstudioId = 14 },
                    new MedicosEstudios { Id = 24, MedicoId = 11, EstudioId = 15 },
                    new MedicosEstudios { Id = 25, MedicoId = 10, EstudioId = 15 }
                );
        }
    }
}
