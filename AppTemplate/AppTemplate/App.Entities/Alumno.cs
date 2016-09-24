﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int  NoControl { get; set; }
        public DateTime FechaNac { get; set; }
        public string Grupo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Boolean Beca { get; set; }

    }
}
