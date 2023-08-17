using EMS_MVC_Project.CustomeFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Security.Principal;
using System.Web.Security;

namespace EMS_MVC_Project
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        
        {

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalFilters.Filters.Add(new ErrorHandler() { View = "GenericErrorPage" });
        }

        protected void Application_AuthenticateRequest()
        {
            //var identity = new GenericIdentity("Kundan");
            //HttpContext.Current.User = new GenericPrincipal(identity, null);

            HttpCookie cookie = Request.Cookies["AppAuth"];
            if (cookie != null)
            {
                string EncryptedTicket = cookie.Value;
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(EncryptedTicket);
                if (!ticket.Expired)
                {
                    string username = ticket.Name;
                    string email = ticket.UserData;

                    var identity = new GenericIdentity(username);
                    HttpContext.Current.User = new GenericPrincipal(identity, null);
                }
            }
        }


        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();
            Server.ClearError();
            //code
            //Server.TransferRequest("GenericErrorPage");
        }


    }
}
