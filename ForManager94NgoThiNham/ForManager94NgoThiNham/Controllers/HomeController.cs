using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForManager94NgoThiNham.ViewModel;

namespace ForManager94NgoThiNham.Controllers
{
    public class HomeController : Controller
    {
        FordViewModel db = new FordViewModel();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetSanPham()
        {
            var list= db.Tinhs.ToList();
            return View(list);
        }
      
    }
}