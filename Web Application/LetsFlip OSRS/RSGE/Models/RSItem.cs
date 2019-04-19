using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSGE.Models
{
    public class RSItem
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public Boolean isMember { get; set; }
        public int SellAverage { get; set; }
        public int BuyAverage { get; set; }
        public int OverAverage { get; set; }

    }
}