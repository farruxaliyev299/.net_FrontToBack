using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebUI.DAL;
using WebUI.Models;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Summary = _context.Summary.FirstOrDefault(),
                Sliders = _context.Sliders.ToList()
            };

            return View(homeVM);
        }
    }
}

