using DeviceLog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DeviceLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Teams = Directory.GetDirectories("./Data/");
            for (var i = 0; i < Teams.Count(); i++)
            {
                Teams[i] = Teams[i].Replace("./Data/", "");
            }
            return View(Teams);
        }
    }
}
