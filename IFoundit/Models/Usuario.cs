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
        public string Correo{ get; set; }
        public string Contrasenia{ get; set; }
        public char Sexo { get; set; }
        public string Celular { get; set; }
        public string CelularContacto { get; set; }
        public int TieneWhatsapp { get; set; }
        public int PermitirMostrarWhatsapp { get; set; }

        public List < Objeto>Objetos { get; set; }

    }
}
