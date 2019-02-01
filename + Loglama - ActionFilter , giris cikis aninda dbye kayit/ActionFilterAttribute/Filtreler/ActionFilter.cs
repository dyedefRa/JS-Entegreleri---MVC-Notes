using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionFilterAttribute.Models;

namespace ActionFilterAttribute.Filtreler
{
    public class ActionFilter : FilterAttribute, IActionFilter
    {
        CTX ctx = new CTX();

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ctx.logger.Add(new Logging
            {
                ActionName = filterContext.ActionDescriptor.ActionName,
                ContollerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                CreatedTime = DateTime.Now,
                Bilgi = "Çıkış yapıldı",


            });
            ctx.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ctx.logger.Add(new Logging
            {
                ActionName = filterContext.ActionDescriptor.ActionName,
                ContollerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                CreatedTime = DateTime.Now,
                Bilgi = "Girildi",
                
                
            });
            ctx.SaveChanges();
        }
    }
}