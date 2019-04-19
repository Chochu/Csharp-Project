using LetsFlip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsFlip.Repo
{
    public interface IUserRepository: IDisposable
    {
        //Return the 120 list of RSItem based on the user id
        List<RSItem> getitem(int Userid);

        //Give user a new list
        void getNewList(int Userid);        
    }
}