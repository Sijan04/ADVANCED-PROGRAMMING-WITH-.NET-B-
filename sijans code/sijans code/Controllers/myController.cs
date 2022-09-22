using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sijans_code.Controllers
{
    public class myController : Controller
    {
        // GET: my
        public ActionResult Intro()
        {
            return View();
        }
    }
}