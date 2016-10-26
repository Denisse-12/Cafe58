using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class AlumnosController : Controller
    {
        private AlumnoBll _alumnoBll;
        private Alumno _alumnoEntity;

        public AlumnosController()
        {
            _alumnoBll = new AlumnoBll();
            _alumnoEntity = new Alumno();


        }

        // GET: Alumnos

        public ActionResult AgregarAlumno(int noControl, string nombre, string apellido, string grupo, string foto)
        {
            _alumnoEntity.NoControl = noControl;
            _alumnoEntity.Grupo = grupo;
            _alumnoEntity.Nombre = nombre;
            _alumnoEntity.Apellidos = apellido;
            _alumnoEntity.Foto = foto;
            _alumnoEntity.Beca = false;
            _alumnoBll.Agregar(_alumnoEntity);
            return View();
        }

       // public ActionResult Index()
       // {

        //    _alumnoEntity.Nombre = "Denisse";
        //    _alumnoEntity.Apellidos = "Huerta Perez";
        //    _alumnoEntity.Beca = false;
         //   _alumnoEntity.Email = "Denisse.4567@outlook.com";
         //   _alumnoEntity.NoControl = 123123;
          //  _alumnoEntity.FechaNac = DateTime.Now;
           // _alumnoEntity.Foto = "https://scontent-dft4-1.xx.fbcdn.net/v/t1.0-9/14238257_1251296968236041_4509225184790915395_n.jpg?oh=0be2062702311c32fb3d7bc83279ea94&oe=5861C65B";
          //  _alumnoEntity.Password = "23455";
          //  _alumnoEntity.Grupo = "5DM";
           // _alumnoBll.Agregar(_alumnoEntity);
         //   return View();
        //}
    }
}