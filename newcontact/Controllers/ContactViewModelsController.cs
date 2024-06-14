using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using newcontact.Data;
using newcontact.Models;

namespace newcontact.Controllers
{
    public class ContactViewModelsController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save messages to your database or any other storage

                // Redirect to ThankYou page
                return RedirectToAction("ThankYou");
            }
            // If the model state is not valid, return to the same view with validation errors
            return View(model);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}


       
