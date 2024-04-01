using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var games = new List<Game>
            {
                new Game { ID = 1, Name = "Wargame: Red dragon", Price = 499.99 },
                new Game { ID = 2, Name = "Mordhau", Price = 442.12 },
                new Game { ID = 3, Name = "Arma3", Price = 852.29 }
            };

            return View(games);
        }

        public IActionResult Weather(string region)
        {
            return ViewComponent("Weather", region);
        }
    }
}