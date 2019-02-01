using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HATASAYFASI_GUZEL.Controllers
{ [HandleError]
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            int x = 6;
            int y = 0;
            int k = x / y;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}