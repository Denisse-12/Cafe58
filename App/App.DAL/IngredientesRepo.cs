using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;


namespace App.BLL
{
     public class IngredientesRepo

    {
         private AppDBContext _Contexto;

        public IngredientesRepo()
        {
           _Contexto = new AppDBContext();
        }

        public void Agregar(Ingredientes ingredientes)
        {
            _Contexto.Ingredientes.Add(ingredientes);
            _Contexto.SaveChanges();
        }


        public void Borrar (Ingredientes ingredientes)
        {
            _Contexto.Ingredientes.Remove(ingredientes);
            _Contexto.SaveChanges();
        }

        public List<Ingredientes> TraerTodo()
        {
            return _Contexto.Ingredientes.OrderBy(x => x.Id).ToList();
        }

        public Ingredientes TraerPorId(int id)
        {
            return _Contexto.Ingredientes.FirstOrDefault(x => x.Id == id);
        }
 
    }
}
