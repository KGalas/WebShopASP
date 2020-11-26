namespace WebShop.Models
{
    public class PozycjeZamowienia
    {
        public int PozycjaZamowieniaID { get; set; }
        public int ZamowienieID { get; set; }
        public int KursID { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }

        public virtual Kurs kurs { get; set; }
        public virtual Zamowienie zamowienie { get; set; }
    }
}