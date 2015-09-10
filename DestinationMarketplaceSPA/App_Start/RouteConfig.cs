// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2015 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Mvc;
using App.DestinationMarketplaceSPA.Routing;

namespace App.DestinationMarketplaceSPA
{
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
//            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
//
//            routes.MapRoute(
//                name: "Default",
//                url: "{controller}/{action}/{id}",
//                defaults: new { action = UrlParameter.Optional, id = UrlParameter.Optional }
//            );
            routes.Add("Default", new DefaultRoute());
        }
    }
}
