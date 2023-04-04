
using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderInfo sliderInfo = _context.SliderInfos.FirstOrDefault();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo


            };

            return View(model);
        }

  
    }
}