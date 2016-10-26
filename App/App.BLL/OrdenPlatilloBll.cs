using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    public class OrdenPlatilloBll
    {
        private OrdenPlatilloRepo _ordenplatilloRepo;

        public OrdenPlatilloBll()
        {
            _ordenplatilloRepo = new OrdenPlatilloRepo();
        }

        public void Agregar(OrdenPlatillo ordenplatillo)
        {
            _ordenplatilloRepo.Agregar(ordenplatillo);
        }


        public void Borrar(OrdenPlatillo ordenplatillo)
        {
            _ordenplatilloRepo.Borrar(ordenplatillo);
        }

        public List<OrdenPlatillo> TraerTodo()
        {
            return _ordenplatilloRepo.TraerTodo();
        }

        public OrdenPlatillo TraerPorId(int id)
        {
            return _ordenplatilloRepo.TraerPorId(id);
        }

    }
}
