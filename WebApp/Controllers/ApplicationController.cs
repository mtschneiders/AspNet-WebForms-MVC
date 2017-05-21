using Entity;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    /// <summary> 
    /// Serves as a base for all other controllers
    /// Contains User level data
    /// </summary>
    public class ApplicationController : Controller
    {
        public User UserData => Session["User"] as User;
    }
}