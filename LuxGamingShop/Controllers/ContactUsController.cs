using LuxGamingShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly DataContext _context;

        public ContactUsController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contactUs = _context.ContactUs.ToList();

            return View(contactUs);
        }
    }
}
