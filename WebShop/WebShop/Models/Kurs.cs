using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Kurs
    {
        public int KursID { get; set; }


        public int KategoriaID { get; set; }

        public string TytulKursu { get; set; }

        public string AutorKursu { get; set; }

        public DateTime DataDodania { get; set; }

        public string NazwaPlikuObrazka { get; set; }

        public string OpisKursu { get; set; }

        public decimal CenaKursu { get; set; }

        public bool BestSeller { get; set; }

        public bool Ukryty { get; set; }
        public virtual Kategoria kategoria { get; set; }
    }
}