using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ApplicationController : Controller
    {
        public User UserData => Session["User"] as User;
    }
}