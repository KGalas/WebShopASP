using System.Collections.Generic;

namespace WebShop.Models
{
    public class Kategoria
    {
        public int KategoriaID { get; set; }
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }
        public virtual ICollection<Kurs> Kurs { get; set; }
    }
}