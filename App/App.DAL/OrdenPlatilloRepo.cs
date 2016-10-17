using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class OrdenPlatilloRepo
    {
        private AppDBContext _Contexto;

        public OrdenPlatilloRepo()
        {

            _Contexto = new AppDBContext();
        }

        public void Agregar(OrdenPlatillo ordenplatillo)
        {
            _Contexto.OrdenesPlatillos.Add(ordenplatillo);
            _Contexto.SaveChanges();

        }

        public void Borrar(OrdenPlatillo ordenplatillo)
        {
            _Contexto.OrdenesPlatillos.Remove(ordenplatillo);
            _Contexto.SaveChanges();

        }

        public List<OrdenPlatillo> TraerTodo()
        {
            return _Contexto.OrdenesPlatillos.OrderBy(x => x.Id).ToList();

        }

        public OrdenPlatillo TraerPorId(int id)
        {
            return _Contexto.OrdenesPlatillos.FirstOrDefault(x => x.Id == id);
        }
    }
}
