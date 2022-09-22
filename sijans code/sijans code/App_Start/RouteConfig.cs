using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace sijans_code
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "fifa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "my", action = "Intro", id = UrlParameter.Optional }
            );
        }
    }
}
