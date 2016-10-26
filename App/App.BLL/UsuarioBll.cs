using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using App.DAL;


namespace App.BLL
{
    public class UsuarioBll
    {
        private UsuarioRepo _usuarioRepo;

        public UsuarioBll()
        {
            _usuarioRepo = new UsuarioRepo();
        }

        public void Agregar(Usuario usuario)
        {
            _usuarioRepo.Agregar(usuario);
        }


        public void Borrar(Usuario usuario)
        {
            _usuarioRepo.Borrar(usuario);
        }

        public List<Usuario> TraerTodo()
        {
            return _usuarioRepo.TraerTodo();
        }

        public Usuario TraerPorId(int id)
        {
            return _usuarioRepo.TraerPorId(id);
        }

    }
}
