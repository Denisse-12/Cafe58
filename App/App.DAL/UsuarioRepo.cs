using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
     public class UsuarioRepo
    {
        private AppDBContext _Contexto;

        public UsuarioRepo()
        {

            _Contexto = new AppDBContext();
        }

        public void Agregar(Usuario usuario)
        {
            _Contexto.Usuarios.Add(usuario);
            _Contexto.SaveChanges();

        }

        public void Borrar(Usuario usuario)
        {
            _Contexto.Usuarios.Remove(usuario);
            _Contexto.SaveChanges();

        }
        //select * front Alumno orden by nocontrol
        public List<Usuario> TraerTodo()
        {
            return _Contexto.Usuarios.OrderBy(x => x.Id).ToList();

        }
        //select * from alumno where Id = 3
        public Usuario TraerPorId(int id)
        {
            return _Contexto.Usuarios.FirstOrDefault(x => x.Id == id);
        }

    }
}
