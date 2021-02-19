using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebShop.Infrastructure
{
    public class AppConfig
    {
        private static string _IkonyKategoriFolderWzgledny = ConfigurationManager.AppSettings["IkonyKategoriiFolder"];

        public static string IkonyKategoriFolderWzgledny { get => _IkonyKategoriFolderWzgledny; }

        private static string _ObrazkiFolderWzgledny = ConfigurationManager.AppSettings["ObrazkiFolder"];

        public static string ObrazkiFolderWzgledny { get => _ObrazkiFolderWzgledny; }
    }
}