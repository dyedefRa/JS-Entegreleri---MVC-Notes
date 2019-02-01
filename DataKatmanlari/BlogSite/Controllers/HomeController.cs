using Blog.BusinessLayer;
using Blog.BusinessLayer.Abstract;
using Blog.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        Repository<Makale> makaleler = new Repository<Makale>();
        // GET: Home
        public ActionResult Index()
        {
            //Test test = new Test();
            return View();
        }
    }
}