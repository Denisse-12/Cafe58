using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class MenuController : Controller
    {
        private MenuBll _menuBll;
        private Menu _menuEntity;

        public MenuController()
        {
            _menuBll = new MenuBll();
            _menuEntity = new Menu();


        }
        //GET
        public ActionResult Index()
        {

            _menuEntity.Fecha = DateTime.Now;
            _menuBll.Agregar(_menuEntity);

            return View();
        }
    }
}