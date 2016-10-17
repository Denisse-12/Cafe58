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
        private AppDBContext _contexto;

        public OrdenRepo()
        {
            _contexto = new AppDBContext();

        }

        public void Agregar(Orden orden)
        {
            _contexto.Ordenes.Add(orden);
            _contexto.SaveChanges();


        }

        public void Borra(Orden orden )
        {
            _contexto.Ordenes.Remove(orden);
            _contexto.SaveChanges();


        }

        public List<Orden> TraerTodo()
        {
            return _contexto.Ordenes.OrderBy(x => x.Id).ToList();
        }

        public Orden TrearPorId (int id)
        {
            return _contexto.Ordenes.FirstOrDefault(x => Id == id);
        }
    }
}
