using Entity;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["User"] = new User { Name = HttpContext.Current.User.Identity.Name };
            Session["Customers"] = new List<Customer> { new Customer { Name = "bla1" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" }, new Customer { Name = "bla2" } };
        }
        
    }
}