using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class MenuRepo
    {
        private AppDBContext _Contexto;

        public MenuRepo()
        {

            _Contexto = new AppDBContext();
        }

        public void Agregar(Menu menu)
        {
            _Contexto.Menus.Add(menu);
            _Contexto.SaveChanges();

        }

        public void Borrar(Menu menu)
        {
            _Contexto.Menus.Remove(menu);
            _Contexto.SaveChanges();

        }
       
        public List<Menu> TraerTodo()
        {
            return _Contexto.Menus.OrderBy(x => x.Id).ToList();

        }
 
        public Menu TraerPorId(int id)
        {
            return _Contexto.Menus.FirstOrDefault(x => x.Id == id);
        }
    }
}
