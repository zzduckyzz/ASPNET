using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWS8.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWS8.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        //Post: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name, EmailId")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(customerModel);
        }
    }
}
