using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;


namespace App.BLL
{
    public class MenuPlatilloRepo
    {
        private AppDBContext _Contexto;

        public MenuPlatilloRepo()
        {
            _Contexto = new AppDBContext();
        }

        public void Agregar (MenuPlatillo MenuPlatillo)
        {
            _Contexto.MenuPlatillo.Add(MenuPlatillo);
            _Contexto.SaveChanges();
        }


        public void Borrar (MenuPlatillo MenuPlatillo)
        {
            _Contexto.menuplatillo.Remove(MenuPlatillo);
            _Contexto.SaveChanges();
        }

        public List<MenuPlatillo> TraerTodo()
        {
            return _Contexto.MenuPlatillo.OrderBy(x => x.Id).ToList();
        }

        public MenuPlatillo TraerPorId(int id)
        {
            return _Contexto.MenuPlatillo.FirstOrDefault(x => x.Id == id);
        }
    }
}

