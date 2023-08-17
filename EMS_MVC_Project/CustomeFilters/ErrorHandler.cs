using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace EMS_MVC_Project.CustomeFilters
{
    public class ErrorHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            LogError(exception);
            base.OnException(filterContext);
        }

        private void LogError(Exception exception)
        {
            HttpApplication application = new HttpApplication();
            string FolderPath = @"C:\Users\Admin\source\repos\EMS_MVC_Project\EMS_MVC_Project\AppFiles";
            string fileName = DateTime.Now.ToString("ddMMyyyy")+"_log.txt";
            string _Path = Path.Combine(FolderPath, fileName);
            StreamWriter writer = new StreamWriter(_Path, true);
            writer.WriteLine("Error Time : {0}", DateTime.Now.ToShortTimeString());
            writer.WriteLine("Exception Type : {0}", exception.GetType());
            writer.WriteLine("Exception Message : {0}", exception.Message);
            writer.WriteLine("Exception Stack : {0}", exception.StackTrace);
            writer.WriteLine("================================================");
            writer.Close();
        }
    }
}