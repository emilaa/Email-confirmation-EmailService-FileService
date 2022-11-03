using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Partial_views__Load_more.Data;
using Partial_views__Load_more.Models;
using Partial_views__Load_more.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_views__Load_more.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        public BasketController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<BasketVM> basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            List<BasketDetailVM> basketDetail = new List<BasketDetailVM>();

            foreach (var item in basketItems)
            {
                Product product = await _context.Products.Where(m=>m.Id==item.Id && !m.IsDeleted).FirstOrDefaultAsync();

                BasketDetailVM newBasket = new BasketDetailVM
                {
                    Title = product.Title,
                    Image = product.Image,
                    Price = product.Price,
                    Count = item.Count,
                    Total = product.Price * item.Count
                };

                basketDetail.Add(newBasket);
            }

            return View(basketDetail);
        }
    }
}
