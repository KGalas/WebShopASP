using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebShop.Models;

namespace WebShop.DAL
{
    public class KursyContext : DbContext
    {
        public KursyContext(): base("KursyContext")
        {

        }

        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowenia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //bez s na koncu nazw tabel
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}