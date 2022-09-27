
using Author.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;


namespace Author.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Book()
        {

            ViewBag.Book = new string[] { "obhoy" , "nibah" ,"onoy" };

            return View();
        }

        public ActionResult profile()
        {
            writter obj = new writter()
     
            {

                Name = "sijan",
                Dob = "12.12.12",
                Awards = "Best writter awards of the year",

            };
            return View(obj);
        }
    }
}

    