using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    class Platillo
    {

        [Key]

        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte Imagen { get; set; }
        public double Numero { get; set; }
        public Boolean Beca { get; set; }

        public virtual ICollection<Ingredientes> Ingredientes;
        public virtual ICollection<OrdenPlatillo> OrdenPlatillos; 

        
    }
}
