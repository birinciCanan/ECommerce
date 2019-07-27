using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            using (ECommerceContext eCommerceContext = new ECommerceContext()) // scope kapandığında içindekı herşey ulaşıma kaaplı
            {
                List<User> users = eCommerceContext.Users.Include(a=>a.Address).ToList();
                List<Address> addresses = eCommerceContext.Addresses.Include(a => a.User).ToList();
            }

     
            return View();
        }
    }
}
