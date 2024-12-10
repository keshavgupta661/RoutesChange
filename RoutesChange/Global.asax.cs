using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO;

namespace RoutesChange
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start()
        {
            // Track the start of a session
            string sessionStartMessage = $"New session started at {DateTime.Now}. Session ID: {Session.SessionID}";
            LogMessage(sessionStartMessage);
        }


        protected void Application_BeginRequest()
        {
            string requestUrl = HttpContext.Current.Request.Url.ToString();
            string requestStartMessage = $"Request started at {DateTime.Now}. Request URL: {requestUrl}";
            LogMessage(requestStartMessage);
        }


        protected void Application_End()
        {
            string appEndMessage = $"Application ended at {DateTime.Now}";
            LogMessage(appEndMessage);
        }

        private void LogMessage(string message)
        {
            string logFilePath = HttpContext.Current.Server.MapPath("~/App_Data/SessionLog.txt");
            string logEntry = $"{message}\n----------------------------------------\n";
            File.AppendAllText(logFilePath, logEntry);
        }
    }
}
