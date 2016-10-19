using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities; 

namespace App.DAL
{
   public  class OrdenRepo
    {
        private AppDBContext _Contexto;

        public OrdenRepo()
        {
            _Contexto = new AppDBContext();

        }

        public void Agregar(Orden orden)
        {
            _Contexto.Ordenes.Add(orden);
            _Contexto.SaveChanges();


        }

        public void Borrar(Orden orden)
        {
            _Contexto.Ordenes.Remove(orden);
            _Contexto.SaveChanges();


        }

        public List<Alumno> TraerTodo()
        {
            return _Contexto.Alumnos.OrderBy(x => x.NoControl).ToList();

        }
        //select * from alumno where Id = 3
        public Alumno TraerPorId(int id)
        {
            return _Contexto.Alumnos.FirstOrDefault(x => x.Id == id);
        }
    }
}
