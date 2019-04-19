using LetsFlip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LetsFlip.Filter
{
    public class CustomPrincipal : IPrincipal
    {
        private UserData CUserData;

        public CustomPrincipal(UserData cuserdata)
        {
            this.CUserData = cuserdata;
            this.Identity = new GenericIdentity(cuserdata.Username);
        }
        public IIdentity Identity
        {
            get;
            set;
        }
        /// <summary>
        /// Return if the User role contain any of the allow role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.CUserData.role.Contains(r));
        }
    }
}