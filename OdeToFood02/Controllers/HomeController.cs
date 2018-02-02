using OdeToFood02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}::{1} {2}", controller, action, id);


            //ViewBag.Message = "ett litet textmeddelande...............................";
            ViewBag.Message = message; 
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Location = "Marievik, Sverige";
            var model      = new AboutModel();
            model.Name     = "Scott";
            model.Location = "Maryland, USA";
            return View(model);
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            var model = new AboutModel();
            model.Name = "Scott";
            model.Location = "Maryland, USA";
            return View(model);
        }
    }
}