using LetsFlip.Class;
using LetsFlip.Library;
using LetsFlip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LetsFlip.Filter
{
    public class CustomAuthorizeAttribute: AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //if user is not login
            if (string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Login" }));
            }
            else
            {
                CustomPrincipal mp = new CustomPrincipal(new LoginRepository(new OSRSDatabaseEntities()).getUserObj(SessionPersister.Username));
                //if user does not have access
                if (!mp.IsInRole(Roles))
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Login" }));
                }
            }
        }
    }
}