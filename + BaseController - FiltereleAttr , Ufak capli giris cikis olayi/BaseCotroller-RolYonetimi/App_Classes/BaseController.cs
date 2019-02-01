using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseCotroller_RolYonetimi.App_Classes
{
    public class BaseController:System.Web.Mvc.Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;

//HOME CONTOLLERINI BASECONTROLLERDAN MIRAS ALDIRMAK GEREK 
            //if (controller=="Home" && actionName=="Index"|| controller == "Home" && actionName=="Login")
            //{
            //   base.OnActionExecuting(filterContext);
            //    return;
            //}
            
           
            
            if (Session["aktif"] == null)
            {
                filterContext.Result = new RedirectResult("/Home/Index");
            }
           


            base.OnActionExecuting(filterContext);
        }
    }
}