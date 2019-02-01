using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingDropDownList.App_Classes;

namespace CascadingDropDownList.Controllers
{
    public class HomeController : Controller
    {
       CascandingContext ctx = new CascandingContext();

        // GET: Home
        public ActionResult Index()
        { 

            var gonderilecek =new  List<SelectListItem>();
            gonderilecek.Add(new SelectListItem { Text = "Seçiniz", Value = "" });
            gonderilecek.AddRange(ctx.Sehirler.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Ad

            }).ToList());

            ViewBag.SehirID = gonderilecek;
            return View();
        }

        public ActionResult SehirIlceSec(string SehirID,string IlceID)
        {
            //BURAYI SAGLADI BASARILI DURUM 
            return View();
        }

        public ActionResult ikinciDropWidget(int? id)
        {
            if (id==0)
            {
                return null;
            }
            var ilceler = ctx.Ilceler.Where(x => x.SehirId == id);
            if (ilceler==null)
            {
                return null;
            }
            var gonderilecek = new List<SelectListItem>();
            gonderilecek.Add(new SelectListItem { Text = "Seçiniz", Value = "" });
            gonderilecek.AddRange(ilceler.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Adi

            }).ToList());

            ViewBag.IlceID = gonderilecek;
            return View();
        }
    }
}