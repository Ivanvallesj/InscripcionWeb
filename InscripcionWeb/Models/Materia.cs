using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionWeb.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AñoCursadoId { get; set; }
        public AñoCursado AñoCursado { get; set; }
        public bool Eliminado { get; set; }
    }
}
