using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace RunescapeGEPrice
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            //Set Username and Password
            string strId = UserNameTB.Text;
            string strName = PasswordTB.Text;
            //Instance of ASCII
            var encoding = new ASCIIEncoding();
            //Data to be send
            var postData = "login=" + strId + "&register=0&password=" + strName + "&remember=1&cookie_check=0&redirect=forum%2F&_xfToken=";
            //convert to byte
            byte[] data = encoding.GetBytes(postData);
            //Request Connection
            var myRequest = (HttpWebRequest)WebRequest.Create("http://lets-flip.com/login/login");
            myRequest.KeepAlive = true;
            myRequest.AllowAutoRedirect = true;
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = data.Length;
            progressBar1.Value = 20;
            //Send Data
            using (var newStream = myRequest.GetRequestStream())
            {
                newStream.Write(data, 0, data.Length); ;
            }

            //Response
            HttpWebResponse response;
            try
            {
                response = myRequest.GetResponse() as HttpWebResponse;
            }
            catch (WebException ex)
            {
                response = ex.Response as HttpWebResponse;
            }
            progressBar1.Value = 30;
            //Check the type of response
            var responseStream = response.GetResponseStream();
            var responseReader = new StreamReader(responseStream);
            var json = responseReader.ReadToEnd();
            
            //if response is 404, user is founds -> Open Web Browser and Login
            if(json.Contains("The requested page could not be found.")){
                webLogin();
            }
            //User is not found
            else if(json.Contains("The requested user")){
                MessageBox.Show("The requested user '" +strId+ "' could not be found.");
                progressBar1.Value = 0;
            }
            //Incorrect Password
            else{
                MessageBox.Show("Incorrect password. Please try again.");
                progressBar1.Value = 0;
            }

        }

        private void webLogin()
        {
            progressBar1.Value = 40;
            webBrowser1.Navigate("http://lets-flip.com/login");
        }
        string _userLink = "";
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (webBrowser1.Url.AbsoluteUri == "http://lets-flip.com/login")
            {
                progressBar1.Value = 50;
                webBrowser1.Document.GetElementById("ctrl_pageLogin_login").SetAttribute("value", UserNameTB.Text);
                webBrowser1.Document.GetElementById("ctrl_pageLogin_password").SetAttribute("value", PasswordTB.Text);
                
                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("value").Equals("Log in"))
                    {
                        el.InvokeMember("Click");
                    }
                }
            }
            
            if (webBrowser1.Url.AbsoluteUri == "http://lets-flip.com/")
            {
                progressBar1.Value = 60;
                string textBegin = "<a href=\"members/";
                int pFrom = webBrowser1.DocumentText.IndexOf(textBegin) + textBegin.Length;
                int pTo = webBrowser1.DocumentText.IndexOf("/\" class=\"username\"")+1;
                _userLink = webBrowser1.DocumentText.Substring(pFrom,pTo - pFrom);
                
                webBrowser1.Navigate("http://lets-flip.com/members/" + _userLink);
            }

            if (webBrowser1.Url.AbsoluteUri == "http://lets-flip.com/members/" + _userLink)
            {
                progressBar1.Value = 70;
                if (webBrowser1.DocumentText.Contains("supportPIP")){
                    progressBar1.Value = 80;
                    LuanchProgram();
                }
                else
                {
                    MessageBox.Show("Sorry, Only Available to Support Rank");
                    progressBar1.Value = 0;
                }
            }
        }

        void LuanchProgram()
        {
            MainForm _Mainform = new MainForm();
            _Mainform.Show();
            this.Visible = false;
            if (_Mainform == null)
            {
                Application.Exit();
            }
        }

    }
}
//var client = new CookieAwareWebClient();
//client.readtofile();