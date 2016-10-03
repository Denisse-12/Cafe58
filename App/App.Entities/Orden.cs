using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Orden
    {   
        [Key]
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        public DateTime Fecha { get; set; }
        public Double CostoTotal { get; set; }
        public string Estatus { get; set; }

        public virtual ICollection<OrdenPlatillo> OrdenPlatillo;
    }
}
