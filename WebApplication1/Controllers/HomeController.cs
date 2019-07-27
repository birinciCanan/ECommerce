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
            ViewData["Title"] = "Anasayfaya Hoşgeldiniz ";
            return View();
        }
        public IActionResult Help()
        {
            ViewData["Title"] = "Yardım Masasına Hoşgeldiniz";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Title"] = "İletişim sayfasına Hoşgeldiniz";
            return View();
        }
    }
}
