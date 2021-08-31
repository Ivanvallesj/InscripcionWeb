using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionWeb.Models
{
    public class AñoCursado
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
        public bool Eliminado { get; set; }
    }
}
