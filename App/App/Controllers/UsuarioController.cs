using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class UsuarioController
    {
        private UsuarioBll _usuarioBll;
        private Usuario _usuarioEntity;

        public UsuarioController()
        {
            _usuarioBll = new UsuarioBll();
            _usuarioEntity = new Usuario();


        }

        public ActionResult Index()
        {

            _usuarioEntity.Nombre = "Xitlalli";
            _usuarioEntity.Apellido = "Ruiz";
            _usuarioEntity.FechaNac = DateTime.Now;
            _usuarioEntity.TipoUsuario = "Cajera";
            _usuarioEntity.UserName = "Xitlalli98";
            _usuarioEntity.Password = "fuckyou";
            _usuarioBll.Agregar(_usuarioEntity);
            return View();
        }

        
    }
}