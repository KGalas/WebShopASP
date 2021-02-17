﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Kurs
    {
        public int KursID { get; set; }


        public int KategoriaID { get; set; }

        [Required(ErrorMessage ="Wprowadź nazwę kursu")]
        [StringLength(100)]
        public string TytulKursu { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwę autora")]
        [StringLength(100)]
        public string AutorKursu { get; set; }

        public DateTime DataDodania { get; set; }

        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }

        public string OpisKursu { get; set; }

        public decimal CenaKursu { get; set; }

        public bool BestSeller { get; set; }

        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }

        public virtual Kategoria kategoria { get; set; }
    }
}