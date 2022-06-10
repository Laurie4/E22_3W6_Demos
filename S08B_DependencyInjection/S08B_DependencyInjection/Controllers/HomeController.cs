using Microsoft.AspNetCore.Mvc;
using S08B_DependencyInjection_Models;
using S08B_DependencyInjection_Services.Interfaces;
using System.Diagnostics;

namespace S08B_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageWriter _msgWriter;
        public HomeController(IMessageWriter msgWriter)
        {
            _msgWriter = msgWriter;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManageNumber(int number)
        {
            _msgWriter.Write("Le nombre est: " + number);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
