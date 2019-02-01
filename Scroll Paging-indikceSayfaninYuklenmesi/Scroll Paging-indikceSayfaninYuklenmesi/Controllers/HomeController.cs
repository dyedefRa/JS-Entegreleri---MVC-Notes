using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scroll_Paging_indikceSayfaninYuklenmesi.Models;

namespace Scroll_Paging_indikceSayfaninYuklenmesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        int pageSize = 10;
        
        public ActionResult Index(int? page)
        {

            CTXContext ctx = new CTXContext();
            List<Customers> musteriler = null;
            //ILK ACILIS ISE, SCROL OLAYI YOKSA
            //PAGE PARAMETRESININ VALUESI YOKSA
            if (!page.HasValue)
            {
                //ILK 10 KAYIT GELSIN
                musteriler = ctx.Customers.OrderByDescending(y=>y.CustomerID).Take(pageSize).ToList();
            }
            else
            {
                //YOKSA EN SON GONDERDIGIMDEN BASLAYARAK 10 KAYIT YOLLAYACAGIM
                
                int pageIndex = (page.Value) * 10;
                musteriler = ctx.Customers.OrderByDescending(y => y.CustomerID).Skip(pageIndex).Take(pageSize).ToList();
            }
            //AJAX METODU ISE PARTIAL VIEW OLARAK DON
            if (Request.IsAjaxRequest())
            {
           return PartialView("CustomerWidger", musteriler);
            }
           
            //DEGILSE (ILK ACILIYORDUR)
            return View(musteriler);
            
        }
    }
}