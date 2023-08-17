using EMS_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EMS_MVC_Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account UserModel
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel userModel)
        {
            bool IsAuthenticated = false;
            if (userModel.UserName == "Shweta1234" && userModel.Password == "Shweta@1234")
            {
                IsAuthenticated = true;
            }
            if (userModel.UserName == "Sneha1234" && userModel.Password == "Sneha@1234")
            {
                IsAuthenticated = true;
            }

            if (IsAuthenticated)
            {
                //FormsAuthentication.RedirectFromLoginPage(userModel.UserName, false);

                //step 1
                FormsAuthenticationTicket ticket =
                    new FormsAuthenticationTicket(1, userModel.UserName, DateTime.Now, DateTime.Now.AddHours(5), false, "test@gmail.com");
                //step 2
                string EncryptedTicket = FormsAuthentication.Encrypt(ticket);
                //step 3
                HttpCookie httpCookie = new HttpCookie("AppAuth", EncryptedTicket);
                //httpCookie.Expires = DateTime.Now.AddHours(5);
                //step 4
                Response.Cookies.Add(httpCookie);

                return RedirectToAction("Index", "Category");
            }
            ViewBag.ErrorMessage = "Invalid UserId or Password!";
            return View();
        }
    }
}