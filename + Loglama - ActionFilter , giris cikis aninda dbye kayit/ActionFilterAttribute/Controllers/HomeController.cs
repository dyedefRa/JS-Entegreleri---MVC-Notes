using ActionFilterAttribute.Filtreler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterAttribute.Controllers
{
    [ActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sayfa2()
        {
            return View();
           
        }
        public ActionResult ThrePaged()
            {
                return View();
            }
    }
}