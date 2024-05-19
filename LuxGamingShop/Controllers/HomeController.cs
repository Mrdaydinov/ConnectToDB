using LuxGamingShop.Models;
using LuxGamingShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace LuxGamingShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var features = _context.Features.ToList();
            var gaming = _context.Gamings.ToList();
            var trendingGames = _context.HomePageTrendingGames.ToList();
            var intro = _context.HomePageIntros.ToList();


            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Features = features;
            homeIndexVM.Gamings = gaming;
            homeIndexVM.TrendingGames = trendingGames;
            homeIndexVM.Intro = intro;


            return View(homeIndexVM);
        }
    }
}
