using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        [HttpGet]
        public ActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBrand(Brand brand)
        {
            bm.BrandAdd(brand);
            return RedirectToAction("Index");
        }
    }
}