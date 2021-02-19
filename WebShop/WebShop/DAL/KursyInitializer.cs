using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebShop.Migrations;
using WebShop.Models;

namespace WebShop.DAL
{
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext, Configuration>
    {
        //protected override void Seed(KursyContext context)
        //{
        //    SeedKursyData(context);
        //    base.Seed(context);
        //}

        public static void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>()
            {
                new Kategoria(){KategoriaID=1,NazwaKategorii="ASP",NazwaPlikuIkony="aspnet.png",OpisKategorii="opis asp net mvc"},
                new Kategoria(){KategoriaID=2,NazwaKategorii="C#",NazwaPlikuIkony="csharp.png",OpisKategorii="opis c#"},
                new Kategoria(){KategoriaID=3,NazwaKategorii="CSS",NazwaPlikuIkony="css.png",OpisKategorii="opis css"},
                new Kategoria(){KategoriaID=4,NazwaKategorii="HTML",NazwaPlikuIkony="html.png",OpisKategorii="opis html"},
                new Kategoria(){KategoriaID=5,NazwaKategorii="Javascript",NazwaPlikuIkony="javascript.png",OpisKategorii="opis javascript"},
                new Kategoria(){KategoriaID=6,NazwaKategorii="jQuery",NazwaPlikuIkony="jquery.png",OpisKategorii="opis jquery"},
                new Kategoria(){KategoriaID=7,NazwaKategorii="XML",NazwaPlikuIkony="xml.png",OpisKategorii="opis XML"}
            };

            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var kursy = new List<Kurs>()
            {
                new Kurs()
                {
                    KursID = 1,
                    AutorKursu = "Mariusz",
                    TytulKursu = "Asp.Net",
                    KategoriaID = 1,
                    CenaKursu = 0,
                    BestSeller = true,
                    NazwaPlikuObrazka = "obrazekaspnet.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs ASP.NET - doskonała platforma do tworzenia dynamicznych aplikacji internetowych. Kurs jest przeznaczony dla wszystkich osób, które chcą nauczyć się od podstaw tworzenia stron internetowych wykorzystując technologię ASP-NET."
                },
                new Kurs()
                {
                    KursID = 2,
                    AutorKursu = "Mariusz",
                    TytulKursu = "Asp.Net Mvc",
                    KategoriaID = 1,
                    CenaKursu = 0,
                    BestSeller = true,
                    NazwaPlikuObrazka = "obrazekmvc.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs ASP.NET MVC - przeznaczony jest dla wszystkich osób, które chcą nauczyć się od podstaw tworzenia stron internetowych wykorzystując technologię ASP-NET MVC."
                },
                new Kurs()
                {
                    KursID = 3,
                    AutorKursu = "Mariusz",
                    TytulKursu = "Asp.Net Mvc - Sklep Internetowy",
                    KategoriaID = 1,
                    CenaKursu = 100,
                    BestSeller = true,
                    NazwaPlikuObrazka = "obrazekmvc2.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs Asp.Net Mvc - Sklep Internetowy - to praktyczne rozwiązanie wykorzystujące technologię Asp.Net Mvc pokazujące krok po kroku budowanie serwisu internetowego sprzedającego kursy on-line"
                },

                new Kurs()
                {
                    KursID = 4,
                    AutorKursu = "Mariusz",
                    TytulKursu = "JavaScript",
                    KategoriaID = 2,
                    CenaKursu = 70,
                    BestSeller = false,
                    NazwaPlikuObrazka = "obrazekjavascript.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs JavaScript - skryptowy język programowania"
                },
                new Kurs()
                {
                    KursID = 5,
                    AutorKursu = "Mariusz",
                    TytulKursu = "jQuery",
                    KategoriaID = 3,
                    CenaKursu = 90,
                    BestSeller = true,
                    NazwaPlikuObrazka = "obrazekjquery.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs jQuery - lekka biblioteka programistyczna dla języka JavaScript"
                },
                new Kurs()
                {
                    KursID = 6,
                    AutorKursu = "Mariusz",
                    TytulKursu = "Html5",
                    KategoriaID = 4,
                    CenaKursu = 70,
                    BestSeller = false,
                    NazwaPlikuObrazka = "obrazekhtml.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs Html5 - język wykorzystywany do tworzenia i prezentowania stron internetowych www"
                },

                new Kurs()
                {
                    KursID = 7,
                    AutorKursu = "Mariusz",
                    TytulKursu = "Css3",
                    KategoriaID = 5,
                    CenaKursu = 70,
                    BestSeller = false,
                    NazwaPlikuObrazka = "obrazekcss.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs Css3 - język służący do opisu formy prezentacji (wyświetlania) stron www"
                },
                new Kurs()
                {
                    KursID = 8,
                    AutorKursu = "Mariusz",
                    TytulKursu = "Xml",
                    KategoriaID = 6,
                    CenaKursu = 60,
                    BestSeller = false,
                    NazwaPlikuObrazka = "obrazekxml.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs Xml - uniwersalny język znaczników przeznaczony do reprezentowania różnych danych w strukturalizowany sposób"
                },
                new Kurs()
                {
                    KursID = 9,
                    AutorKursu = "Mariusz",
                    TytulKursu = "C#",
                    KategoriaID = 7,
                    CenaKursu = 90,
                    BestSeller = true,
                    NazwaPlikuObrazka = "obrazekcsharp.png",
                    DataDodania = DateTime.Now,
                    OpisKursu = "Kurs C# - obiektowy język programowania zaprojektowany dla platformy .Net"
                }
            };
            kursy.ForEach(k => context.Kursy.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}