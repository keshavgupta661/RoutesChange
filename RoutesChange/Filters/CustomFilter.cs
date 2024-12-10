using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutesChange.Filters
{
    public class CustomFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Hello OnActionExecuted");
            filterContext.Controller.ViewBag.Message = "Keshav from action filter";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hello OnActionExecuting");
        }
    }
}