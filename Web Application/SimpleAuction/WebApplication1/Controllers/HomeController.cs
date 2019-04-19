using System.Web.Mvc;
using System.Data.Entity;
using WebApplication1.Models;
using System;
using System.Linq;
using WebApplication1.App_Start;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private listofbidEntities _db = new listofbidEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [BasicAuthenticationAttribute("jae", "123", BasicRealm = "your-realm")]
        public ActionResult ShowResult()
        {
            return View(_db.bidtables.ToList());
        }
        [BasicAuthenticationAttribute("jae", "123", BasicRealm = "your-realm")]
        public ActionResult offsetvariable()
        {
            ViewBag.ab = (from a in _db.usp_can_bid() select a).First<string>().Trim();
            ViewBag.sb = (from a in _db.usp_show_bid() select a).First<string>().Trim();            
            return View();

        }

        public void saveVar(FormCollection formData)
        {
            int allowbid = Int32.Parse(formData["ab"]);
            int showbid = Int32.Parse(formData["sb"]);
            _db.usp_editvar(showbid, allowbid);
        }

        public int sumbitBid(FormCollection formData)
        {
            decimal highest_bid = (from a in _db.usp_highest_bidder() select a).First<decimal>();
            string can_bid = (from a in _db.usp_can_bid() select a).First<string>().Trim();

            if(can_bid == "0")
            {
                return 2; //Bid not allow
            }
            if (double.Parse(formData["bid_amount"]) > (double) highest_bid)
            {
                bidtable d_entry = new bidtable();
                d_entry.bid_amount = (decimal)double.Parse(formData["bid_amount"]);
                d_entry.email = Convert.ToString(formData["email"]);
                d_entry.name = Convert.ToString(formData["name"]);
                d_entry.phone = Convert.ToString(formData["phone"]);
                d_entry.description = Convert.ToString(formData["description"]);
                d_entry.reason = Convert.ToString(formData["reason"]);

                _db.bidtables.Add(d_entry);
                return _db.SaveChanges();
            }

            return 3; // not highest 
            
        }
    }
}