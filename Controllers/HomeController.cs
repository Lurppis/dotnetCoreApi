using System.Linq;
using dotnet_core_web_app.Models;
using dotnet_core_web_app.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_web_app.Controllers {
    public class HomeController : Controller {
        private readonly IPierepository _pieRepository;

        public HomeController (IPierepository iPierepository) {
            _pieRepository = iPierepository;
        }
        // GET: / <controller> /
        public IActionResult Index () {
            var homeViewModel = new HomeViewModel () {
                Title = "Pies overview",
                Pies = _pieRepository.GetAllPies ().OrderBy (p => p.Name).ToList ()
            };

            return View (homeViewModel);
        }
    }
}