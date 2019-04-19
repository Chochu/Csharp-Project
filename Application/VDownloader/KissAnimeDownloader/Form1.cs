using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
namespace AnimeDownloader
{
    public partial class Form1 : Form
    {
        //Global variable
        static Regex mp4Link = new Regex(@"<iframe src=(.)+auengine(.)+frameborder"); //The pattern to get the title
        static Regex titlePattern = new Regex(@"<title>.+<\/title>"); //The pattern to get the title
        static Regex realMP4Link = new Regex(@"var video_link = '(.)+.mp4';");
        public bool isLoadingWeb = false;
        public string videoTitle, videoID, downloadLink;
        public string URLS = "";
        public string saveLoc = "";
        public int currentEp = 0;
        public int lastEp = 0;
        public int numEpComplete = 0;
        public int numEpDownloading = 0;
        
        public Form1()
        {
            InitializeComponent();
            urlTextbox.Text = "http://watchanime.com/episode/detective-conan-episode-";
            firsteptexBox.Text = "10";
            lasteptexBox.Text = "50";
            SaveLocationtexBox.Text = "";
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
        }

        private void StartButton_Click(object sender, EventArgs e) //Start the program
        {
            URLS = urlTextbox.Text;
            currentEp = Int32.Parse(firsteptexBox.Text);
            lastEp = Int32.Parse(lasteptexBox.Text);
            saveLoc = SaveLocationtexBox.Text;
            StartButton.Enabled = false;
            if (!backgroundWorker1.IsBusy)
            {
                Console.WriteLine("Running");
                backgroundWorker1.RunWorkerAsync();
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.logTextbox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.logTextbox.AppendText(text + "\n");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            while (currentEp <= lastEp) //loop while it is not up to the desire ep
            {
                if (isLoadingWeb == false) //if it is not downloading and the webbrowser is not loading
                {
                    SetText("Navigating to : " + URLS + " " + currentEp); //print text
                    isLoadingWeb = true; //set isloading to true
                    //gethomePage();            
                    webBrowser1.Navigate(URLS + currentEp); //navigate to website         
                }
            }
            //FireDownloadQueue(listUri, "E:\\Users\\Jun\\Desktop\\Download");
        }
        bool needtologin = true;
        private async void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            while (webBrowser1.Url.ToString() != URLS + currentEp + "/") //if the link is not at the website, wait
            {
                await Task.Delay(1000);
            }
            
            while(webBrowser1.DocumentText.Contains("Login to watch this video!")){//User is not login
                if (needtologin)
                {
                    MessageBox.Show("Please Login in and check Remember me and Restart the program");
                    needtologin = false;
                }
                await Task.Delay(1000);
            }

            Console.WriteLine("Navigate Complete"); //Notice user the navigate is complete
            SetText("Getting link for the video page of ep: " + currentEp); 
            string sourceCode = webBrowser1.DocumentText;

            Match matchTitle = titlePattern.Match(sourceCode); //get the title of the video
            if (matchTitle.Success)
            {
                videoTitle = matchTitle.Value.Replace("<title>", "").Replace("</title>", "").Replace("- Masterani", "");
            } 

            //Get the link for the second Web browser
            Match matchMp4Link = mp4Link.Match(sourceCode); //get the first link of the full size video page
            if (matchMp4Link.Success)
            {
                videoID = matchMp4Link.Value.Replace("<iframe src=\"", "").Replace("\" frameborder", "");
            }

            //labelEpTitle.Text = "Episode Title: " + videoTitle; //set the label to video title
            if (videoID == "")
            {
                MessageBox.Show("Video link not found");
            }
            webBrowser1.Stop();
            while (videoID == null) //if the link is not at the website, wait
            {
                await Task.Delay(1000);
            }
            getDownloadLink(videoID);
        }

        //private void gethomePage()
        //{

        //    string urlAddress = URLS + currentEp;

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        Stream receiveStream = response.GetResponseStream();
        //        StreamReader readStream = null;

        //        if (response.CharacterSet == null)
        //        {
        //            readStream = new StreamReader(receiveStream);
        //        }
        //        else
        //        {
        //            readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
        //        }

        //        string sourceCode = readStream.ReadToEnd();
        //        SetText(sourceCode);
        //        Match matchTitle = titlePattern.Match(sourceCode);
        //        if (matchTitle.Success)
        //        {
        //            videoTitle = matchTitle.Value.Replace("<title>", "").Replace("</title>", "").Replace("- Masterani", "");
        //        }

        //        //Get the link for the second Web browser
        //        Match matchMp4Link = mp4Link.Match(sourceCode);
        //        if (matchMp4Link.Success)
        //        {
        //            videoID = matchMp4Link.Value.Replace("<iframe src=\"", "").Replace("\" frameborder", "");
        //        }

        //        //labelEpTitle.Text = "Episode Title: " + videoTitle;
        //        MessageBox.Show(videoTitle);
        //        getDownloadLink(videoID);

        //        response.Close();
        //        readStream.Close();
        //    }
        //}

        private async void getDownloadLink(string videoID)
        {
            SetText("Getting Download link for mp4 file for ep" + currentEp);
            string urlAddress = videoID;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                Match getDLLink = realMP4Link.Match(data);
                if (getDLLink.Success)
                {
                    downloadLink = getDLLink.Value.Replace("var video_link = '", "").Replace("';", "");
                }

                SetText(downloadLink);

                response.Close();
                readStream.Close();

                //listUri.Add(new Uri(downloadLink));

                currentEp++;

                isLoadingWeb = false;


                await Task.Run(() => startDownload(new Uri(downloadLink), saveLoc));

                
                videoTitle = videoID = downloadLink = "";
            }
        }

        //List<Uri> listUri = new List<Uri>();
        //private async void FireDownloadQueue(List<Uri> toDownload, string saveLocation)
        //{
        //    foreach (Uri url in toDownload)
        //    {
        //        await Task.Run(() => startDownload(url, saveLocation));
        //    }
        //}

        private bool downloadComplete = false;
        private void startDownload(Uri toDownload, string saveLocation)
        {
            numEpDownloading++;
            //string outputFile = Path.Combine(saveLocation, Path.GetFileName(new Uri(saveLocation).AbsolutePath));

            string epNum = (currentEp - 1).ToString() ;
            string outputFile = Path.Combine(saveLocation, Path.GetFileName(new Uri(saveLocation + epNum + ".mp4").AbsolutePath));

            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(toDownload, outputFile);
            
            while (!downloadComplete)
            {
                Application.DoEvents();
            }

            downloadComplete = false;
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                //SetText("OK");
                //downloadComplete = true;

                SetText("Download Completed for Episode: " + numEpComplete);
                numEpComplete++;
                downloadComplete = true;
                isLoadingWeb = false;
                if (numEpComplete == numEpDownloading)
                {
                    StartButton.Enabled = true;
                    MessageBox.Show("Download Completed: " + numEpComplete);
                }
            });
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                labelPercentage.Text = "Downloading " + Convert.ToInt32(percentage) + "%  -  " + Convert.ToInt32(bytesIn / 1024) + " / " + Convert.ToInt32(totalBytes / 1024) + " kB";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

    }
}


