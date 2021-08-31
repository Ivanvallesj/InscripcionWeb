using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionWeb.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public double Telefono { get; set; }
        [Required]
        public int Dni { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombre { get; set; }

        public bool Eliminado { get; set; }

    }
}
