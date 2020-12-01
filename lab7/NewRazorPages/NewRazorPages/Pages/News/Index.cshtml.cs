using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewRazorPages.Models;

namespace NewRazorPages.Pages.News
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public NewsItem obj { get; set; }

        public string Heading { get; set; }
        public void OnGet()
        {
            obj = new NewsItem { Id = 1, Title = "Best Dog in the world!", ImgURL = "Images/Guy.jpg", Content = "Uomini il liberalita eterni viviamo la quale come quali priegano Du du oft dahinten denkst der lieb oft dich nicht die deine sanftes sanft denkst du im im du laue", Discription = "Vom im schwankende sie schmerz der lied irren schauer des" };
        }
        public void OnPost()
        {
            Heading = "Hello World Razor Pages!";
        }
    }
}
