using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    public class Blog : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Models.Post
                {
                    Image = "blog-04.jpg" ,
                    Title = "Black Friday Guide: Best Sales & Discount Codes" ,
                    Author = "By Admin" ,
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius"
                } ,
                new Models.Post
                {
                    Image = "blog-05.jpg" ,
                    Title = "The White Sneakers Nearly Every Fashion Girls Own" ,
                    Author = "By Admin" ,
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius"
                } ,
                new Models.Post
                {
                    Image = "blog-08.jpg" ,
                    Title = "Black Friday Guide: Best Sales & Discount Codes" ,
                    Author = "By Admin" ,
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius"
                } ,
                new Models.Post
                {
                    Image = "blog-02.jpg" ,
                    Title = "Black Friday Guide: Best Sales & Discount Codes" ,
                    Author = "By Admin" ,
                    Description = " Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius"
                } ,
                new Models.Post
                {
                    Image = "blog-03.jpg",
                    Title = "Black Friday Guide: Best Sales & Discount Codes" ,
                    Author = "By Admin" ,
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius"
                } 
            };

            return View(posts);
        }
    }
}
