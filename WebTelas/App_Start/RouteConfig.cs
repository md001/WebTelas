using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebTelas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Dashboard",                                       // Route name
                "Dashboard",                                       // URL with parameters
                new { controller = "Dashboard", action = "Home" }  // Parameter defaults
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // controller = Views\"<Nombre>" action = Views\Nombre\"Nombre".cshtml
                // defaults: new { controller = "Dashboard", action = "Home", id = UrlParameter.Optional }
                defaults: new { controller = "FrontEnd", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
