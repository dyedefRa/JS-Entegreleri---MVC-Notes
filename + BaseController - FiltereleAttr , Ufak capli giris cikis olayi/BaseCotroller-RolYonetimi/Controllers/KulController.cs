using BaseCotroller_RolYonetimi.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseCotroller_RolYonetimi.Controllers
{
    public class KulController : BaseController
    {
        // GET: Kul
        public ActionResult Index()
        {
            return View();
        }

        

        // GET: Kul/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}
