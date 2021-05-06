using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Models
{
    public class Usuario
    {
        public int Id{ get; set; }
        public string Nombre{ get; set; }
        public string Apellidos{ get; set; }
        public string Dni{ get; set; }
        public string Correo{ get; set; }
        public string Contrasenia{ get; set; }
        public char Sexo { get; set; }

    }
}
