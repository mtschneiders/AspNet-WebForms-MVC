using Entity;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApp.App_Start;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["User"] = new User { Name = HttpContext.Current.User.Identity.Name };
            Session["Customers"] = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },
                new Customer { Name = "Customer 3" },
                new Customer { Name = "Customer 4" },
                new Customer { Name = "Customer 5" },
                new Customer { Name = "Customer 6" },
                new Customer { Name = "Customer 7" },
                new Customer { Name = "Customer 8" },
                new Customer { Name = "Customer 9" },
                new Customer { Name = "Customer 10" },
                new Customer { Name = "Customer 11" },
                new Customer { Name = "Customer 12" },
                new Customer { Name = "Customer 13" },
                new Customer { Name = "Customer 14" },
                new Customer { Name = "Customer 15" },
                new Customer { Name = "Customer 16" },
                new Customer { Name = "Customer 17" },
                new Customer { Name = "Customer 18" },
                new Customer { Name = "Customer 19" } };
        }
        
    }
}