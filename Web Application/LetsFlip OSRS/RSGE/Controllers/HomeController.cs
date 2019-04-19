using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace RSGE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["LogedUserID"] != null)
            {
                return RedirectToAction("Chart");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginInfo u)
        {
            //this action is for handle post (login)
            if (ModelState.IsValid)
            {
                using (UserLoginEntities dc = new UserLoginEntities())
                {
                    var v = dc.LoginInfoes.Where(a => a.Username.Equals(u.Username) && a.Userpw.Equals(u.Userpw)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["logedUserID"] = v.Id.ToString();
                        Session["LogedUsername"] = v.Username.ToString();
                        return RedirectToAction("Chart");
                    }
                }
            }
            ViewBag.Message = "Invalid User and Password Combination";
            return View(u);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }

        public ActionResult Chart()
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }
            using (WebClient wc = new WebClient())//Get sell/buy price of all the item
            {
                var json = wc.DownloadString("https://rsbuddy.com/exchange/summary.json");
                using (StreamWriter writer = new StreamWriter(Server.MapPath("/JsonData/summary.json"), false))
                {
                    writer.WriteLine(json);
                }
            }

            return View();
        }
        public ActionResult Graph(int? ID, string name)
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }

            var json = new WebClient().DownloadString("https://api.rsbuddy.com/grandExchange?a=graph&start=1425921352106&g=1440&i=" + ID);
            ViewData["webtext"] = json;
            ViewData["id"] = ID;
            ViewBag.Message = name;
            //json = new WebClient().DownloadString("http://services.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + ID); // use for getting item information
            //Regex regex = new Regex(@"""name"":"".+"",""de"); //use regex to get the item name
            //Match match = regex.Match(json);
            //ViewBag.Message = match.Value.Remove(0, 8).Replace("\",\"de", "");//trim text

            return View();
        }


        public ActionResult Alch()
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }
           
            return View();
        }
        public ActionResult CleanHerb()
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }


            return View();
        }
        public ActionResult UnfPotion()
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }


            return View();
        }
        public ActionResult SetPacking()
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }


            return View();
        }
        public ActionResult Decant()
        {
            if (Session["LogedUserID"] == null)
            {
                ViewBag.Message = "Please Login";
                return RedirectToAction("Index");
            }


            return View();
        }
    }
}
