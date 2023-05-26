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
    public class SubCategoryController : Controller
    {
        // GET: SubCategory
        SubCategoryManager sm = new SubCategoryManager(new EfSubCategoryDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var subcategoryvalues = sm.GetList();
            return View(subcategoryvalues);
        }
        [HttpGet]
        public ActionResult AddSubCategory()
        {

            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }
                                                ).ToList();
            ViewBag.vlsc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory Sb)
        {
            sm.SubCategoryAdd(Sb);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditSubCategory(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }
                                                  ).ToList();
            ViewBag.vlsc = valuecategory;
            var SubCategoryValue = sm.GetByID(id);
            return View(SubCategoryValue);


        }
    }
}