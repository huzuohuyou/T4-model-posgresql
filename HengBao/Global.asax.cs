using Exceptionless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HengBao
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ExceptionlessClient.Default.Configuration.ApiKey = "fPsfg0YN82tzmlKt5LkLmGTeiD67wwV0EIopfzw4";
            ExceptionlessClient.Default.Configuration.ServerUrl = "http://localhost:8088";
        }
    }
}
