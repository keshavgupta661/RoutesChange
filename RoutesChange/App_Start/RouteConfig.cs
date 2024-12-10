using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutesChange
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //for attribute way
            //routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "data",
                "about-us",
                new { controller = "Home", action = "About" }
                );

            routes.MapRoute(
                "phone",
                "contact-us",
                new { controller = "Home", action = "Contact" }
                );

            routes.MapRoute(
                "allStudents",
                "students",
                new {controller = "Student", action = "GetAllStudents", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                "student",
                "students/{id}",
                new { controller = "Student", action = "GetStudent" , id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
                );

            routes.MapRoute(
                "studentAddress",
                "students/{id}/Address",
                new { controller = "Student", action = "GetStudentAddress" , id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
