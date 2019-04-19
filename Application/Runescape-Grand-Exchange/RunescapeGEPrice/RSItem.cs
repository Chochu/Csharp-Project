using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RunescapeGEPrice
{
    public class RSItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int overall_average { get; set; }
        public int sell_average { get; set; }
        public int buy_average { get; set; }
        public int profit { get; set; }
        public int total_profit { get; set; }
    }


}

