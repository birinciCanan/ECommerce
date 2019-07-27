using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        [Route("/kategori/{id}")]
        public IActionResult Index( int id)
        {
            Category category = new Category();
            using (ECommerceContext eCommerceContext = new ECommerceContext()) 
            {
                category = eCommerceContext.Categories.SingleOrDefault(a=>a.Id==id);

            }
            ViewData["Title"] = category.Name;

            return View(category);
        }
    }
}