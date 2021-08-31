using Microsoft.EntityFrameworkCore.Migrations;

namespace InscripcionWeb.Migrations
{
    public partial class semillas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AñoCursados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    CarreraId = table.Column<int>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AñoCursados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AñoCursados_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    AñoCursadoId = table.Column<int>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materias_AñoCursados_AñoCursadoId",
                        column: x => x.AñoCursadoId,
                        principalTable: "AñoCursados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "Apellido", "Dni", "Eliminado", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Valle", 37454714, false, "ivanvallesj@gmail.com", "Carlos Ivan ", 3498459297.0 },
                    { 2, "Colombo", 38584798, false, "juancolombosj@gmail.com", "Juan Pablo ", 3498459299.0 },
                    { 3, "Córdoba", 38957452, false, "rami@gmail.com", "Ramiro ", 3498459298.0 },
                    { 4, "Sabino", 39625852, false, "mati@gmail.com", "Matias ", 3498459295.0 },
                    { 5, "Mangini", 37154825, false, "jere@gmail.com", "Jeremias  ", 3498459294.0 },
                    { 6, " Paulon ", 37124896, false, "corado@gmail.com", "Conrado", 3498459293.0 },
                    { 7, " Gomez ", 38957412, false, "nahuel@gmail.com", "Nahuel", 3498459292.0 },
                    { 8, " Barreto", 39658745, false, "santi@gmail.com", "Santiago", 3498459291.0 }
                });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 7, false, "Profesorado de Educación Secundaria en Economía" },
                    { 6, false, "Profesorado de Educación Inicial" },
                    { 5, false, "Profesorado de Educación Secundaria en Ciencias de la Administración" },
                    { 1, false, "Tecnicatura Superior en Desarrollo de Software" },
                    { 3, false, "Tecnicatura Superior en Gestion de las Organizaciones" },
                    { 2, false, "Tecnicatura Superior en Soporte de Infraestructura" },
                    { 8, false, "Profesorado de Educación Tecnológica" },
                    { 4, false, "Tecnicatura Superior en Enfermeria" },
                    { 9, false, "Licenciatura en Cooperativismo y Mutualismo" }
                });

            migrationBuilder.InsertData(
                table: "AñoCursados",
                columns: new[] { "Id", "CarreraId", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, false, "Primero" },
                    { 27, 8, false, "Tercero" },
                    { 26, 8, false, "Segundo" },
                    { 25, 8, false, "Primero" },
                    { 24, 7, false, "Cuarto" },
                    { 23, 7, false, "Tercero" },
                    { 22, 7, false, "Segundo" },
                    { 21, 7, false, "Primero" },
                    { 20, 6, false, "Cuarto" },
                    { 19, 6, false, "Tercero" },
                    { 18, 6, false, "Segundo" },
                    { 17, 6, false, "Primero" },
                    { 16, 5, false, "Cuarto" },
                    { 28, 8, false, "Cuarto" },
                    { 15, 5, false, "Tercero" },
                    { 13, 5, false, "Primero" },
                    { 12, 4, false, "Tercero" },
                    { 11, 4, false, "Segundo" },
                    { 10, 4, false, "Primero" },
                    { 9, 3, false, "Tercero" },
                    { 8, 3, false, "Segundo" },
                    { 7, 3, false, "Primero" },
                    { 6, 2, false, "Tercero" },
                    { 5, 2, false, "Segundo" },
                    { 4, 2, false, "Primero" },
                    { 3, 1, false, "Tercero" },
                    { 2, 1, false, "Segundo" },
                    { 14, 5, false, "Segundo" },
                    { 29, 9, false, "Primero" }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "Id", "AñoCursadoId", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 92, 1, false, "Comunicación (1° cuat.)" },
                    { 211, 19, false, "Historia Social de la Educación y Política Educativa Argentina" },
                    { 212, 19, false, "Trayecto de Práctica III: Seminario de Instituciones Educativas" },
                    { 213, 19, false, "Matemática y su Didáctica II" },
                    { 214, 19, false, "Lengua y su Didáctica (1º cuatr.)" },
                    { 215, 19, false, "Alfabetización Inicial (2º cuatr.)" },
                    { 216, 19, false, "Ciencias Sociales y su Didáctica" },
                    { 217, 19, false, "Área Estético-Expresiva II" },
                    { 218, 19, false, "Problemáticas Contemporáneas de la Educación Inicial II (1º cuatr.)" },
                    { 219, 19, false, "Didáctica de la Educación Inicial II (2º cuatr.)" },
                    { 220, 19, false, "Espacios de Definición Institucional (1º cuatr.)" },
                    { 221, 19, false, "Espacios de Definición Institucional (2º cuatr.)" },
                    { 222, 19, false, "Itinerarios por el Mundo de la Cultura" },
                    { 223, 19, false, "Producción Pedagógica" },
                    { 224, 20, false, "Ética, Trabajo Docente, Derechos Humanos y Ciudadanos" },
                    { 225, 20, false, "Taller de Práctica IV" },
                    { 226, 20, false, "Ateneo: (Matemática- Ambiente y Sociedad (Ciencias Naturales- Ciencias Sociales) Lengua y Literatura- Formación Ètica y Ciudadana)" },
                    { 227, 20, false, "Sexualidad Humana y Educación  (1º cuatr.)" },
                    { 228, 20, false, "Itinerarios por el Mundo de la Cultura" },
                    { 229, 20, false, "Producción Pedagógica" },
                    { 230, 21, false, "Pedagogía" },
                    { 231, 21, false, "UCCV Sociología" },
                    { 232, 21, false, "Administración General" },
                    { 233, 21, false, "Economía I" },
                    { 234, 21, false, "Geografía Económica" },
                    { 235, 21, false, "Historia Económica" },
                    { 236, 21, false, "Construcción de Ciudadanía" },
                    { 237, 21, false, "Sistema de Información Contable I" },
                    { 238, 21, false, "Administración General" },
                    { 239, 21, false, "Matemática" },
                    { 210, 19, false, "Tecnologías de la Información y de la Comunicación" },
                    { 209, 18, false, "Producción Pedagógica" },
                    { 208, 18, false, "Itinerarios por el Mundo de la Cultura" },
                    { 207, 18, false, "Ciencias Naturales y su Didáctica" },
                    { 177, 16, false, "UCCV Comunicación Social" },
                    { 178, 16, false, "Administración IV" },
                    { 179, 16, false, "Gestión Organizacional" },
                    { 180, 16, false, "Matemática Financiera" },
                    { 181, 16, false, "Prácticas de Investigación" },
                    { 182, 16, false, "Práctica Docente IV (Residencia)" },
                    { 183, 16, false, "Producción de los Recursos Didácticos II" },
                    { 184, 16, false, "Unidad de Definición Institucional" },
                    { 185, 17, false, "Psicología y Educación" },
                    { 186, 17, false, "Pedagogia" },
                    { 187, 17, false, "Sociología de la Educación" },
                    { 188, 17, false, "Historia Argentina y Latinoamericana(1º cuatr.)" },
                    { 189, 17, false, "Movimiento y Cuerpo I" },
                    { 190, 17, false, "Taller de Práctica I" },
                    { 240, 21, false, "Práctica Docente I" },
                    { 191, 17, false, "Problemáticas Contemporáneas de la Educación Inicial I" },
                    { 193, 17, false, "Resolución de Problemas y Creatividad (1º cuatr.)" },
                    { 194, 17, false, "Ambiente y Sociedad (2º cuatr.)" },
                    { 195, 17, false, "Área Estético-Expresiva I" },
                    { 196, 17, false, "Itinerarios por el Mundo de la Cultura" },
                    { 197, 17, false, "Producción Pedagógica" },
                    { 198, 18, false, "Didáctica General" },
                    { 199, 18, false, "Filosofía de la Educación (1º cuatr.)" },
                    { 200, 18, false, "Conocimiento y Educación (2º cuatr.)" },
                    { 201, 18, false, "Movimiento y Cuerpo II" },
                    { 202, 18, false, "Taller de Práctica II: Seminario de lo Grupal y los Grupos de Aprendizaje" },
                    { 203, 18, false, "Sujeto de la Educación Inicial" },
                    { 204, 18, false, "Didáctica de Educación Inicial I" },
                    { 205, 18, false, "Matemática y su Didáctica I" },
                    { 206, 18, false, "Literatura y su Didáctica" },
                    { 192, 17, false, "Comunicación y Expresión Oral y Esctrita" },
                    { 176, 16, false, "Educación Sexual Integral" },
                    { 241, 22, false, "Instituciones Educativas" },
                    { 243, 22, false, "Psicología y Educación" },
                    { 10, 26, false, "Didáctica y Curriculum" },
                    { 11, 26, false, "Instituciones Educativas" },
                    { 12, 26, false, "Práctica Docente II: La Institución Escolar" },
                    { 13, 26, false, "Sujetos de la Educación I" },
                    { 14, 26, false, "Tic para la Enseñanza" },
                    { 15, 26, false, "Procesos Productivos" },
                    { 16, 26, false, "Tecnológica II" },
                    { 17, 26, false, "Didáctica Específica I" },
                    { 18, 27, false, "Filosofía y Educación" },
                    { 19, 27, false, "Historia Social de la Educación" },
                    { 20, 27, false, "Metodología de la Investigación" },
                    { 21, 27, false, "Práctica Docente III: La Clase" },
                    { 22, 27, false, "Sujetos de la Educación II" },
                    { 23, 27, false, "Materiales" },
                    { 24, 27, false, "Química " },
                    { 25, 27, false, "Procesos de Control" },
                    { 26, 27, false, "Tecnologías Regionales " },
                    { 27, 27, false, "Diseño y Producción" },
                    { 28, 27, false, "Tecnológica III" },
                    { 29, 27, false, "Didáctica Específica II" },
                    { 30, 28, false, "Ética y Trabajo Docente" },
                    { 31, 28, false, "Educación Sexual Integral" },
                    { 32, 28, false, "Unidades de Definición Institucional I" },
                    { 33, 28, false, "Unidades de Definición Institucional II" },
                    { 34, 28, false, "Prácticas de Investigación" },
                    { 35, 28, false, "Práctica Docente IV: El Rol Docente y su Práctica" },
                    { 36, 28, false, "Biotecnología " },
                    { 37, 28, false, "Procesos de Comunicación " },
                    { 38, 28, false, "Problemáticas Sociotécnicas " },
                    { 9, 26, false, "Psicología de la Educación" },
                    { 8, 25, false, "Física" },
                    { 7, 25, false, "Matemática" },
                    { 6, 25, false, "Diseño y Producción de la Técnología 1" },
                    { 244, 22, false, "Economía II" },
                    { 245, 22, false, "Sistema de Información Contable II" },
                    { 246, 22, false, "Derecho I" },
                    { 247, 22, false, "Economía" },
                    { 248, 22, false, "Estadística Aplicada" },
                    { 249, 22, false, "Didáctica de la Economía I" },
                    { 250, 22, false, "Práctica Docencia II" },
                    { 251, 23, false, "Historia y Política de la Educación Argentina" },
                    { 252, 23, false, "Filosofía" },
                    { 253, 23, false, "Metodología de la Investigación" },
                    { 254, 23, false, "Economía III" },
                    { 255, 23, false, "Finanzas Públicas" },
                    { 256, 23, false, "Derecho II" },
                    { 257, 23, false, "Sujetos de la Educación Secundaria " },
                    { 242, 22, false, "Didáctica y Curriculum" },
                    { 258, 23, false, "Práctica Docente III" },
                    { 260, 24, false, "Ética y Trabajo Docente" },
                    { 261, 24, false, "Educación Sexual Integral" },
                    { 262, 24, false, "UCCV Comunicación Social" },
                    { 263, 24, false, "Economía Social y Sostenible" },
                    { 264, 24, false, "Economía Argentina Latinoamericana e Internacional" },
                    { 265, 24, false, "Prácticas de Investigación" },
                    { 266, 24, false, "Práctica Docente IV (Residencia)" },
                    { 267, 24, false, "Producción de los Recursos Didácticos II" },
                    { 268, 24, false, "Unidad de Definición Institucional" },
                    { 1, 25, false, "Pedagogía" },
                    { 2, 25, false, "Movimiento y Cuerpo" },
                    { 3, 25, false, "Práctica Docente I: Escenarios Educativos" },
                    { 4, 25, false, "Introducción a la Tecnología" },
                    { 5, 25, false, "Historia de la Tecnología" },
                    { 259, 23, false, "Producción de los Recursos Didácticos I" },
                    { 175, 16, false, "Ética y Trabajo Docente" },
                    { 174, 15, false, "Producción de los Recursos Didácticos I" },
                    { 173, 15, false, "Práctica Docente III" },
                    { 76, 5, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 77, 5, false, "Innovación y Desarrollo Emprendedor" },
                    { 78, 5, false, "Estadística" },
                    { 79, 5, false, "Sistemas Operativos" },
                    { 80, 5, false, "Algoritmos y Estructuras de Datos" },
                    { 81, 5, false, "Base de Datos" },
                    { 82, 5, false, "Infraestructura de Datos II" },
                    { 83, 5, false, "Práctica Profesionalizante I" },
                    { 84, 6, false, "Ética y Responsabilidad Social" },
                    { 85, 6, false, "Derecho y Legislación Laboral" },
                    { 86, 6, false, "Administración de Base de Datos" },
                    { 87, 6, false, "Integridad y Migración de Datos" },
                    { 88, 6, false, "Seguridad de los Sistemas" },
                    { 89, 6, false, "Administración de Sistemas" },
                    { 90, 6, false, "Operativos y Redes" },
                    { 91, 6, false, "Práctica Profesionalizante II" },
                    { 117, 7, false, "Comunicación (1° cuat.)" },
                    { 118, 7, false, "Unidad de Definición Institucional (2° cuat.)" },
                    { 119, 7, false, "Economía " },
                    { 120, 7, false, "Matemática y Estadística" },
                    { 121, 7, false, "Contabilidad" },
                    { 122, 7, false, "Informática " },
                    { 123, 7, false, "Administración " },
                    { 124, 7, false, "Gestión de la Producción " },
                    { 125, 7, false, "Gestión del Talento " },
                    { 126, 7, false, "Humano" },
                    { 127, 8, false, "Problemáticas Contemporáneas" },
                    { 128, 8, false, "Unidad de Definición Institucional II (2° cuat.)" },
                    { 129, 8, false, "Innovación y Desarrollo Emprendedor" },
                    { 75, 5, false, "Problemáticas Socio Contemporáneas (1° cuat.)" },
                    { 74, 4, false, "Infraestructura de Redes I" },
                    { 73, 4, false, "Lógica y Programación" },
                    { 72, 4, false, "Arquitectura de las Computadoras" },
                    { 93, 1, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 94, 1, false, "Matemática" },
                    { 95, 1, false, "Inglés Técnico I" },
                    { 96, 1, false, "Administración" },
                    { 97, 1, false, "Tecnología de la Información" },
                    { 98, 1, false, "Lógica y Estructura de Datos" },
                    { 99, 1, false, "Ingeniería de Software I" },
                    { 100, 1, false, "Sistemas Operativos" },
                    { 101, 2, false, "Problemáticas Socio Contemporáneas (1° cuat.)" },
                    { 102, 2, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 103, 2, false, "Inglés Técnico II" },
                    { 104, 2, false, "Innovación y Desarrollo Emprendedor" },
                    { 105, 2, false, "Estadística" },
                    { 106, 2, false, "Programación I" },
                    { 130, 8, false, "Inglés Técnico" },
                    { 107, 2, false, "Ingeniería de Software II" },
                    { 109, 2, false, "Práctica Profesionalizante I" },
                    { 110, 3, false, "Ética y Responsabilidad Social" },
                    { 111, 3, false, "Derecho y Legislación Laboral " },
                    { 112, 3, false, "Redes y Comunicación" },
                    { 113, 3, false, "Programación II" },
                    { 114, 3, false, "Gestión de Proyectos de Software" },
                    { 115, 3, false, "Base de Datos II" },
                    { 116, 3, false, "Práctica Profesionalizante II" },
                    { 66, 4, false, "Comunicación (1° cuat.)" },
                    { 67, 4, false, "Unidad de definición Institucional (2° cuat.)" },
                    { 68, 4, false, "Matemática" },
                    { 69, 4, false, "Física Aplicada a las Tecnologías de la Información" },
                    { 70, 4, false, "Administración" },
                    { 71, 4, false, "Inglés Técnico" },
                    { 108, 2, false, "Base de Datos I" },
                    { 131, 8, false, "Legislación Comercial y Tributaria " },
                    { 132, 8, false, "Gestión de Comercialización e Investigación Comercia" },
                    { 133, 8, false, "Gestión de Costos" },
                    { 64, 12, false, "Cuidados de Enfermería al Niño y al Adolescente" },
                    { 65, 12, false, "Práctica Profesionalizante III" },
                    { 145, 13, false, "Pedagogía" },
                    { 146, 13, false, "UCCV Sociología" },
                    { 147, 13, false, "Administración General" },
                    { 148, 13, false, "Administración I" },
                    { 149, 13, false, "Sistema de Información Contable I" },
                    { 150, 13, false, "Construcción de Ciudadanía" },
                    { 151, 13, false, "Historia Económica" },
                    { 152, 13, false, "Matemática" },
                    { 153, 13, false, "Práctica Docente I" },
                    { 154, 14, false, "Instituciones Educativas" },
                    { 155, 14, false, "Didáctica y Curriculum" },
                    { 156, 14, false, "Psicología y Educación" },
                    { 63, 12, false, "Cuidados de Enfermería en Salud Mental" },
                    { 157, 14, false, "Administración II" },
                    { 159, 14, false, "Derecho I" },
                    { 160, 14, false, "Economía" },
                    { 161, 14, false, "Estadística Aplicada" },
                    { 162, 14, false, "Didáctica de la Administración I" },
                    { 163, 14, false, "Práctica Docencia II" },
                    { 164, 15, false, "Historia y Política de la Educación Argentina " },
                    { 165, 15, false, "Filosofía" },
                    { 166, 15, false, "Metodología de la Investigación" },
                    { 167, 15, false, "Administración III" },
                    { 168, 15, false, "Sistema de Información Contable III" },
                    { 169, 15, false, "Práctica Impositiva y Laboral" },
                    { 170, 15, false, "Derecho II" },
                    { 171, 15, false, "Didáctica de la Administración II" },
                    { 172, 15, false, "Sujetos de la Educación Secundaria" },
                    { 158, 14, false, "Sistema de Información Contable II" },
                    { 39, 28, false, "Diseño y Producción Tecnológica IV" },
                    { 62, 12, false, "Investigación en Enfermería" },
                    { 60, 12, false, "Inglés Técnico" },
                    { 134, 8, false, "Gestión Contable" },
                    { 135, 8, false, "Práctica Profesionalizante I" },
                    { 136, 9, false, "Gestión de Seguridad, Salud Ocupacional y Medio Ambiente" },
                    { 137, 9, false, "Ética y Responsabilidad Social" },
                    { 138, 9, false, "Legislación Laboral" },
                    { 139, 9, false, "Estrategia Empresarial" },
                    { 140, 9, false, "Sistema de Información para la Gestión de las Organizaciones " },
                    { 141, 9, false, "Gestión Financiera" },
                    { 142, 9, false, "Evaluación y Administración de Proyectos de Inversión" },
                    { 143, 9, false, "Control de Gestión" },
                    { 144, 9, false, "Practicas Profesionalizante II" },
                    { 41, 10, false, "Comunicación" },
                    { 42, 10, false, "Unidad de Definición Institucional I" },
                    { 43, 10, false, "Salud Pública" },
                    { 61, 12, false, "Organización y Gestión en Instituciones de Salud" },
                    { 44, 10, false, "Biología Humana I" },
                    { 46, 10, false, "Fundaméntos del Cuidado en Enfermería" },
                    { 47, 10, false, "Cuidados de Enfermería en la Comunidad y en la Familia" },
                    { 48, 10, false, "Práctica Profesionalizante I" },
                    { 49, 11, false, "Problemáticas Socio Contemporáneas" },
                    { 50, 11, false, "Unidad de Definición Institucional II" },
                    { 51, 11, false, "Informática en Salud" },
                    { 52, 11, false, "Sujeto, Cultura y Sociedad II" },
                    { 53, 11, false, "Biología Humana II" },
                    { 54, 11, false, "Bioseguridad y Medio Ambiente en el Trabajo" },
                    { 55, 11, false, "Farmacología en Enfermería" },
                    { 56, 11, false, "Cuidados de Enfermería a los Adultos y Adultos Mayores" },
                    { 57, 11, false, "Práctica Profesionalizante II" },
                    { 58, 12, false, "Ética y Responsabilidad Social" },
                    { 59, 12, false, "Derecho y Legislación Laboral" },
                    { 45, 10, false, "Sujeto, Cultura y Sociedad I" },
                    { 40, 28, false, "Taller de Producción Didáctica" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AñoCursados_CarreraId",
                table: "AñoCursados",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_AñoCursadoId",
                table: "Materias",
                column: "AñoCursadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "AñoCursados");

            migrationBuilder.DropTable(
                name: "Carreras");
        }
    }
}
