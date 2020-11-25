using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCraftsWebsite.Models;
using ContosoCraftsWebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCraftsWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductServices productService)
        {
            this.ProductServices = productService;
        }
        public JsonFileProductServices ProductServices { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductServices.GetProducts();
         }
        //[HttpPatch] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId,
            [FromQuery] int Rating)
        {
            ProductServices.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
