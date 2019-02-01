using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetAlert.Controllers
{
    public class SweetController : Controller
    {
        // GET: Sweet
      
        public ActionResult Merhaba()
        {
            return View();
        }

        public string Deneme(string sonuc)
        {
            if (sonuc=="okey")
            {
                return "başarılı";
            }

            return "başarısız";
        }

    }
}