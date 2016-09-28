using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Orden
    {
        public int ID { get; set; }
        public int ID_Alumno { get; set; }
        public DateTime Fecha { get; set; }
        public Double Costo_Total { get; set; }
        public string Estatus { get; set; }

    }
}
