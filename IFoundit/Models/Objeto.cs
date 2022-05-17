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
        public string Categoria { get; set; }
        public string Estado { get; set; }
        public string WhatsappDeUsuario { get; set; }
        public string OtroNumero { get; set; }
        public int Ocultar { get; set; }
        public Boolean EstadoWhatsapp { get; set; }
        public int IdUsuario { get; set; }

        public Usuario Usuario{ get; set; }

    }
}
