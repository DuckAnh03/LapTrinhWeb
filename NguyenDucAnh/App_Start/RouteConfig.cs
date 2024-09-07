using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NguyenDucAnh
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DanhSach",
                url: "danh-sach-thanh-vien",
                defaults: new { controller = "NguyenDucAnh", action = "DanhSach" },
                namespaces: new string[]
                {"NguyenDucAnh.Controllers"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "NguyenDucAnh", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
