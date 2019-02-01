using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HATASAYFASI_GUZEL.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult SayfaYok(string aspxerrorpath)
        {
           ViewBag.deger = aspxerrorpath;
            return View();
        }
    }
}