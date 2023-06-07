using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        BrandManeger bm = new BrandManeger(new EfBrandDal());
        public ActionResult Index()
        {
            var brandvalues = bm.GetList();
            return View(brandvalues);
        }
    }
}