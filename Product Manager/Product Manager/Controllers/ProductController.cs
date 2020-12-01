using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product_Manager.Models;
using Product_Manager.Services;

namespace Product_Manager.Controllers
{
    public class ProductController : Controller
    {
       public ProductController(JsonFileProductListService productListService)
        {
            ProductListService = productListService;
        }

        public JsonFileProductListService ProductListService  { get; }

        public ActionResult Index()
        {
            return View(ProductListService.GetProducts());
        }
    }
}
