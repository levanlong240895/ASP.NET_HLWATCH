using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HoangLongWatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{*botdetect}", new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

           routes.MapRoute(
           name: "Logout",
           url: "dang-xuat",
           defaults: new { controller = "User", action = "Logout", page = UrlParameter.Optional },
           namespaces: new[] { "HoangLongWatch.Controllers" }
       );

            routes.MapRoute(
            name: "Sign In",
            url: "dang-nhap",
            defaults: new { controller = "User", action = "Login", page = UrlParameter.Optional },
            namespaces: new[] { "HoangLongWatch.Controllers" }
        );

            routes.MapRoute(
             name: "Success",
             url: "thanh-cong",
             defaults: new { controller = "Cart", action = "Success", page = UrlParameter.Optional },
             namespaces: new[] { "HoangLongWatch.Controllers" }
         );

            routes.MapRoute(
              name: "Payment",
              url: "thanh-toan",
              defaults: new { controller = "Cart", action = "Payment", page = UrlParameter.Optional },
              namespaces: new[] { "HoangLongWatch.Controllers" }
          );

            routes.MapRoute(
              name: "Add to Cart",
              url: "them-gio-hang",
              defaults: new { controller = "Cart", action = "AddItem", page = UrlParameter.Optional },
              namespaces: new[] { "HoangLongWatch.Controllers" }
          );

            routes.MapRoute(
               name: "Cart",
               url: "gio-hang",
               defaults: new { controller = "Cart", action = "Index", page = UrlParameter.Optional },
               namespaces: new[] { "HoangLongWatch.Controllers" }
           );

            routes.MapRoute(
               name: "Products List",
               url: "san-pham",
               defaults: new { controller = "Product", action = "Index", page = UrlParameter.Optional },
               namespaces: new[] { "HoangLongWatch.Controllers" }
           );

            routes.MapRoute(
                name: "Product Detail",
                url: "san-pham/{metatitle}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "HoangLongWatch.Controllers" }
            );

            routes.MapRoute(
               name: "Contact",
               url: "lien-he",
               defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "HoangLongWatch.Controllers" }
           );

            routes.MapRoute(
              name: "Register",
              url: "dang-ky",
              defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
              namespaces: new[] { "HoangLongWatch.Controllers" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "HoangLongWatch.Controllers" }
            );
        }
    }
}
