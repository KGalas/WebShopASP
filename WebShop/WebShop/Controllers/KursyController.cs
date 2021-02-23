using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.DAL;

namespace WebShop.Controllers
{
    public class KursyController : Controller
    {
        private KursyContext db = new KursyContext();
        // GET: Kursy
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista(string nazwaKategori)
        {
            var kategorie = db.Kategorie.Include("Kursy").Where(k => k.NazwaKategorii.ToUpper() == nazwaKategori.ToUpper()).Single();
            var kursy = kategorie.Kursy.ToList();

            return View(kursy);
        }
        public ActionResult Szczegoly(string id)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult KategorieMenu(string id)
        {
            var kategorie = db.Kategorie.ToList();

            return PartialView("_KategorieMenu",kategorie);
        }
    }
}