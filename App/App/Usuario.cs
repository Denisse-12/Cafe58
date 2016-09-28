using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App
{
    public class Usuario
    {
        [key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimento { get; set; }
        public string TipoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}