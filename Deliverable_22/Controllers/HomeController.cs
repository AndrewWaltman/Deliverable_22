using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Deliverable_22.Models;

namespace Deliverable_22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegisterUser(RegisterValidation user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                ModelState.AddModelError("UserName", "Please Enter a UserName");
            }
            if (string.IsNullOrEmpty(user.EMail))
            {
                ModelState.AddModelError("Email", "Please Enter an Email Address");
            }
            if (string.IsNullOrEmpty(user.Telephone))
            {
                ModelState.AddModelError("Telephone", "Please give us a telephone number");
            }
            if (user.PhoneType == 0 || user.PhoneType > 2)
            {
                ModelState.AddModelError("PhoneType", "Please give us a telephone type");
            }
            if (!user.CheckBox)
            {
                ModelState.AddModelError("CheckBox", "You cannot be a robot and a member of the Cool People Club");
            }

            if (ModelState.IsValid)
            {
                ViewBag.UN = user.UserName;
                ViewBag.E = user.EMail;
                ViewBag.P = user.Password;
                ViewBag.PT = user.PhoneType;
                ViewBag.PN = user.Telephone;
                ViewBag.CB = user.CheckBox;
                return RResult(ViewBag.UN, ViewBag.E, ViewBag.P, ViewBag.PT, ViewBag.PN, ViewBag.CB);
            }
            else
            {
                return View();
            }
        }
        public IActionResult RResult(string userName, string eMail, string password, int phoneType, string phoneNum, bool checkBox)
        {
            ViewBag.UN = userName;
            ViewBag.E = eMail;
            ViewBag.P = password;
            ViewBag.PT = phoneType;
            ViewBag.PN = phoneNum;
            ViewBag.CB = checkBox;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
