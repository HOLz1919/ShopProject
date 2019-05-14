using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopProject.Models;
using ShopProject.BL;
using ShopProject.ViewModel;
using System.Web.Security;

namespace ShopProject.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(User user, string ReturnUrl)
        {

            UserBL userBL = new UserBL();
            if (userBL.IsValidUser(user.Username, user.Password))
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                if (ReturnUrl == null)
                {
                    return RedirectToAction("BeltList", "Home");
                }
                return Redirect(ReturnUrl);
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Niepoprawne hasło lub nazwa uzytkownika");
                return View("Login");


            }
        }

        [HttpGet]
        public ActionResult Registration()
        {
            RegistrationVM registrationVM = new RegistrationVM();

            return View(registrationVM);
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Registration", user);
            }
            else
            { 
            UserBL userBL = new UserBL();
            userBL.CreateUser(user);
            return RedirectToAction("List", "User");
            }
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}