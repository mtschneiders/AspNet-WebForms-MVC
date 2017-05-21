using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class MasterController : ApplicationController
    {
        [ChildActionOnly]
        public ActionResult GetUserData()
        {
            ViewBag.UserName = UserData?.Name;
            return PartialView();
        }
    }
}