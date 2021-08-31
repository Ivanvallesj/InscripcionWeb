using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionWeb.Models
{
    public class DetalleAlumnoMateria
    {
        public int Id { get; set; }
        public  int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }

    }
}
