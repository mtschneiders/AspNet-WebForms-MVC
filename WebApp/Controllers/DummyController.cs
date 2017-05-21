using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class DummyController : ApplicationController
    {
        // GET: Dummy
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page." + UserData.Name;

            WindowsIdentity clientId = (WindowsIdentity)HttpContext.User.Identity;

            return View();
        }

        [ChildActionOnly]
        public ActionResult GetStuff()
        {
            return PartialView();
        }
    }
}