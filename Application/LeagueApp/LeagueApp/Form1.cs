using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
namespace LeagueApp
{
    public partial class Form1 : Form
    {
        private string userKey = "899fd29c-1b5e-435f-821b-6aa28087af60";
        private string summonerNames = "";
        private string summonerID = "";
        private string gameVer = "6.3.1";

        //private List<int> freechamplist = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        //Get all the text from the URL, return as string
        private string getWebString(string URL)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData(URL);
            string webData = System.Text.Encoding.UTF8.GetString(raw);
            return webData;
        }


        //add text to feedback log
        private void tlog(string disText)
        {
            feebacklog.AppendText(disText);
        }

        //Get Summoner ID
        private void getSummoner_Click(object sender, EventArgs e)
        {
            if (SummonerNameTextbox.Text != "")
            {
                summonerNames = SummonerNameTextbox.Text;
                try
                {
                    summonerID = getWebString("https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" + summonerNames + "?api_key=" + userKey);
                    Regex r = new Regex(@"id"":\d+,", RegexOptions.IgnoreCase);
                    Match onematch = r.Match(summonerID);
                    if (onematch.Success)
                    {
                        summonerID = onematch.Value;
                        r = new Regex(@"\d+", RegexOptions.IgnoreCase);
                        summonerID = r.Match(summonerID).Value;
                        tlog("Summoner Name: " + summonerNames + "\n");
                        tlog("Summoner ID: " + summonerID);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Invalid Username");
                }
            }
            else
                MessageBox.Show("Please enter a Summoner Name before fetching data");
        }

        //During Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //Load free champion for the week
        //Get data from league API and then download image from ddragon.leagueoflegends.com
        private void LoadFreeChamp()
        {
            try
            {
                FCListView.Clear();
                ImageList images = new ImageList();
                images.ImageSize = new Size(64, 64);
                String stringFreeChamp = getWebString("https://na.api.pvp.net/api/lol/na/v1.2/champion?freeToPlay=true&api_key=899fd29c-1b5e-435f-821b-6aa28087af60");
                Regex r = new Regex(@"\d+", RegexOptions.IgnoreCase);
                MatchCollection multimatch = r.Matches(stringFreeChamp);

                foreach (Match m in multimatch)
                {
                    //freechamplist.Add(int.Parse(r.Match(m.ToString()).Value));
                    images.Images.Add(LoadImage("http://ddragon.leagueoflegends.com/cdn/" + gameVer + "/img/champion/" + GetChampName(m.Value) + ".png"));
                }
                FCListView.LargeImageList = images;
                int counter = 0;
                foreach (Match m in multimatch)
                {
                    FCListView.Items.Add(GetChampName(r.Match(m.ToString()).Value), counter);
                    counter++;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Unable to get free champion");
            }
        }

        //Takes an id and return the champion name
        private string GetChampName(string id)
        {
            try
            {
                Regex r = new Regex(@"ey"":""\w+""", RegexOptions.IgnoreCase);
                string ChampName = getWebString("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion/" + id + "?api_key=899fd29c-1b5e-435f-821b-6aa28087af60");
                ChampName = r.Match(ChampName).Value;
                r = new Regex(@"(\w{3,}|Vi)");
                ChampName = r.Match(ChampName).Value;
                return ChampName;
            }
            catch (Exception error)
            {
                MessageBox.Show(error + "");
            }
            return id;
        }

        //return image from a link
        private Image LoadImage(string url)
        {
            //Source : http://stackoverflow.com/questions/6152076/adding-images-that-are-located-on-a-website-to-a-listview-on-c-sharp
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        //Function call when a champion is select from the combobox
        private void ChampCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCounterInfo(ChampCombobox.Text.ToLower());
            GetCounterPic(ChampCombobox.Text.ToLower());
        }

        //Get Counter information
        private void GetCounterPic(string champName)
        {
            try
            {
                List<string> WeakChampList = new List<string>();
                List<string> StrongChampList = new List<string>();
                List<string> WellWithChamplist = new List<string>();
                List<string> pointList = new List<string>();
                champName = RemoveSpecialCharacters(champName);
                string webtext = getWebString("http://www.championcounter.com/" + champName);
                Regex r = new Regex(@"<div id=""weakAgainst"" data-name=""weakAgainst"" class=""column""><h2>Weak Against</h2>.+</small></a><br> <a href=""#""");
                champName = r.Match(webtext).Value;
                r = new Regex(@"<h4>\w+(\s|')?(\w+)?");
                MatchCollection multiMatchName = r.Matches(champName);
                r = new Regex(@"\d+ pts");
                MatchCollection multiMatchpoints = r.Matches(champName);
                foreach (Match point in multiMatchpoints)
                {
                    pointList.Add(point.Value);
                }
                int counter = 0;
                foreach (Match champ in multiMatchName)
                {
                    if (counter <= 5)
                        WeakChampList.Add(RemoveKeyWord(champ.Value));
                    else if (counter >= 6 && counter <= 11)
                        StrongChampList.Add(RemoveKeyWord(champ.Value));
                    else
                        WellWithChamplist.Add(RemoveKeyWord(champ.Value));
                    counter++;
                }
                LoadCounterImage(WeakChampList, pointList, 1);
                LoadCounterImage(StrongChampList, pointList, 2);
                LoadCounterImage(WellWithChamplist, pointList, 3);
            }
            catch (Exception error)
            {
                tlog(error.ToString());
                //MessageBox.Show(error + "");
            }
        }

        //Add image to counter image list
        private void LoadCounterImage(List<string> ChampList, List<string> pointList, int sel)
        {
            ImageList images = new ImageList();
            images.ImageSize = new Size(64, 64);
            foreach (string str in ChampList)
            {
                string GetChampName = CleanChampName(RemoveSpecialCharacters(str));

                //tlog("Getting Image at: " + "http://ddragon.leagueoflegends.com/cdn/" + gameVer + "/img/champion/" + GetChampName + ".png");
                images.Images.Add(LoadImage("http://ddragon.leagueoflegends.com/cdn/" + gameVer + "/img/champion/" + GetChampName + ".png"));
            }
            if (sel == 1)
            {
                WeaklistView.Clear();
                WeaklistView.LargeImageList = images;
                for (int x = 0; x <= 5; x++)
                {
                    WeaklistView.Items.Add(pointList[x], x);
                }
            }
            if (sel == 2)
            {
                StronglistView.Clear();
                StronglistView.LargeImageList = images;
                for (int x = 6; x <= 11; x++)
                {
                    StronglistView.Items.Add(pointList[x], x - 6);
                }
            }
            if (sel == 3)
            {
                WelllistView.Clear();
                WelllistView.LargeImageList = images;
                for (int x = 12; x <= 17; x++)
                {
                    WelllistView.Items.Add(pointList[x], x - 12);
                }
            }
        }


        //Return Correct name due to league weird html name
        public string CleanChampName(string str)
        {
             
            switch(str)
            {
                case "VelKoz":
                    return @"Velkoz";
                case "LeBlanc":
                    return "Leblanc";
                case "Fiddlesticks":
                    return "FiddleSticks";
                case "Dr":
                    return "DrMundo";
                case "KhaZix":
                    return "Khazix";
                case "ChoGath":
                    return "Chogath";
                case "Wukong":
                    return "MonkeyKing";
            }
            return str;
            
        }
        //remove any special character except for 0-9 A-z . _
        public static string RemoveSpecialCharacters(string str)
        {
            //Source:  http://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9')
                    || (str[i] >= 'A' && str[i] <= 'z'
                        || str[i] == '_'))
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }

        //Remove keyword use for Html
        private static string RemoveKeyWord(string str)
        {
            str = str.Replace("<strong>", "").Replace("</strong>", "").Replace("<h4>", "").Replace("</h4>", "");
            return str;
        }

        //Remove special header for champion info counter
        private static string RemoveHeader(string str)
        {
            Regex r = new Regex(@"(fadeIn opened"">|<li class=""fadeIn"">|</li>|<a href=""#"" class=""right-arrow"">)");
            str = r.Replace(str, "@");
            return str;
        }

        //function to set the champion info counter textbox
        private void SetCounterInfo(string champName)
        {
            CInfotextbox.Text = "";
            champName = RemoveSpecialCharacters(champName);
            try
            {
                string webtext = getWebString("http://www.championcounter.com/" + champName);
                Regex r = new Regex(@"fadeIn opened"">.+<a href=""#"" class=""right-arrow"">");
                Match onematch = r.Match(webtext);
                if (onematch.Success)
                {
                    string str = (RemoveHeader((RemoveKeyWord(onematch.Value))));
                    string[] mutlistr = str.Split('@');
                    foreach (string word in mutlistr)
                    {
                        if (word != "")
                            CInfotextbox.AppendText(word + "\n");
                        else
                            continue;
                    }
                }
                else
                    CInfotextbox.AppendText("No Counter Information at this time");
                //MessageBox.Show("Failed to get champion data");

            }
            catch (Exception error)
            {
                MessageBox.Show(error + "");
            }
        }

        private void LoadChampButton_Click(object sender, EventArgs e)
        {
            tlog("Loading Free Champion...\n");
            LoadChampButton.Enabled = false;
            if (!FreeChampBackWorker.IsBusy)
                FreeChampBackWorker.RunWorkerAsync();
            LoadChampButton.Enabled = true;
        }

        private void FreeChampBackWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadFreeChamp();
        }


    }
}