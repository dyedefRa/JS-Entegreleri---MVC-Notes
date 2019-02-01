using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gencay.Models;
using gencay.App_Classes;
using System.Threading;


namespace gencay.Controllers
{
    public class HomeController : Controller
    {
        CTX ctx = new CTX();
        // GET: Home
        public ActionResult Index()
        {
            return View(ctx.Products.ToList());
        }

        public JsonResult AjaxProductSil(int idcik)
        {
            var urun = ctx.Products.ToList().Find(x => x.ProductID == idcik);
            ctx.Products.Remove(urun);
            ctx.SaveChanges();
            //Thread.Sleep(5000);
            return Json(new JSONRESULT { Durum = true, Mesaj = "Başarılı" });

        }

        public ActionResult AutoCompleteOlayi(string q)
        {
            var urunIsmi = ctx.Products.Where(x => x.ProductName.Contains(q)).Take(10).Select(x => x.ProductName).ToList();


            var icerik = string.Join<string>("\n", urunIsmi);

            return Content(icerik);
        }
    }
}