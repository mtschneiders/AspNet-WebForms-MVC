using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFormsAndMVC.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult UserData()
        {
            ViewBag.UserName = HttpContext.Session.SessionID;
            return PartialView();
        }
    }
}