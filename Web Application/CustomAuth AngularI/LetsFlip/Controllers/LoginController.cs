using LetsFlip.Class;
using LetsFlip.Filter;
using LetsFlip.Library;
using LetsFlip.Models;
using LetsFlip.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsFlip.Controllers
{
    public class LoginController : Controller
    {
        private ILoginRepository LoginRepo = null;

        public LoginController()
        {
            this.LoginRepo = new LoginRepository(new OSRSDatabaseEntities());
        }

        public LoginController(ILoginRepository LoginRepo)
        {
            this.LoginRepo = LoginRepo;
        }

        // GET: Login
        //[OutputCache(Duration = 20)] //standcache
        [OutputCache(CacheProfile = "1MinCache")] //refence to the cache in name in web.config
        [ActionName("Login")]
        //[ActionFilterA]
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Auth(Login loginDetail)
        {
            if(LoginRepo.AuthenicateLogin(loginDetail.Username, loginDetail.Password))
            {
                var users = LoginRepo.getUserObj(loginDetail.Username);
                if(users != null)
                {
                    Session["UserAcc"] = users; //Store User in session
                    SessionPersister.Username = users.Username; //Store user name in static class
                    return RedirectToAction("Index", "Home");
                }                                
            }
            return View("Index");
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}