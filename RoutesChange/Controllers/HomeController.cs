using RoutesChange.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutesChange.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string userAgent = Request.Headers["User-Agent"];

            if (!string.IsNullOrEmpty(userAgent))
            {
                // User-Agent ko view me bhejna
                ViewBag.UserAgent = userAgent;
            }
            else
            {
                ViewBag.UserAgent = "User-Agent not found!";
            }
            return View();
        }
        //This is for attribute way of routing.
        //[Route("about-us")]
        public ActionResult About()
        {
            Response.Headers.Add("Cache-Control", "public, max-age=3600");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST");
            Response.Headers["MyHeader"] = "Hello, this is testing..";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //This is for attribute way of routing.
        //[Route("contact-us")]
        [OverrideActionFilters]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}