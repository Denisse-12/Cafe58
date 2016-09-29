﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    class Ingredientes
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPlatillo { get; set; }

    }
}
