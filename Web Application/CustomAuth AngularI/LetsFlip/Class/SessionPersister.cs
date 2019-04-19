using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsFlip.Class
{
    public static class SessionPersister
    {
        static string usernameSession = "";
        public static string Username
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    return string.Empty;
                }
                var sessionVar = HttpContext.Current.Session[usernameSession];
                if (sessionVar != null)
                {
                    return sessionVar as string;
                }
                return null;
            }
            set
            {
                HttpContext.Current.Session[usernameSession] = value;
            }
        }
    }
}