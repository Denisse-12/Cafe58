﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class OrdenPlatillo
    {
        [Key]
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public Orden Orden { get; set; }
        public int IdPlatillo { get; set; }
        public Platillo Platillo { get; set; }

        public virtual ICollection<Platillo> Platillos { get; set; }

    }
}
