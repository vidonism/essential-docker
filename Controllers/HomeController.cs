using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using ExampleApp.Models;

namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;
        private string _message;

        public HomeController(ILogger<HomeController> logger, IRepository repo, IConfiguration config)
        {
            _logger = logger;

            _repository = repo;
            _message = config["MESSAGE"] ?? "Essential Docker!";

        }

        public IActionResult Index()
        {
            ViewBag.Message = _message;
            return View(_repository.Products);
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
