// Developer Express Code Central Example:
// Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension
// 
// This code example implements the approaches described in the
// http://www.devexpress.com/scid=T108044 knowledge base article. Please refer to
// the article above for implementation details.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T108173

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Localization {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e) {
            if (Request.Cookies["Culture"] != null && !string.IsNullOrEmpty(Request.Cookies["Culture"].Value)) {
                string culture = Request.Cookies["Culture"].Value;
                CultureInfo ci = new CultureInfo(culture);
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = ci;
            }
        }
    }
}