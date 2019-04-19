using LetsFlip.Models;
using LetsFlip.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsFlip.Library
{
    public class LoginRepository : ILoginRepository, IDisposable
    {
        OSRSDatabaseEntities db;
        public LoginRepository(OSRSDatabaseEntities context)
        {
            this.db = context;
        }
        public bool AuthenicateLogin(string LoginName, string LoginPass)
        {
            var user = db.Logins.Where(a => a.Username == LoginName && a.Password == LoginPass).FirstOrDefault();
            if(user != null)
            {
                return true;
            }
            return false;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public UserData getUserObj(string LoginName)
        {
            var loginobj = db.Logins.Where(a => a.Username == LoginName).FirstOrDefault();
            return loginobj.UserData;
        }
    }
}