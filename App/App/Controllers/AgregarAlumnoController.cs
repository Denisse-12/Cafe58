using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class AgregarAlumnoController : Controller
    {
        private AlumnoBll _alumnoBll;
        private Alumno _alumnoEntity;

        public AgregarAlumnoController()
        {
            _alumnoBll = new AlumnoBll();
            _alumnoEntity = new Alumno();


        }

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

        // GET: AgregarAlumno
       
    }
}