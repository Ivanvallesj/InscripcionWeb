using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InscripcionWeb.Models;

namespace InscripcionWeb.Data
{
    public class InscripcionWebContext : DbContext
    {
        public InscripcionWebContext (DbContextOptions<InscripcionWebContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database = InscripcionWebContext; User Id = adminzapateria; Password = 1234; MultipleActiveResultSets = True; ");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region datos semillas de carreras
            var tsds = new Carrera { Id = 1, Nombre = "Tecnicatura Superior en Desarrollo de Software" };
            var tssi = new Carrera { Id = 2, Nombre = "Tecnicatura Superior en Soporte de Infraestructura" };
            var tsgo = new Carrera { Id = 3, Nombre = "Tecnicatura Superior en Gestion de las Organizaciones" };
            var tse = new Carrera { Id = 4, Nombre = "Tecnicatura Superior en Enfermeria" };
            var pesca = new Carrera { Id = 5, Nombre = "Profesorado de Educación Secundaria en Ciencias de la Administración" };
            var pei = new Carrera { Id = 6, Nombre = "Profesorado de Educación Inicial" };
            var pese = new Carrera { Id = 7, Nombre = "Profesorado de Educación Secundaria en Economía" };
            var pet = new Carrera { Id = 8, Nombre = "Profesorado de Educación Tecnológica" };
            var lcm = new Carrera { Id = 9, Nombre = "Licenciatura en Cooperativismo y Mutualismo" };

            modelBuilder.Entity<Carrera>().HasData(tsds, tssi, tsgo, tse, pesca, pei, pese, pet, lcm);
            #endregion
            #region datos semillas años de cursado
            //TECNICO SUPERIOR EN DESARROLLO DE SOFTWARE
            var ac1 = new AñoCursado { Id = 1, CarreraId = 1, Nombre = "Primero" };
            var ac2 = new AñoCursado { Id = 2, CarreraId = 1, Nombre = "Segundo" };
            var ac3 = new AñoCursado { Id = 3, CarreraId = 1, Nombre = "Tercero" };
            //Tecnicatura Superior en Soporte de Infraestructura
            var ac4 = new AñoCursado { Id = 4, CarreraId = 2, Nombre = "Primero" };
            var ac5 = new AñoCursado { Id = 5, CarreraId = 2, Nombre = "Segundo" };
            var ac6 = new AñoCursado { Id = 6, CarreraId = 2, Nombre = "Tercero" };
            //Tecnicatura Superior en Gestion de las Organizaciones
            var ac7 = new AñoCursado { Id = 7, CarreraId = 3, Nombre = "Primero" };
            var ac8 = new AñoCursado { Id = 8, CarreraId = 3, Nombre = "Segundo" };
            var ac9 = new AñoCursado { Id = 9, CarreraId = 3, Nombre = "Tercero" };
            //Tecnicatura Superior en Enfermeria
            var ac10 = new AñoCursado { Id = 10, CarreraId = 4, Nombre = "Primero" };
            var ac11 = new AñoCursado { Id = 11, CarreraId = 4, Nombre = "Segundo" };
            var ac12 = new AñoCursado { Id = 12, CarreraId = 4, Nombre = "Tercero" };
            //Profesorado de Educación Secundaria en Ciencias de la Administración
            var ac13 = new AñoCursado { Id = 13, CarreraId = 5, Nombre = "Primero" };
            var ac14 = new AñoCursado { Id = 14, CarreraId = 5, Nombre = "Segundo" };
            var ac15 = new AñoCursado { Id = 15, CarreraId = 5, Nombre = "Tercero" };
            var ac16 = new AñoCursado { Id = 16, CarreraId = 5, Nombre = "Cuarto" };
            //Profesorado de Educación Inicial
            var ac17 = new AñoCursado { Id = 17, CarreraId = 6, Nombre = "Primero" };
            var ac18 = new AñoCursado { Id = 18, CarreraId = 6, Nombre = "Segundo" };
            var ac19 = new AñoCursado { Id = 19, CarreraId = 6, Nombre = "Tercero" };
            var ac20 = new AñoCursado { Id = 20, CarreraId = 6, Nombre = "Cuarto" };
            //Profesorado de Educación Secundaria en Economía
            var ac21 = new AñoCursado { Id = 21, CarreraId = 7, Nombre = "Primero" };
            var ac22 = new AñoCursado { Id = 22, CarreraId = 7, Nombre = "Segundo" };
            var ac23 = new AñoCursado { Id = 23, CarreraId = 7, Nombre = "Tercero" };
            var ac24 = new AñoCursado { Id = 24, CarreraId = 7, Nombre = "Cuarto" };
            //Profesorado de Educación Tecnológica
            var ac25 = new AñoCursado { Id = 25, CarreraId = 8, Nombre = "Primero" };
            var ac26 = new AñoCursado { Id = 26, CarreraId = 8, Nombre = "Segundo" };
            var ac27 = new AñoCursado { Id = 27, CarreraId = 8, Nombre = "Tercero" };
            var ac28 = new AñoCursado { Id = 28, CarreraId = 8, Nombre = "Cuarto" };
            //Licenciatura en Cooperativismo y Mutualismo
            var ac29 = new AñoCursado { Id = 29, CarreraId = 9, Nombre = "Primero" };
            modelBuilder.Entity<AñoCursado>().HasData(
                ac1, ac2, ac3, ac4, ac5, ac6, ac7, ac8, ac9, ac10, ac11, ac12, ac13, ac14,
                ac15, ac16, ac17, ac18, ac19, ac20, ac21, ac22, ac23, ac24, ac25, ac26, ac27,
                ac28, ac29
                );
            #endregion
            #region datos semilla materias
            #region MATERIA Profesorado de Educación Tecnológica
            //Profesorado de Educación Tecnológica
            //1er Año
            var ped = new Materia { Id = 1, Nombre = "Pedagogía", AñoCursadoId = 25 };
            var myc = new Materia { Id = 2, Nombre = "Movimiento y Cuerpo", AñoCursadoId = 25 };
            var pd1 = new Materia { Id = 3, Nombre = "Práctica Docente I: Escenarios Educativos", AñoCursadoId = 25 };
            var it = new Materia { Id = 4, Nombre = "Introducción a la Tecnología", AñoCursadoId = 25 };
            var ht = new Materia { Id = 5, Nombre = "Historia de la Tecnología", AñoCursadoId = 25 };
            var dpt = new Materia { Id = 6, Nombre = "Diseño y Producción de la Técnología 1", AñoCursadoId = 25 };
            var mat = new Materia { Id = 7, Nombre = "Matemática", AñoCursadoId = 25 };
            var fis = new Materia { Id = 8, Nombre = "Física", AñoCursadoId = 25 };
            //2do Año
            var pe = new Materia { Id = 9, Nombre = "Psicología de la Educación", AñoCursadoId = 26 };
            var dyc = new Materia { Id = 10, Nombre = "Didáctica y Curriculum", AñoCursadoId = 26 };
            var ie = new Materia { Id = 11, Nombre = "Instituciones Educativas", AñoCursadoId = 26 };
            var pd2 = new Materia { Id = 12, Nombre = "Práctica Docente II: La Institución Escolar", AñoCursadoId = 26 };
            var se1 = new Materia { Id = 13, Nombre = "Sujetos de la Educación I", AñoCursadoId = 26 };
            var te = new Materia { Id = 14, Nombre = "Tic para la Enseñanza", AñoCursadoId = 26 };
            var pp = new Materia { Id = 15, Nombre = "Procesos Productivos", AñoCursadoId = 26 };
            var t2 = new Materia { Id = 16, Nombre = "Tecnológica II", AñoCursadoId = 26 };
            var de1 = new Materia { Id = 17, Nombre = "Didáctica Específica I", AñoCursadoId = 26 };
            //3er Año
            var fye = new Materia { Id = 18, Nombre = "Filosofía y Educación", AñoCursadoId = 27 };
            var hse = new Materia { Id = 19, Nombre = "Historia Social de la Educación", AñoCursadoId = 27 };
            var mdi = new Materia { Id = 20, Nombre = "Metodología de la Investigación", AñoCursadoId = 27 };
            var pd3 = new Materia { Id = 21, Nombre = "Práctica Docente III: La Clase", AñoCursadoId = 27 };
            var se2 = new Materia { Id = 22, Nombre = "Sujetos de la Educación II", AñoCursadoId = 27 };
            var mater = new Materia { Id = 23, Nombre = "Materiales", AñoCursadoId = 27 };
            var qui = new Materia { Id = 24, Nombre = "Química ", AñoCursadoId = 27 };
            var pdc = new Materia { Id = 25, Nombre = "Procesos de Control", AñoCursadoId = 27 };
            var tecr = new Materia { Id = 26, Nombre = "Tecnologías Regionales ", AñoCursadoId = 27 };
            var dypr = new Materia { Id = 27, Nombre = "Diseño y Producción", AñoCursadoId = 27 };
            var tec3 = new Materia { Id = 28, Nombre = "Tecnológica III", AñoCursadoId = 27 };
            var de2 = new Materia { Id = 29, Nombre = "Didáctica Específica II", AñoCursadoId = 27 };
            //4to Año
            var eytd = new Materia { Id = 30, Nombre = "Ética y Trabajo Docente", AñoCursadoId = 28 };
            var esi = new Materia { Id = 31, Nombre = "Educación Sexual Integral", AñoCursadoId = 28 };
            var udi1 = new Materia { Id = 32, Nombre = "Unidades de Definición Institucional I", AñoCursadoId = 28 };
            var udi2 = new Materia { Id = 33, Nombre = "Unidades de Definición Institucional II", AñoCursadoId = 28 };
            var pdi = new Materia { Id = 34, Nombre = "Prácticas de Investigación", AñoCursadoId = 28 };
            var pd4 = new Materia { Id = 35, Nombre = "Práctica Docente IV: El Rol Docente y su Práctica", AñoCursadoId = 28 };
            var biotec = new Materia { Id = 36, Nombre = "Biotecnología ", AñoCursadoId = 28 };
            var pdco = new Materia { Id = 37, Nombre = "Procesos de Comunicación ", AñoCursadoId = 28 };
            var pst = new Materia { Id = 38, Nombre = "Problemáticas Sociotécnicas ", AñoCursadoId = 28 };
            var dyp4 = new Materia { Id = 39, Nombre = "Diseño y Producción Tecnológica IV", AñoCursadoId = 28 };
            var tdpd = new Materia { Id = 40, Nombre = "Taller de Producción Didáctica", AñoCursadoId = 28 };

            modelBuilder.Entity<Materia>().HasData(
                ped, myc, pd1, it, ht, dpt, mat, fis,
                pe, dyc, ie, pd2, se1, te, pp, t2, de1,
                fye, hse, mdi, pd3, se2, mater, qui, pdc, tecr, dypr, tec3, de2,
                eytd, esi, udi1, udi2, pdi, pd4, biotec, pdco, pst, dyp4, tdpd
                );
            #endregion
            #region MATERIA Prfesorado de enfermeria
            //1er Año
            var com = new Materia { Id = 41, Nombre = "Comunicación", AñoCursadoId = 10 };
            var udii1 = new Materia { Id = 42, Nombre = "Unidad de Definición Institucional I", AñoCursadoId = 10 };
            var sp = new Materia { Id = 43, Nombre = "Salud Pública", AñoCursadoId = 10 };
            var bh1 = new Materia { Id = 44, Nombre = "Biología Humana I", AñoCursadoId = 10 };
            var scs1 = new Materia { Id = 45, Nombre = "Sujeto, Cultura y Sociedad I", AñoCursadoId = 10 };
            var fce = new Materia { Id = 46, Nombre = "Fundaméntos del Cuidado en Enfermería", AñoCursadoId = 10 };
            var cecf = new Materia { Id = 47, Nombre = "Cuidados de Enfermería en la Comunidad y en la Familia", AñoCursadoId = 10 };
            var pp1 = new Materia { Id = 48, Nombre = "Práctica Profesionalizante I", AñoCursadoId = 10 };

            //2do Año
            var psc = new Materia { Id = 49, Nombre = "Problemáticas Socio Contemporáneas", AñoCursadoId = 11 };
            var udii2 = new Materia { Id = 50, Nombre = "Unidad de Definición Institucional II", AñoCursadoId = 11 };
            var ies = new Materia { Id = 51, Nombre = "Informática en Salud", AñoCursadoId = 11 };
            var scs2 = new Materia { Id = 52, Nombre = "Sujeto, Cultura y Sociedad II", AñoCursadoId = 11 };
            var bh2 = new Materia { Id = 53, Nombre = "Biología Humana II", AñoCursadoId = 11 };
            var bmat = new Materia { Id = 54, Nombre = "Bioseguridad y Medio Ambiente en el Trabajo", AñoCursadoId = 11 };
            var fee = new Materia { Id = 55, Nombre = "Farmacología en Enfermería", AñoCursadoId = 11 };
            var ceaam = new Materia { Id = 56, Nombre = "Cuidados de Enfermería a los Adultos y Adultos Mayores", AñoCursadoId = 11 };
            var pp2 = new Materia { Id = 57, Nombre = "Práctica Profesionalizante II", AñoCursadoId = 11 };

            //3er Año
            var ers = new Materia { Id = 58, Nombre = "Ética y Responsabilidad Social", AñoCursadoId = 12 };
            var dll = new Materia { Id = 59, Nombre = "Derecho y Legislación Laboral", AñoCursadoId = 12 };
            var ingtec = new Materia { Id = 60, Nombre = "Inglés Técnico", AñoCursadoId = 12 };
            var ogis = new Materia { Id = 61, Nombre = "Organización y Gestión en Instituciones de Salud", AñoCursadoId = 12 };
            var iee = new Materia { Id = 62, Nombre = "Investigación en Enfermería", AñoCursadoId = 12 };
            var cesm = new Materia { Id = 63, Nombre = "Cuidados de Enfermería en Salud Mental", AñoCursadoId = 12 };
            var cena = new Materia { Id = 64, Nombre = "Cuidados de Enfermería al Niño y al Adolescente", AñoCursadoId = 12 };
            var pp3 = new Materia { Id = 65, Nombre = "Práctica Profesionalizante III", AñoCursadoId = 12 };

            modelBuilder.Entity<Materia>().HasData(
                com, udii1, sp, bh1, scs1, fce, cecf, pp1,
                psc, udii2, ies, scs2, bh2, bmat, fee, ceaam, pp2,
                ers, dll, ingtec, ogis, iee, cesm, cena, pp3
                );
            #endregion
            #region MATERIA Tec. Sup. en Soporte de Inf. en Tec. de la Información
            //1er Año
            var com1 = new Materia { Id = 66, Nombre = "Comunicación (1° cuat.)", AñoCursadoId = 4 };
            var udi = new Materia { Id = 67, Nombre = "Unidad de definición Institucional (2° cuat.)", AñoCursadoId = 4 };
            var mate = new Materia { Id = 68, Nombre = "Matemática", AñoCursadoId = 4 };
            var fati = new Materia { Id = 69, Nombre = "Física Aplicada a las Tecnologías de la Información", AñoCursadoId = 4 };
            var adm = new Materia { Id = 70, Nombre = "Administración", AñoCursadoId = 4 };
            var igtec = new Materia { Id = 71, Nombre = "Inglés Técnico", AñoCursadoId = 4 };
            var arqc = new Materia { Id = 72, Nombre = "Arquitectura de las Computadoras", AñoCursadoId = 4 };
            var logyprog = new Materia { Id = 73, Nombre = "Lógica y Programación", AñoCursadoId = 4 };
            var ir1 = new Materia { Id = 74, Nombre = "Infraestructura de Redes I", AñoCursadoId = 4 };

            //2do Año
            var pscont = new Materia { Id = 75, Nombre = "Problemáticas Socio Contemporáneas (1° cuat.)", AñoCursadoId = 5 };
            var udinst = new Materia { Id = 76, Nombre = "Unidad de definición Institucional (2° cuat.)", AñoCursadoId = 5 };
            var ide = new Materia { Id = 77, Nombre = "Innovación y Desarrollo Emprendedor", AñoCursadoId = 5 };
            var est = new Materia { Id = 78, Nombre = "Estadística", AñoCursadoId = 5 };
            var sisope = new Materia { Id = 79, Nombre = "Sistemas Operativos", AñoCursadoId = 5 };
            var aed = new Materia { Id = 80, Nombre = "Algoritmos y Estructuras de Datos", AñoCursadoId = 5 };
            var bbdd = new Materia { Id = 81, Nombre = "Base de Datos", AñoCursadoId = 5 };
            var id2 = new Materia { Id = 82, Nombre = "Infraestructura de Datos II", AñoCursadoId = 5 };
            var pracprof1 = new Materia { Id = 83, Nombre = "Práctica Profesionalizante I", AñoCursadoId = 5 };

            //3er Año
            var ersocial = new Materia { Id = 84, Nombre = "Ética y Responsabilidad Social", AñoCursadoId = 6 };
            var dllab = new Materia { Id = 85, Nombre = "Derecho y Legislación Laboral", AñoCursadoId = 6 };
            var abd = new Materia { Id = 86, Nombre = "Administración de Base de Datos", AñoCursadoId = 6 };
            var imd = new Materia { Id = 87, Nombre = "Integridad y Migración de Datos", AñoCursadoId = 6 };
            var sdls = new Materia { Id = 88, Nombre = "Seguridad de los Sistemas", AñoCursadoId = 6 };
            var admsis = new Materia { Id = 89, Nombre = "Administración de Sistemas", AñoCursadoId = 6 };
            var oyr = new Materia { Id = 90, Nombre = "Operativos y Redes", AñoCursadoId = 6 };
            var pprof2 = new Materia { Id = 91, Nombre = "Práctica Profesionalizante II", AñoCursadoId = 6 };

            modelBuilder.Entity<Materia>().HasData(
                com1, udi, mate, fati, adm, igtec, arqc, logyprog, ir1,
                pscont, udinst, ide, est, sisope, aed, bbdd, id2, pracprof1,
                ersocial, dllab, abd, imd, sdls, admsis, oyr, pprof2);

            #endregion
            #region MATERIA Tecnicatura Superior en Desarrollo de Software
            //1er Año
            var comu = new Materia { Id = 92, Nombre = "Comunicación (1° cuat.)", AñoCursadoId = 1 };
            var udins = new Materia { Id = 93, Nombre = "Unidad de definición Institucional (2° cuat.)", AñoCursadoId = 1 };
            var matem = new Materia { Id = 94, Nombre = "Matemática", AñoCursadoId = 1 };
            var ingtec1 = new Materia { Id = 95, Nombre = "Inglés Técnico I", AñoCursadoId = 1 };
            var admi = new Materia { Id = 96, Nombre = "Administración", AñoCursadoId = 1 };
            var tecinf = new Materia { Id = 97, Nombre = "Tecnología de la Información", AñoCursadoId = 1 };
            var lyedd = new Materia { Id = 98, Nombre = "Lógica y Estructura de Datos", AñoCursadoId = 1 };
            var ids1 = new Materia { Id = 99, Nombre = "Ingeniería de Software I", AñoCursadoId = 1 };
            var sisop = new Materia { Id = 100, Nombre = "Sistemas Operativos", AñoCursadoId = 1 };

            //2do Año
            var pscon = new Materia { Id = 101, Nombre = "Problemáticas Socio Contemporáneas (1° cuat.)", AñoCursadoId = 2 };
            var iddi = new Materia { Id = 102, Nombre = "Unidad de definición Institucional (2° cuat.)", AñoCursadoId = 2 };
            var it2 = new Materia { Id = 103, Nombre = "Inglés Técnico II", AñoCursadoId = 2 };
            var iyde = new Materia { Id = 104, Nombre = "Innovación y Desarrollo Emprendedor", AñoCursadoId = 2 };
            var estad = new Materia { Id = 105, Nombre = "Estadística", AñoCursadoId = 2 };
            var prog1 = new Materia { Id = 106, Nombre = "Programación I", AñoCursadoId = 2 };
            var ids2 = new Materia { Id = 107, Nombre = "Ingeniería de Software II", AñoCursadoId = 2 };
            var bbdd1 = new Materia { Id = 108, Nombre = "Base de Datos I", AñoCursadoId = 2 };
            var pprof1 = new Materia { Id = 109, Nombre = "Práctica Profesionalizante I", AñoCursadoId = 2 };

            //3er Año
            var eyrs = new Materia { Id = 110, Nombre = "Ética y Responsabilidad Social", AñoCursadoId = 3 };
            var dyll = new Materia { Id = 111, Nombre = "Derecho y Legislación Laboral ", AñoCursadoId = 3 };
            var ryc = new Materia { Id = 112, Nombre = "Redes y Comunicación", AñoCursadoId = 3 };
            var prog2 = new Materia { Id = 113, Nombre = "Programación II", AñoCursadoId = 3 };
            var gps = new Materia { Id = 114, Nombre = "Gestión de Proyectos de Software", AñoCursadoId = 3 };
            var bd2 = new Materia { Id = 115, Nombre = "Base de Datos II", AñoCursadoId = 3 };
            var pracprof2 = new Materia { Id = 116, Nombre = "Práctica Profesionalizante II", AñoCursadoId = 3 };

            modelBuilder.Entity<Materia>().HasData(
                comu, udins, matem, ingtec1, admi, tecinf, lyedd, ids1, sisop,
                pscon, iddi, it2, iyde, estad, prog1, ids2, bbdd1, pprof1,
                eyrs, dyll, ryc, prog2, gps, bd2, pracprof2);
            #endregion
            #region MATERIA Tecnicatura Superior en Gestión de las Organizaciones
            //1er Año
            var comun = new Materia { Id = 117, Nombre = "Comunicación (1° cuat.)", AñoCursadoId = 7 };
            var unidefin = new Materia { Id = 118, Nombre = "Unidad de Definición Institucional (2° cuat.)", AñoCursadoId = 7 };
            var eco = new Materia { Id = 119, Nombre = "Economía ", AñoCursadoId =7 };
            var matest = new Materia { Id = 120, Nombre = "Matemática y Estadística", AñoCursadoId = 7 };
            var cont = new Materia { Id = 121, Nombre = "Contabilidad", AñoCursadoId = 7 };
            var inf = new Materia { Id = 122, Nombre = "Informática ", AñoCursadoId = 7 };
            var admin = new Materia { Id = 123, Nombre = "Administración ", AñoCursadoId = 7 };
            var gestp = new Materia { Id = 124, Nombre = "Gestión de la Producción ", AñoCursadoId = 7 };
            var gestal = new Materia { Id = 125, Nombre = "Gestión del Talento ", AñoCursadoId = 7 };
            var hum = new Materia { Id = 126, Nombre = "Humano", AñoCursadoId = 7 };
            //2do Año
            var probcon = new Materia { Id = 127, Nombre = "Problemáticas Contemporáneas", AñoCursadoId = 8 };
            var unidef = new Materia { Id = 128, Nombre = "Unidad de Definición Institucional II (2° cuat.)", AñoCursadoId = 8 };
            var indesemp = new Materia { Id = 129, Nombre = "Innovación y Desarrollo Emprendedor", AñoCursadoId = 8 };
            var ingtecn = new Materia { Id = 130, Nombre = "Inglés Técnico", AñoCursadoId = 8 };
            var legcom = new Materia { Id = 131, Nombre = "Legislación Comercial y Tributaria ", AñoCursadoId = 8 };
            var comeinv = new Materia { Id = 132, Nombre = "Gestión de Comercialización e Investigación Comercia", AñoCursadoId = 8 };
            var gestcosto = new Materia { Id = 133, Nombre = "Gestión de Costos", AñoCursadoId = 8 };
            var gestcont = new Materia { Id = 134, Nombre = "Gestión Contable", AñoCursadoId = 8 };
            var praprof = new Materia { Id = 135, Nombre = "Práctica Profesionalizante I", AñoCursadoId = 8 };
            //3er Año
            var gestssm = new Materia { Id = 136, Nombre = "Gestión de Seguridad, Salud Ocupacional y Medio Ambiente", AñoCursadoId = 9 };
            var eyrsoc = new Materia { Id = 137, Nombre = "Ética y Responsabilidad Social", AñoCursadoId = 9 };
            var leglab = new Materia { Id = 138, Nombre = "Legislación Laboral", AñoCursadoId = 9 };
            var estempr = new Materia { Id = 139, Nombre = "Estrategia Empresarial", AñoCursadoId = 9 };
            var sistigo = new Materia { Id = 140, Nombre = "Sistema de Información para la Gestión de las Organizaciones ", AñoCursadoId = 9 };
            var gestfin = new Materia { Id = 141, Nombre = "Gestión Financiera", AñoCursadoId = 9 };
            var evadmpi = new Materia { Id = 142, Nombre = "Evaluación y Administración de Proyectos de Inversión", AñoCursadoId = 9 };
            var contgest = new Materia { Id = 143, Nombre = "Control de Gestión", AñoCursadoId = 9 };
            var prctprof2 = new Materia { Id = 144, Nombre = "Practicas Profesionalizante II", AñoCursadoId = 9 };

            modelBuilder.Entity<Materia>().HasData(
                //1er Año
                comun, unidefin, eco, matest, cont, inf, admin, gestp, gestal, hum,
                //2do Año
                probcon, unidef, indesemp, ingtecn, legcom,comeinv, gestcosto, gestcont, praprof,
                //3er Año
                gestssm, eyrsoc, leglab, estempr, sistigo, gestfin, evadmpi, contgest, prctprof2);
            #endregion
            #region MATERIAS Profesorado de Educación Secundaria en Ciencias de la Administración
            //1er Año
            var peda = new Materia { Id = 145, Nombre = "Pedagogía", AñoCursadoId = 13 };
            var UCCV = new Materia { Id = 146, Nombre = "UCCV Sociología", AñoCursadoId = 13 };
            var admigene = new Materia { Id = 147, Nombre = "Administración General", AñoCursadoId = 13 };
            var admiuno = new Materia { Id = 148, Nombre = "Administración I", AñoCursadoId = 13 };
            var sdicI = new Materia { Id = 149, Nombre = "Sistema de Información Contable I", AñoCursadoId = 13 };
            var cdciuda = new Materia { Id = 150, Nombre = "Construcción de Ciudadanía", AñoCursadoId = 13 };
            var hiseco = new Materia { Id = 151, Nombre = "Historia Económica", AñoCursadoId = 13 };
            var matema = new Materia { Id = 152, Nombre = "Matemática", AñoCursadoId = 13 };
            var practiI = new Materia { Id = 153, Nombre = "Práctica Docente I", AñoCursadoId = 13 };
            //2do Año
            var IEI = new Materia { Id = 154, Nombre = "Instituciones Educativas", AñoCursadoId = 14 };
            var DyCurri = new Materia { Id = 155, Nombre = "Didáctica y Curriculum", AñoCursadoId = 14 };
            var psico = new Materia { Id = 156, Nombre = "Psicología y Educación", AñoCursadoId = 14 };
            var admiII = new Materia { Id = 157, Nombre = "Administración II", AñoCursadoId = 14 };
            var sdyconII = new Materia { Id = 158, Nombre = "Sistema de Información Contable II", AñoCursadoId = 14 };
            var dereI = new Materia { Id = 159, Nombre = "Derecho I", AñoCursadoId = 14 };
            var ecoo = new Materia { Id = 160, Nombre = "Economía", AñoCursadoId = 14 };
            var esta = new Materia { Id = 161, Nombre = "Estadística Aplicada", AñoCursadoId = 14 };
            var didacApli = new Materia { Id = 162, Nombre = "Didáctica de la Administración I", AñoCursadoId = 14 };
            var pracDoce = new Materia { Id = 163, Nombre = "Práctica Docencia II", AñoCursadoId = 14 };
            //3er Año
            var HistoPoli = new Materia { Id = 164, Nombre = "Historia y Política de la Educación Argentina ", AñoCursadoId = 15 };
            var filo = new Materia { Id = 165, Nombre = "Filosofía", AñoCursadoId = 15 };
            var meto = new Materia { Id = 166, Nombre = "Metodología de la Investigación", AñoCursadoId = 15 };
            var admiIII = new Materia { Id = 167, Nombre = "Administración III", AñoCursadoId = 15 };
            var sistemInfoIII = new Materia { Id = 168, Nombre = "Sistema de Información Contable III", AñoCursadoId = 15 };
            var pracImpo = new Materia { Id = 169, Nombre = "Práctica Impositiva y Laboral", AñoCursadoId = 15 };
            var dereII = new Materia { Id = 170, Nombre = "Derecho II", AñoCursadoId = 15 };
            var didaAdmiII = new Materia { Id = 171, Nombre = "Didáctica de la Administración II", AñoCursadoId = 15 };
            var sujeEdu = new Materia { Id = 172, Nombre = "Sujetos de la Educación Secundaria", AñoCursadoId = 15 };
            var pracIII = new Materia { Id = 173, Nombre = "Práctica Docente III", AñoCursadoId = 15 };
            var produRecu = new Materia { Id = 174, Nombre = "Producción de los Recursos Didácticos I", AñoCursadoId = 15 };
            //4to Año
            var etiYTra = new Materia { Id = 175, Nombre = "Ética y Trabajo Docente", AñoCursadoId = 16 };
            var eduSexu = new Materia { Id = 176, Nombre = "Educación Sexual Integral", AñoCursadoId = 16 };
            var UCCVComu = new Materia { Id = 177, Nombre = "UCCV Comunicación Social", AñoCursadoId = 16 };
            var admiIV = new Materia { Id = 178, Nombre = "Administración IV", AñoCursadoId = 16 };
            var gesOrga = new Materia { Id = 179, Nombre = "Gestión Organizacional", AñoCursadoId = 16 };
            var mateFinan = new Materia { Id = 180, Nombre = "Matemática Financiera", AñoCursadoId = 16 };
            var practiInves = new Materia { Id = 181, Nombre = "Prácticas de Investigación", AñoCursadoId = 16 };
            var practiIV = new Materia { Id = 182, Nombre = "Práctica Docente IV (Residencia)", AñoCursadoId = 16 };
            var produRecur = new Materia { Id = 183, Nombre = "Producción de los Recursos Didácticos II", AñoCursadoId = 16 };
            var UDII = new Materia { Id = 184, Nombre = "Unidad de Definición Institucional", AñoCursadoId = 16 };

            modelBuilder.Entity<Materia>().HasData(
                peda, UCCV, admigene, admiuno, sdicI, cdciuda, hiseco, matema, practiI,
                IEI, DyCurri, psico, admiII, sdyconII, dereI, ecoo, esta, didacApli, pracDoce,
                HistoPoli, filo, meto, admiIII, sistemInfoIII, pracImpo, dereII, didaAdmiII, sujeEdu, pracIII, produRecu,
                etiYTra, eduSexu, UCCVComu, admiIV, gesOrga, mateFinan, practiInves, practiIV, produRecur, UDII);
            #endregion
            #region MATERIA Profesorado de Educación Inicial 
            //1er Año
            var psieduped = new Materia { Id = 185, Nombre = "Psicología y Educación", AñoCursadoId = 17 };
            var pedag = new Materia { Id = 186, Nombre = "Pedagogia", AñoCursadoId = 17 };
            var scedu = new Materia { Id = 187, Nombre = "Sociología de la Educación", AñoCursadoId = 17 };
            var histarg = new Materia { Id = 188, Nombre = "Historia Argentina y Latinoamericana(1º cuatr.)", AñoCursadoId = 17 };
            var movcur = new Materia { Id = 189, Nombre = "Movimiento y Cuerpo I", AñoCursadoId = 17 };
            var tallprac = new Materia { Id = 190, Nombre = "Taller de Práctica I", AñoCursadoId = 17 };
            var probcont = new Materia { Id = 191, Nombre = "Problemáticas Contemporáneas de la Educación Inicial I", AñoCursadoId = 17 };
            var comyexp = new Materia { Id = 192, Nombre = "Comunicación y Expresión Oral y Esctrita", AñoCursadoId = 17 };
            var resprob = new Materia { Id = 193, Nombre = "Resolución de Problemas y Creatividad (1º cuatr.)", AñoCursadoId = 17 };
            var ambsoc = new Materia { Id = 194, Nombre = "Ambiente y Sociedad (2º cuatr.)", AñoCursadoId = 17 };
            var aestex = new Materia { Id = 195, Nombre = "Área Estético-Expresiva I", AñoCursadoId = 17 };
            var intmun = new Materia { Id = 196, Nombre = "Itinerarios por el Mundo de la Cultura", AñoCursadoId = 17 };
            var prodped = new Materia { Id = 197, Nombre = "Producción Pedagógica", AñoCursadoId = 17 };
            //2do Año
            var didgen = new Materia { Id = 198, Nombre = "Didáctica General", AñoCursadoId = 18 };
            var fisedu = new Materia { Id = 199, Nombre = "Filosofía de la Educación (1º cuatr.)", AñoCursadoId = 18 };
            var conedu = new Materia { Id = 200, Nombre = "Conocimiento y Educación (2º cuatr.)", AñoCursadoId = 18 };
            var muvcur = new Materia { Id = 201, Nombre = "Movimiento y Cuerpo II", AñoCursadoId = 18 };
            var tallprac2 = new Materia { Id = 202, Nombre = "Taller de Práctica II: Seminario de lo Grupal y los Grupos de Aprendizaje", AñoCursadoId = 18 };
            var sujeduin = new Materia { Id = 203, Nombre = "Sujeto de la Educación Inicial", AñoCursadoId = 18 };
            var didedu = new Materia { Id = 204, Nombre = "Didáctica de Educación Inicial I", AñoCursadoId = 18 };
            var matedid = new Materia { Id = 205, Nombre = "Matemática y su Didáctica I", AñoCursadoId = 18 };
            var litdid = new Materia { Id = 206, Nombre = "Literatura y su Didáctica", AñoCursadoId = 18 };
            var ciennat = new Materia { Id = 207, Nombre = "Ciencias Naturales y su Didáctica", AñoCursadoId = 18 };
            var intmund = new Materia { Id = 208, Nombre = "Itinerarios por el Mundo de la Cultura", AñoCursadoId = 18 };
            var prodpedag = new Materia { Id = 209, Nombre = "Producción Pedagógica", AñoCursadoId = 18 };
            //3er Año
            var tecinfcom = new Materia { Id = 210, Nombre = "Tecnologías de la Información y de la Comunicación", AñoCursadoId = 19 };
            var histsoc = new Materia { Id = 211, Nombre = "Historia Social de la Educación y Política Educativa Argentina", AñoCursadoId = 19 };
            var trayprac = new Materia { Id = 212, Nombre = "Trayecto de Práctica III: Seminario de Instituciones Educativas", AñoCursadoId = 19 };
            var matdid = new Materia { Id = 213, Nombre = "Matemática y su Didáctica II", AñoCursadoId = 19 };
            var legdid = new Materia { Id = 214, Nombre = "Lengua y su Didáctica (1º cuatr.)", AñoCursadoId = 19 };
            var alfinci = new Materia { Id = 215, Nombre = "Alfabetización Inicial (2º cuatr.)", AñoCursadoId = 19 };
            var csdid = new Materia { Id = 216, Nombre = "Ciencias Sociales y su Didáctica", AñoCursadoId = 19 };
            var arestex = new Materia { Id = 217, Nombre = "Área Estético-Expresiva II", AñoCursadoId = 19 };
            var probconei = new Materia { Id = 218, Nombre = "Problemáticas Contemporáneas de la Educación Inicial II (1º cuatr.)", AñoCursadoId = 19 };
            var dieduin = new Materia { Id = 219, Nombre = "Didáctica de la Educación Inicial II (2º cuatr.)", AñoCursadoId = 19 };
            var espdifins1 = new Materia { Id = 220, Nombre = "Espacios de Definición Institucional (1º cuatr.)", AñoCursadoId = 19 };
            var espdifins2 = new Materia { Id = 221, Nombre = "Espacios de Definición Institucional (2º cuatr.)", AñoCursadoId = 19 };
            var intmudcul = new Materia { Id = 222, Nombre = "Itinerarios por el Mundo de la Cultura", AñoCursadoId = 19 };
            var prodpeda = new Materia { Id = 223, Nombre = "Producción Pedagógica", AñoCursadoId = 19 };
           
            //4to Año
            var ettrabder = new Materia { Id = 224, Nombre = "Ética, Trabajo Docente, Derechos Humanos y Ciudadanos", AñoCursadoId = 20 };
            var tallpract = new Materia { Id = 225, Nombre = "Taller de Práctica IV", AñoCursadoId = 20 };
            var ateneo = new Materia { Id = 226, Nombre = "Ateneo: (Matemática- Ambiente y Sociedad (Ciencias Naturales- Ciencias Sociales) Lengua y Literatura- Formación Ètica y Ciudadana)", AñoCursadoId = 20 };
            var sexhum = new Materia { Id = 227, Nombre = "Sexualidad Humana y Educación  (1º cuatr.)", AñoCursadoId = 20 };
            var intmudcult = new Materia { Id = 228, Nombre = "Itinerarios por el Mundo de la Cultura", AñoCursadoId = 20 };
            var prdpedago = new Materia { Id = 229, Nombre = "Producción Pedagógica", AñoCursadoId = 20 };

            modelBuilder.Entity<Materia>().HasData(
                //1er Año
                psieduped, pedag, scedu, histarg, movcur, tallprac, 
                probcont, comyexp, resprob, ambsoc, aestex, intmun, prodped,
                //2do Año
                didgen, fisedu, conedu, muvcur, tallprac2, sujeduin, didedu, 
                matedid, litdid, ciennat, intmund, prodpedag,
                //3er Año
                tecinfcom, histsoc, trayprac, matdid, legdid, alfinci, csdid, 
                arestex, probconei, dieduin, espdifins1, espdifins2, intmudcul, prodpeda,
                //4to Año
                ettrabder, tallpract, ateneo, sexhum, intmudcult, prdpedago
                );
            #endregion
            #region MATERIAS Profesorado de Educación Secundaria en Economía
            //1er Año
            var pedagog = new Materia { Id = 230, Nombre = "Pedagogía", AñoCursadoId = 21 };
            var UCCVSocio = new Materia { Id = 231, Nombre = "UCCV Sociología", AñoCursadoId = 21 };
            var admiGen = new Materia { Id = 232, Nombre = "Administración General", AñoCursadoId = 21 };
            var ecoI = new Materia { Id = 233, Nombre = "Economía I", AñoCursadoId = 21 };
            var geoEco = new Materia { Id = 234, Nombre = "Geografía Económica", AñoCursadoId = 21 };
            var histoEco = new Materia { Id = 235, Nombre = "Historia Económica", AñoCursadoId = 21 };
            var consCiuda = new Materia { Id = 236, Nombre = "Construcción de Ciudadanía", AñoCursadoId = 21 };
            var sistInfo = new Materia { Id = 237, Nombre = "Sistema de Información Contable I", AñoCursadoId = 21 };
            var admiGene = new Materia { Id = 238, Nombre = "Administración General", AñoCursadoId = 21 };
            var matee = new Materia { Id = 239, Nombre = "Matemática", AñoCursadoId = 21 };
            var practiDoceI = new Materia { Id = 240, Nombre = "Práctica Docente I", AñoCursadoId = 21 };
            //2do Año
            var instiEduc = new Materia { Id = 241, Nombre = "Instituciones Educativas", AñoCursadoId = 22 };
            var didacYCurri = new Materia { Id = 242, Nombre = "Didáctica y Curriculum", AñoCursadoId = 22 };
            var psicoYeduc = new Materia { Id = 243, Nombre = "Psicología y Educación", AñoCursadoId = 22 };
            var ecoII = new Materia { Id = 244, Nombre = "Economía II", AñoCursadoId = 22 };
            var sistInfoConII = new Materia { Id = 245, Nombre = "Sistema de Información Contable II", AñoCursadoId = 22 };
            var dereeI = new Materia { Id = 246, Nombre = "Derecho I", AñoCursadoId = 22 };
            var ecco = new Materia { Id = 247, Nombre = "Economía", AñoCursadoId = 22 };
            var estaApli = new Materia { Id = 248, Nombre = "Estadística Aplicada", AñoCursadoId = 22 };
            var didaEcoI = new Materia { Id = 249, Nombre = "Didáctica de la Economía I", AñoCursadoId = 22 };
            var pracDoceII = new Materia { Id = 250, Nombre = "Práctica Docencia II", AñoCursadoId = 22 };
            //3er Año
            var histoYPoli = new Materia { Id = 251, Nombre = "Historia y Política de la Educación Argentina", AñoCursadoId = 23 };
            var filoo = new Materia { Id = 252, Nombre = "Filosofía", AñoCursadoId = 23 };
            var metoInves = new Materia { Id = 253, Nombre = "Metodología de la Investigación", AñoCursadoId = 23 };
            var ecoIII = new Materia { Id = 254, Nombre = "Economía III", AñoCursadoId = 23 };
            var finaPubli = new Materia { Id = 255, Nombre = "Finanzas Públicas", AñoCursadoId = 23 };
            var dereeII = new Materia { Id = 256, Nombre = "Derecho II", AñoCursadoId = 23 };
            var sujeEduu = new Materia { Id = 257, Nombre = "Sujetos de la Educación Secundaria ", AñoCursadoId = 23 };
            var practiDoceIII = new Materia { Id = 258, Nombre = "Práctica Docente III", AñoCursadoId = 23 };
            var produRecuDida = new Materia { Id = 259, Nombre = "Producción de los Recursos Didácticos I", AñoCursadoId = 23 };
            //4to Año
            var etiYTraba = new Materia { Id = 260, Nombre = "Ética y Trabajo Docente", AñoCursadoId = 24 };
            var eduSexual = new Materia { Id = 261, Nombre = "Educación Sexual Integral", AñoCursadoId = 24 };
            var UCCVComuu = new Materia { Id = 262, Nombre = "UCCV Comunicación Social", AñoCursadoId = 24 };
            var ecoSocial = new Materia { Id = 263, Nombre = "Economía Social y Sostenible", AñoCursadoId = 24 };
            var ecoArg = new Materia { Id = 264, Nombre = "Economía Argentina Latinoamericana e Internacional", AñoCursadoId = 24 };
            var pracInv = new Materia { Id = 265, Nombre = "Prácticas de Investigación", AñoCursadoId = 24 };
            var resi = new Materia { Id = 266, Nombre = "Práctica Docente IV (Residencia)", AñoCursadoId = 24 };
            var prodRecur = new Materia { Id = 267, Nombre = "Producción de los Recursos Didácticos II", AñoCursadoId = 24 };
            var uniDefini = new Materia { Id = 268, Nombre = "Unidad de Definición Institucional", AñoCursadoId = 24 };

            modelBuilder.Entity<Materia>().HasData(
                pedagog, UCCVSocio, admiGen, ecoI, geoEco, histoEco, consCiuda, sistInfo, admiGene, matee, practiDoceI,
                instiEduc, didacYCurri, psicoYeduc, ecoII, sistInfoConII, dereeI, ecco, estaApli, didaEcoI, pracDoceII,
                histoYPoli, filoo, metoInves, ecoIII, finaPubli, dereeII, sujeEduu, practiDoceIII, produRecuDida,
                etiYTraba, eduSexual, UCCVComuu, ecoSocial, ecoArg, pracInv, resi, prodRecur, uniDefini);
            # endregion
            #endregion
            #region datos semillas alumnos
            var ivan = new Alumno { Id = 1, Nombre = "Carlos Ivan ",Apellido= "Valle", Dni= 37454714 , Telefono = 3498459297 , Email= "ivanvallesj@gmail.com"};
            var juan = new Alumno { Id = 2, Nombre = "Juan Pablo ", Apellido = "Colombo", Dni = 38584798, Telefono = 3498459299, Email = "juancolombosj@gmail.com" };
            var ramiro = new Alumno { Id = 3, Nombre = "Ramiro ", Apellido = "Córdoba", Dni = 38957452, Telefono = 3498459298, Email = "rami@gmail.com" };
            var matias = new Alumno { Id = 4, Nombre = "Matias ", Apellido = "Sabino", Dni = 39625852, Telefono = 3498459295, Email = "mati@gmail.com" };
            var jeremias = new Alumno { Id = 5, Nombre = "Jeremias  ", Apellido = "Mangini", Dni = 37154825, Telefono = 3498459294, Email = "jere@gmail.com" };
            var conrado = new Alumno { Id = 6, Nombre = "Conrado", Apellido = " Paulon ", Dni = 37124896, Telefono = 3498459293, Email = "corado@gmail.com" };
            var nahuel = new Alumno { Id = 7, Nombre = "Nahuel", Apellido = " Gomez ", Dni = 38957412, Telefono = 3498459292, Email = "nahuel@gmail.com" };
            var santiago = new Alumno { Id = 8, Nombre = "Santiago", Apellido = " Barreto", Dni = 39658745, Telefono = 3498459291, Email = "santi@gmail.com" };
            modelBuilder.Entity<Alumno>().HasData(ivan,juan,ramiro,matias,jeremias,conrado,nahuel,santiago
                );
            #endregion
            #region definicion de filtro de eliminacion
            modelBuilder.Entity<Alumno>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Carrera>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<Materia>().HasQueryFilter(m => !m.Eliminado);
            #endregion
        }


        public DbSet<InscripcionWeb.Models.Carrera> Carreras { get; set; }

        public DbSet<InscripcionWeb.Models.Alumno> Alumnos { get; set; }

        public DbSet<InscripcionWeb.Models.Materia> Materias { get; set; }

        public DbSet<InscripcionWeb.Models.AñoCursado> AñoCursados { get; set; }
        public DbSet<InscripcionWeb.Models.DetalleAlumnoCarrera> DetallesAlumnosCarreras { get; set; }
        public DbSet<InscripcionWeb.Models.DetalleAlumnoMateria> DetallesAlumnosMaterias { get; set; }
    }
}
