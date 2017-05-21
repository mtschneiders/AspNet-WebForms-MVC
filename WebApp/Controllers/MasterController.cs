using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class MasterController : ApplicationController
    {
        // GET: Master
        public ActionResult UserData()
        {
            ViewBag.UserName = HttpContext.Session.SessionID;
            return PartialView();
        }
    }
}