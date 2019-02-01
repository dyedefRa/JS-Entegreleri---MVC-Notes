using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseCotroller_RolYonetimi.App_Classes
{
    public class FiltreleAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["aktif"] == null)
            {
                filterContext.Result = new RedirectResult("/Home/Login");
                return;
            }


        }
    }
}