using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;

namespace App.BLL
{
    class MenuBll
    {
        private MenuRepo _menuRepo;

        public MenuBll()
        {
            _menuRepo = new MenuRepo();
        }

        public void Agregar(Menu menu)
        {
            _menuRepo.Agregar(menu);
        }


        public void Borrar(Menu menu)
        {
            _menuRepo.Borrar(menu);
        }

        public List<Menu> TraerTodo()
        {
            return _menuRepo.TraerTodo();
        }

        public Menu TraerPorId(int id)
        {
            return _menuRepo.TraerPorId(id);
        }

    }
}
