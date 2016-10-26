using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class OrdenController : Controller
    {
        private OrdenBll _ordenBll;
        private Orden _OrdenEntity;

        public OrdenController()
        {
            _ordenBll = new OrdenBll();
            _OrdenEntity = new Orden();
        }



        // GET: Orden
        public ActionResult Index()
        {

            _OrdenEntity.Id = 1;
            _OrdenEntity.IdAlumno = 011;
            _OrdenEntity.Fecha = DateTime.Now;
            _OrdenEntity.CostoTotal = 2;
            _OrdenEntity.Estatus = "Preparando";

            return View();
        }
    }
}