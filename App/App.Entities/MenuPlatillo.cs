using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
   public class MenuPlatillo
    {
        public MenuPlatillo()
       {
           this.Platillos = new HashSet<Platillo>();
       }

        [Key]

        public int Id { get; set; }
        public int IdPlatillo {get; set;}
        public Platillo Platillo { get; set; }
        public int IdMenu { get; set; }
        public Menu Menu { get; set;  }

        public virtual ICollection<Platillo> Platillos { get; set; }
        
    }
}
