using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsFlip.Filter
{
    public class ActionFilterA : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string mess = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " -> " 
                + filterContext.ActionDescriptor.ActionName + " on Action Executed.\n";
            LogActionFilter(mess);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string mess = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " -> "
                + filterContext.ActionDescriptor.ActionName + " on Action Executing.\n";
            LogActionFilter(mess);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string mess = filterContext.RouteData.Values["controller"].ToString() + " -> "
                + filterContext.RouteData.Values["action"].ToString() + " on Result Executed.\n";
            LogActionFilter(mess);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string mess = filterContext.RouteData.Values["controller"].ToString() + " -> "
                + filterContext.RouteData.Values["action"].ToString() + " on Result Executing.\n";
            LogActionFilter(mess);
        }
        private void LogActionFilter(string text)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Log.txt"), text);
        }
        public void OnException(ExceptionContext filterContext)
        {
            LogActionFilter(filterContext.Exception.ToString() + "\n");
        }
    }
}