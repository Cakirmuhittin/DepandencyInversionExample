using Business;
using Microsoft.AspNetCore.Mvc;
using Standarts;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHavaServis _havaServis;

        public HomeController(ILogger<HomeController> logger,IHavaServis havaServis)
        {
            _logger = logger;
            _havaServis = havaServis;
        }

        public IActionResult Index(HomeViewModel model)
        {
            if(model.Yer !=null)
            {
              model.Sicaklik=_havaServis.SicaklikGetir(model.Yer);
            }
            return View(model);
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