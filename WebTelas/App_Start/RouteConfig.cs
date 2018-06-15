﻿using System;
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
                name: "Default",
                url: "{controller}/{action}/{id}",
                // controller = Views\"<Nombre>" action = Views\Nombre\"Nombre".cshtml
                defaults: new { controller = "Dashboard", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
