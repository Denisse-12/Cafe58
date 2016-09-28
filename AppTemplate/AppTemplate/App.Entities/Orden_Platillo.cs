using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Orden_Platillo
    {
    [key]
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Platillo { get; set; }
    }
}
