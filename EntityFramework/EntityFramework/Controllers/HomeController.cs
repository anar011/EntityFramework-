
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

  
    }
}