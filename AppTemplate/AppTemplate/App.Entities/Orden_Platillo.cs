using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
     public class Orden_Platillo
    {
         [Key]
         public int Id { get; set; }
         public int IdOrden { get; set; }
         public int IdPlatillo { get; set; }

    }
}
