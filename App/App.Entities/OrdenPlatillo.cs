using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    class OrdenPlatillo
    {
        [Key]
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int IdPlatillo { get; set; }
    }
}
