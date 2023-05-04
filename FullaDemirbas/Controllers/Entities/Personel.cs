using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullaDemirbas.Controllers.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Tcno { get; set; }
        public string Telefon { get; set; }
        public int MagazaId { get; set; }
    }
}