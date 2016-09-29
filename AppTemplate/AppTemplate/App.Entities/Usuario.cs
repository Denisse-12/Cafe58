using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimento { get; set; }
        public string TipoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
