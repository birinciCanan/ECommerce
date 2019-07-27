
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        [Route("/api")]
        public IActionResult Handle()
        {
            string json = HttpContext.Request.Form["JSON"].ToString();
            DTO.ProductSaveDto productSave = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.ProductSaveDto>(json);

            using (ECommerceContext eCommerceContext = new ECommerceContext)
            {
                eCommerceContext.Products.Add(new Models.Product()
                {
                    Name = productSave.productName,
                    Description = "boş",
                    State = eCommerceContext.States.Single(x => x.Id == (int)Enums.State.Active),
                    //Category = eCommerceContext.Categories.Single(x => x.Id=ıd),
                    CreateDate = DateTime.UtcNow

                });
            }

            return View();

        }
    }
}