using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.DAL;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext();
        // GET: Home
        public ActionResult Index()
        {
            var listaKategorii = db.Kategorie.ToList();

            return View();
        }
    }
}
