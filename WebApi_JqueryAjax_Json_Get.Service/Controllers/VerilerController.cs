using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_JqueryAjax_Json_Get.Service.Controllers
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    public class VerilerController : ApiController
    {
        List<Insan> insanListe = new List<Insan>();

        public VerilerController()
        {
            #region isimler
            Insan insan1 = new Insan()
            {
                Ad = "ibrahim",
                Soyad = "bavlı",
                Yas = 25
            };
            Insan insan2 = new Insan()
            {
                Ad = "ali",
                Soyad = "veli",
                Yas = 26
            };
            Insan insan3 = new Insan()
            {
                Ad = "ahmet",
                Soyad = "mehmet",
                Yas = 27
            };
            Insan insan4 = new Insan()
            {
                Ad = "hasan",
                Soyad = "huseyin",
                Yas = 27
            };
            insanListe.Add(insan1);
            insanListe.Add(insan2);
            insanListe.Add(insan3);
            insanListe.Add(insan4);
            #endregion
        }

        public List<Insan> GetInsanlar()
        {
            return insanListe;
        }
    }
}
