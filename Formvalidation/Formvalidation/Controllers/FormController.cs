using Formvalidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formvalidation.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        [HttpGet]
        public ActionResult student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult student(student s)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "student");
            }
            return View(s);
        }



    }
}