using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FullaDemirbas.Controllers.Entities;

namespace FullaDemirbas.Controllers.Context
{
    public class MvcDemirbasContext :DbContext
    {
        public MvcDemirbasContext() : base("Server=.;Database=MvcDemirbasDB;Trusted_Connection=true")
        { } 
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Magaza> Magazalar { get; set; }
        public DbSet<Demirbas> Demirbaslar { get; set; }

    }
}