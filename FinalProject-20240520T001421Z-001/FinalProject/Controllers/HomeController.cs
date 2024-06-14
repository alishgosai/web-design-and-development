using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult login ()
        {
            ViewBag.Message = "Model";
            return View();

        }
        public ActionResult Menu()
        {
            ViewBag.Message = "Menu page";
            return View();
        }
        public ActionResult Reservation()
        {
            ViewBag.Message = "Reservation Page";
            return View();
        }
    }
}