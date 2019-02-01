using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseCotroller_RolYonetimi.App_Classes;

namespace BaseCotroller_RolYonetimi.Controllers
{
    public class HomeController :Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Filtrele]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Filtrele]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Login(KullaniciModel temp)
        {
            if (temp.KullaniciAdi=="admin"||temp.Parola==123.ToString())
            {
                Session["girisUyari"] = null;
                Session["aktif"] = temp.KullaniciAdi;
                return RedirectToAction("Index");
            }
            Session["girisUyari"] = "Giriş başarısız";
            return View();
        }

    }
}