using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSRS_Web_Angular.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var webClient = new System.Net.WebClient())
            {
                var result = "[" + webClient.DownloadString("https://rsbuddy.com/exchange/summary.json") + "]";
                //var result = "[" + webClient.DownloadString("https://api.rsbuddy.com/grandExchange?a=guidePrice&i=2") + "]";
                string tex = Server.MapPath("/Views/Home/summary.json");
                using (StreamWriter outputFile = new StreamWriter(Server.MapPath("/Views/Home/summary.json")))
                {
                    outputFile.Write(result);
                    outputFile.Flush();
                    outputFile.Close();
                }
            }
            return View();
        }
        public ActionResult genChart()
        {
            return PartialView("chartView");
        }
        public ActionResult genTable()
        {
            return PartialView("listView");
        }

        public ActionResult getchartid(int id)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var result = webClient.DownloadString("https://api.rsbuddy.com/grandExchange?a=graph&i="+ id + "&g=1440");
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult getchartidgstart(int id, string g, string start)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var result = webClient.DownloadString("https://api.rsbuddy.com/grandExchange?a=graph&i=" + id + "&g=" + g + "&start=" + start);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult itemTable()
        {
            var temptext = string.Empty;
            using (StreamReader readJson = new StreamReader(Server.MapPath("/Views/Home/summary.json")))
            {
                temptext = readJson.ReadToEnd();
            }
            return Json(temptext, JsonRequestBehavior.AllowGet);
        }
    }
}