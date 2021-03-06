﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Ultra.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                , namespaces: new[] { "Ultra.Web.Controllers" });
        }
    }
}