using LetsFlip.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsFlip.Controllers
{
    [CustomAuthorize(Roles ="Member")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

    }

}
/*
* [NonAction] Prevent user/action from using the action 
* [ChildActionOnly] Could be use from Html.action/html.renderaction
*/ 
