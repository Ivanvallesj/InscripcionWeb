using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionWeb.Models
{
    public class DetalleAlumnoCarrera
    {
        public int Id { get; set; }
        [Display(Name = "Alumno") ]
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        [Display(Name = "Carrera")]
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
    }
}
