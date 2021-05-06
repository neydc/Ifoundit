using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Models
{
    public class Objeto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Recompensa { get; set; }
        public string Imagen { get; set; }
        public int IdUsuario { get; set; }

    }
}
