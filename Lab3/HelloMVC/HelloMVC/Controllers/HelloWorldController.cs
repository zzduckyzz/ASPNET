using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name + ";)";
            ViewBag.NumTimes = numTimes;
            return View();
        }

        // GET: HelloWorld/welcome
        //public string Index()
        //{
        //    return "<h1> Hello world index  </h1>";
        //}

        //public string welcome()
        //{
        //    return "Welcome to MVC worlds";
        //}

        // GET: HelloWorld/SayHi?name = thidk&numTimes=19
        public string SayHi(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes =" + numTimes);
        }

        // GET: HelloWorld/Hello/thidk/19
        public string Hello(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes =" + numTimes);
        }
    }
}