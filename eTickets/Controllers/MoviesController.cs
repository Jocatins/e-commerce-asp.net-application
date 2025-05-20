using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {       
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync();
            return View(allMovies);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
