using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaApp.Models;

namespace TiendaApp.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            TiendaDBEntities db = new TiendaDBEntities();

            return View(db.Prodcts.ToList());
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prodcts a)
        {
            if (!ModelState.IsValid)
            {
                return View();
            } 

            using (var db = new TiendaDBEntities())
                {

                    db.Prodcts.Add(a);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                        
        }

        public ActionResult Delete()
        {
            return RedirectToAction("Index");
        }

    }
}