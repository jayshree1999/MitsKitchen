using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MitsKitchen.Data;
using System.Linq;

namespace MitsKitchen.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        public IActionResult Index()
        {
            return View(_context.Product.Include(p => p.CategoryName).ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
