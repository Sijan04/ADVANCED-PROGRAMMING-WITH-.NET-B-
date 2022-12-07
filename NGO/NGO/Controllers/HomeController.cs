using NGO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Sijan p)
        {
            var db = new SijansEntities();
            db.Sijans.Add(p);
            db.SaveChanges();
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {

            var db = new SijansEntities();
            var Items = db.Sijans.ToList();
            return View(Items);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new SijansEntities();
            var item = new Sijan();

            item = db.Sijans.FirstOrDefault(p => p.id == id);

            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(Sijan p)
        {
            var db = new SijansEntities();
            var item = db.Sijans.FirstOrDefault(pr => p.id == pr.id);
            item.name = p.name;
            item.food = p.food;

            item.qty = p.qty;
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Display");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            Sijan product = new Sijan() { id = id };

            using (var context = new SijansEntities())
            {
                context.Sijans.Attach(product);
                context.Sijans.Remove(product);
                context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }























     
        [HttpGet]
        public ActionResult Donatee(int id)
        {
            var db = new SijansEntities();
            var item = new Sijan();

            item = db.Sijans.FirstOrDefault(p => p.id == id);

            return View(item);
        }
        [HttpPost]
        public ActionResult Donatee(Donate p)
        {
            var db = new SijansEntities();
            db.Donates.Add(p);
            db.SaveChanges();
            return RedirectToAction("Donateitem");
        }

        [HttpGet]
        public ActionResult Donateitem()
        {

            var db = new SijansEntities();
            var Items = db.Donates.ToList();
            return View(Items);
          
        }




        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }






    }
}