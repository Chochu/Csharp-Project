using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web.UI;
using System.Web.Script.Serialization;

namespace RunescapeGEPrice
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        bool GoodMargin(int x, int y)
        {
            double buyprice = x, sellprice = y;
            if (((sellprice - buyprice) / buyprice * 100 > Double.Parse(LowTB.Text)) && ((sellprice - buyprice) / buyprice * 100 < Double.Parse(HighTB.Text)))
                return false;
            return true;

        }
        bool WithinPrice(int x, int min, int max)
        {
            if ((min <= x) && (max >= x))
                return false;
            return true;

        }

        //Html string -> Json data -> List
        void GetData()
        {
            if (LowTB.Text == "" || HighTB.Text == "")
            {
                MessageBox.Show("Make Sure your High and Low Margin are number", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string URL = "https://rsbuddy.com/exchange/summary.json";
            string datatext;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            datatext = sr.ReadToEnd();
            sr.Close();

            System.IO.StreamWriter file = new System.IO.StreamWriter("item.txt");
            Boolean skip = false;
            for (int x = 0; x < datatext.Length; x++)
            {

                //Copy website data to text file, with trimming object name to MemberObject
                try
                {
                    //trimming the first 6 char, due to it unquie condition
                    if(x == 0){
                        file.Write("[");
                        //file.Write(datatext[x] + "\"MemberObject\":");
                        continue;
                    }
                    if (x >= 1 && x <= 5){
                        continue;
                    }
                    if (x == datatext.Length-1){
                        file.Write("]");
                        break;
                    }
                    
                    //if end of the object string, create a newline + keep skipping until { + add text Memberobject
                    if(datatext[x] == ',' && datatext[x - 1] == '}'){
                        skip = true;
                        file.WriteLine(datatext[x]);
                        //file.Write("\"MemberObject\":");
                        continue;
                    }
                    
                    //Cancel Skipping
                    if(datatext[x] == '{' && datatext[x - 1] == ' '){
                        skip = false;
                        file.Write(datatext[x]);
                        continue;
                    }

                    //Skipping Text
                    if (skip){
                        continue;
                    }
                    else{
                        file.Write(datatext[x]);
                    }
                }
                catch (Exception e)
                {
                    textBox1.AppendText(e.Message + "\n");
                }

            }
            
            file.Close();

            try
            { // sell = 10 buy: 9
                sr = new StreamReader("item.txt") ;               
                string newDataString = sr.ReadToEnd();
                sr.Close();
                JavaScriptSerializer JSS = new JavaScriptSerializer();
                List<RSItem> listofRSItem = (List<RSItem>)JSS.Deserialize(newDataString, typeof(List<RSItem>));
                SortableBindingList<RSItem> NewListRSItem = new SortableBindingList<RSItem>();

                foreach (RSItem rsitem in listofRSItem)
                {
                    if (rsitem.overall_average == 0)
                        continue;

                    if (checkBox1.Checked == true)
                    {
                        if (GoodMargin(rsitem.buy_average, rsitem.sell_average))
                            continue;
                    }

                    if (checkBox2.Checked == true)
                    {
                        if (WithinPrice(rsitem.buy_average, Int32.Parse(PriceRangeMin.Text), Int32.Parse(PriceRangeMax.Text)))
                            continue;
                    }

                    rsitem.profit = (rsitem.sell_average - rsitem.buy_average);

                    if (checkBox3.Checked == true)
                    {
                        if (WithinPrice(rsitem.profit, Int32.Parse(ProfitRangeMin.Text), Int32.Parse(ProfitRangeMax.Text)))
                            continue;
                    }

                    if (checkBox4.Checked == true)
                    {
                        rsitem.total_profit = rsitem.profit * Int32.Parse(amountTB.Text);
                    }
                    NewListRSItem.Add(rsitem);
                }
                //this.dGV1.DataSource = NewListRSItem;

                //use binding source to hold dummy data
                BindingSource binding = new BindingSource();
                binding.DataSource = NewListRSItem;

                //bind datagridview to binding source
                dGV1.DataSource = binding;
                
            }
                
            catch (Exception e)
            {
                textBox1.AppendText(e.Message + "\n");
            }

        }


        private void dGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string x = dGV1[0, e.RowIndex].Value.ToString();
                if (Int32.Parse(x) >= 0)
                    System.Diagnostics.Process.Start("http://lets-flip.com/pages/2007-oldschool-runescape-flip-chart/?item=" + x);
            }
            catch (Exception Error)
            {
                //textBox1.AppendText(Error.Message + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://lets-flip.com");
        }
    }
}
