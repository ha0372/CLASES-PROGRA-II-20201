using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PracticaClase02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",  
                defaults: new { /*no*/controller = "Home", action = "Index", id = UrlParameter.Optional }/*archivo de configuracion*/
                /*no es necesario involucara controler porque ya lo estamops especificando arriva*/
            );
        }
    }
}
