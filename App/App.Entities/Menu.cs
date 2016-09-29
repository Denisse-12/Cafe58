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
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

    }
}