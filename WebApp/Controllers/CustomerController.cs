using Entity;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CustomerController : ApplicationController
    {
        private List<Customer> Customers
        {
            get
            {
                if (Session["Customers"] == null)
                    Session["Customers"] = new List<Customer>();

                return Session["Customers"] as List<Customer>;
            }
        }
        
        // GET: Dummy
        public ActionResult Index()
        {
            return View(Customers);
        }

        public RedirectToRouteResult Add(Customer customer)
        {
            Customers.Add(customer);
            return RedirectToAction("Index");
        }
        

    }
}