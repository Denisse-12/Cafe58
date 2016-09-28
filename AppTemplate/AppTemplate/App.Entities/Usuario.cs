using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Usuario
    {
        [key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        public string TipoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
