using Microsoft.AspNetCore.Mvc;
using PretzelFrontToBack.DAL;
using PretzelFrontToBack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PretzelFrontToBack.Controllers
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
            HomeVM homeVM = new HomeVM();
            homeVM.sliders = _context.sliders.ToList();
            return View(homeVM);
        }
    }
}
