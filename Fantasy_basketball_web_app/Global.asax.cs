using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Fantasy_basketball_web_app
{
    public class Stats : IEquatable<Stats>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Pts { get; set; }

        public bool Equals(Stats other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
