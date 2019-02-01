using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Searching(string temp)
        {
            NorthwindEntities ctx = new NorthwindEntities();
            var data = ctx.Categories.Where(x => x.CategoryName.StartsWith(temp));
            if (data==null)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            var gonder = from i in data
                         select new
                         {
                             id = i.CategoryID,
                             value = i.CategoryName
                         };
            return Json(gonder, JsonRequestBehavior.AllowGet);
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