using LetsFlip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsFlip.Repo
{
    public interface ILoginRepository : IDisposable
    {
        //Authenicate Username and password
        bool AuthenicateLogin(string LoginName, string LoginPass);
        UserData getUserObj(string LoginName);
    }
}