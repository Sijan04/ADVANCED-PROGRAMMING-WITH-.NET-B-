using System.Data;
using crud_operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud_operations.Controllers
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
        public ActionResult Index(Product p)
        {
            var db = new ProductsEntities();
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {

            var db = new ProductsEntities();
            var Items = db.Products.ToList();
            return View(Items);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new ProductsEntities();
            var item = new Product();

            item = db.Products.FirstOrDefault(p=>p.id==id);
            
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit( Product p)
        {
            var db = new ProductsEntities();
            var item = db.Products.FirstOrDefault(pr => p.id ==pr.id);
            item.name=p.name;
            item.price = p.price;

            item.qty = p.qty;
            db.Entry(item).State=EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Display");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product product = new Product() { id = id };

            using (var context = new ProductsEntities())
            {
                context.Products.Attach(product);
                context.Products.Remove(product);
                context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }


    }
}