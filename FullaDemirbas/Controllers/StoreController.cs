using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullaDemirbas.Controllers
{
    public class StoreController : Controller
    {
        StoreManeger SM = new StoreManeger(new EfStoreDal());

        // GET: Store
        public ActionResult Index()
        {
            var Storevalues = SM.GetList();
            return View(Storevalues);
        }

    }
}