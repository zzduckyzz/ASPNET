using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginMVC.Models;

namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            User user1 = new User { Username = "test", Password = "123456" };
            return View(user1);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            ViewBag.Username = "";
            ViewBag.Password = "";
            return View(user);
        } 
    }
}
