using Microsoft.AspNetCore.Mvc;
using NhaLesson08Models.Models;
using System.Diagnostics;
using NhaLesson08Models.Models;

namespace NhaLesson08Models.Controllers
{
    public class NhaHomeController : Controller
    {
        private readonly ILogger<NhaHomeController> _logger;

        public NhaHomeController(ILogger<NhaHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NhaIndex()
        {
            return View();
        }

        public IActionResult NhaPrivacy()
        {
            return View();
        }

        public IActionResult NhaAbout()
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