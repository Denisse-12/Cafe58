using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
   public class Menu
    {
        public Menu()
       {
           this.MenuPlatillos = new HashSet<MenuPlatillo>();
       }


        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ICollection<MenuPlatillo> MenuPlatillos { get; set; }
    }
}
