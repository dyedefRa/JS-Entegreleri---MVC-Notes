 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQuery_Dialog__pencereAcmaOlaylari.Models;

namespace jQuery_Dialog__pencereAcmaOlaylari.Controllers
{
    public class HomeController : Controller
    {
        CTXContext ctx = new CTXContext();
        // GET: Home
        public ActionResult Index()
        {


            var data = ctx.Kullanici.OrderByDescending(x => x.Id).ToList();


            return View(data);
        }

        [HttpPost]
        public string KullaniciEkle(Kullanici temp)
        {
          
            if (temp.Id > 0)
            {
                if (ctx.SaveChanges() > 0)
                {
                  return  "Güncelleme işlemi başarılı";
                }
                else
                {
                    return "Güncelleme işleminde sorun oluştu";
                }
                
            }
            
                ctx.Kullanici.Add(temp);
            if (ctx.SaveChanges() > 0)
            {
                return "Ekleme işlemi başarılı";
            }
            return "Ekleme işleminde sorun oluştu";


        }
    }
}