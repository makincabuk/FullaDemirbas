using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullaDemirbas.Controllers.Entities
{
    public class Demirbas
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }

        public int MagazaId { get; set; }
        public string DemirbasAdi { get; set; }
        public string DemirbasSeriNo { get; set; }
    }
}