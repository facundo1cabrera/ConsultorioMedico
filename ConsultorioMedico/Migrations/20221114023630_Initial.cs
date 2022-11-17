using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioMedico.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechayHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudios_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicosEstudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicoId = table.Column<int>(type: "int", nullable: false),
                    EstudioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicosEstudios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicosEstudios_Estudios_EstudioId",
                        column: x => x.EstudioId,
                        principalTable: "Estudios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicosEstudios_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Especialidad", "Matricula", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pediatria", "XSQER 23123", "Fernando Gonzalez" },
                    { 11, "Cuidados paleativos", "RREAT 03203", "Indiana Jackson" },
                    { 10, "Cirujia pie y tobillo", "RKASD 34524", "Francisco Martini" },
                    { 8, "Genetica", "FJGKK 69450", "Martina Humberti" },
                    { 7, "Quiropractico", "RRATT 68345", "Facundo Magico" },
                    { 9, "Oncologia", "AAWER 97312", "Diego Trelew" },
                    { 5, "Neurologo", "ADGTY 32134", "Ivan Rueda" },
                    { 4, "Cirujia toracica", "METJA 93452", "Joaquin Chew" },
                    { 3, "Cardiologia", "SFRAD 43689", "Hugo Kin" },
                    { 2, "Medicina interna", "SETQW 43253", "Leticia Gomez" },
                    { 6, "Cirujia ortopedica", "READR 36543", "Emilia Raineri" }
                });

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "Apellido", "DNI", "FechaNacimiento", "Nombre" },
                values: new object[,]
                {
                    { 9, "Juego", 40129234, new DateTime(2006, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6700), "Trevor" },
                    { 13, "Buzzsack", 45854353, new DateTime(2003, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6713), "Lucas" },
                    { 12, "Dorple", 28675666, new DateTime(1989, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6709), "Romeo" },
                    { 11, "Perez", 12343490, new DateTime(1968, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6706), "Estanislao" },
                    { 10, "Predeterminado", 39078012, new DateTime(1964, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6703), "Tomas" },
                    { 8, "Kermelon", 22125684, new DateTime(1967, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6697), "Junior" },
                    { 2, "Kim", 35123432, new DateTime(1989, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6662), "Emilia" },
                    { 6, "Cervi", 33156903, new DateTime(1977, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6691), "Diego" },
                    { 5, "Mazer", 12457234, new DateTime(1949, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6688), "Milagros" },
                    { 4, "Koral", 21453434, new DateTime(1966, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6685), "Santiago" },
                    { 3, "Ze", 43185662, new DateTime(2004, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6681), "Ambar" },
                    { 14, "Pzcaecae", 34578634, new DateTime(1994, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6716), "Thomas" },
                    { 1, "Lopez", 23129234, new DateTime(1968, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6170), "Henrique" },
                    { 7, "Certi", 13124884, new DateTime(1939, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6694), "Juan" },
                    { 15, "Gonzalez", 23461434, new DateTime(1961, 9, 10, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(6718), "Francisco" }
                });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "FechayHora", "Nombre", "PacienteId", "Resultado" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 13, 23, 36, 29, 652, DateTimeKind.Local).AddTicks(7940), "Alergología", 1, "POSITIVO - Maiz" },
                    { 16, new DateTime(2019, 11, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3793), "Alergología", 14, "POSITIVO - Gatos" },
                    { 15, new DateTime(2021, 11, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3790), "Prueba de cultivo fúngico", 13, "NEGATIVO" },
                    { 14, new DateTime(2021, 12, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3786), "Prueba de cultivo fúngico", 12, "POSITIVO" },
                    { 13, new DateTime(2022, 8, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3783), "Prueba de cristales en la orina", 11, "POSITIVO" },
                    { 12, new DateTime(2022, 10, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3779), "Hisopado nasal", 10, "POSITIVO - Covid19" },
                    { 11, new DateTime(2022, 12, 17, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3695), "Fluoroscopia", 9, "PENDIENTE" },
                    { 10, new DateTime(2023, 3, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3692), "Estudio del sueño", 8, "PENDIENTE" },
                    { 9, new DateTime(2022, 9, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3688), "Electrocardiograma", 7, "Ritmo cardiaco regular" },
                    { 8, new DateTime(2022, 9, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3685), "Ecografía", 6, "Bajo liquido amniotico" },
                    { 7, new DateTime(2021, 2, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3681), "Dióxido de carbono (CO2) en la sangre", 5, "Síndrome de Cushing" },
                    { 6, new DateTime(2024, 11, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3677), "Densitometría ósea", 4, "PENDIENTE" },
                    { 5, new DateTime(2022, 12, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3673), "Biopsia de ganglio centinela", 4, "PENDIENTE" },
                    { 4, new DateTime(2022, 1, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3669), "Análisis de sangre de glucagón", 3, "POSITIVO - Hipoglucemia" },
                    { 3, new DateTime(2021, 3, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3601), "Alergología", 2, "NO DETECTABLE" },
                    { 2, new DateTime(2022, 11, 13, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3550), "Amniocentesis", 1, "POSITIVO" },
                    { 17, new DateTime(2022, 8, 1, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3796), "Alergología", 14, "POSITIVO - Lactosa" },
                    { 18, new DateTime(2023, 11, 16, 23, 36, 29, 654, DateTimeKind.Local).AddTicks(3803), "Alergología", 15, "PENDIENTE" }
                });

            migrationBuilder.InsertData(
                table: "MedicosEstudios",
                columns: new[] { "Id", "EstudioId", "MedicoId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 6, 17, 8 },
                    { 3, 17, 2 },
                    { 5, 16, 8 },
                    { 2, 16, 2 },
                    { 25, 15, 10 },
                    { 24, 15, 11 },
                    { 23, 14, 9 },
                    { 22, 13, 7 },
                    { 21, 12, 6 },
                    { 20, 11, 5 },
                    { 4, 18, 8 },
                    { 19, 10, 4 },
                    { 17, 9, 11 },
                    { 16, 8, 10 },
                    { 15, 7, 8 },
                    { 14, 6, 7 },
                    { 13, 5, 6 },
                    { 12, 5, 4 },
                    { 11, 5, 9 },
                    { 10, 4, 5 },
                    { 9, 3, 2 },
                    { 8, 2, 1 },
                    { 18, 9, 3 },
                    { 7, 18, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudios_PacienteId",
                table: "Estudios",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicosEstudios_EstudioId",
                table: "MedicosEstudios",
                column: "EstudioId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicosEstudios_MedicoId",
                table: "MedicosEstudios",
                column: "MedicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicosEstudios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Estudios");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
