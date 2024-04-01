using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Components
{
    public class GamesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Game> games)
        {
            return View(games);
        }
    }
}