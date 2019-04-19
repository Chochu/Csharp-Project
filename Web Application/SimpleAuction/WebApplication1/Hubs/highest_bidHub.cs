using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class highest_bidHub : Hub
    {
        private listofbidEntities _db = new listofbidEntities();
        static double highest_bid_amount = 0.0;


        public void Send()
        {
            while (true)
            {
                highest_bid_amount = (double)(from a in _db.usp_highest_bidder() select a).First<decimal>();
                string showbid = (from a in _db.usp_show_bid() select a).First<string>().Trim();    
                if(showbid == "1")
                    Clients.All.UpdateBid(highest_bid_amount);
                else
                {
                    Clients.All.UpdateBid(-0.1);
                }
                System.Threading.Thread.Sleep(5000);
            }

        }
    }
}