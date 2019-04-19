using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace RunescapeGEPrice
{
    public class CookieAwareWebClient : WebClient
    {
        public void Login(string loginPageAddress, NameValueCollection loginData)
        {
            CookieContainer container;

            var request = (HttpWebRequest)WebRequest.Create(loginPageAddress);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            var buffer = Encoding.ASCII.GetBytes(loginData.ToString());

            request.ContentLength = buffer.Length;
            var requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();

            container = request.CookieContainer = new CookieContainer();

            var response = request.GetResponse();

            var stmr = new StreamReader(response.GetResponseStream());
            var json = stmr.ReadToEnd();
            readtofile(json);
            //if (json.Contains("loginphrase"))
            //{
            //    MessageBox.Show("Invalid Username or Password", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //}
            response.Close();
            CookieContainer = container;

        }
        public void readtofile(string x)
        {

            System.IO.StreamWriter file = new System.IO.StreamWriter("login.html");
            file.Write(x);
            file.Close();
        }
        public CookieAwareWebClient(CookieContainer container)
        {
            CookieContainer = container;
        }

        public CookieAwareWebClient()
            : this(new CookieContainer())
        { }

        public CookieContainer CookieContainer { get; private set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = (HttpWebRequest)base.GetWebRequest(address);
            request.CookieContainer = CookieContainer;
            return request;
        }
    }
}
