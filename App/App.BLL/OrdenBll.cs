using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
    public class OrdenBll
    {
        private OrdenRepo _ordenRepo;

        public OrdenBll()
        {
            _ordenRepo = new OrdenRepo();
        }

        public void Agregar(Orden orden)
        {
            _ordenRepo.Agregar(orden);
        }


        public void Borrar(Orden orden)
        {
            _ordenRepo.Borrar(orden);
        }

        public List<Alumno> TraerTodo()
        {
            return _ordenRepo.TraerTodo();
        }

        public Alumno TraerPorId(int id)
        {
            return _ordenRepo.TraerPorId(id);
        }


    }
}
