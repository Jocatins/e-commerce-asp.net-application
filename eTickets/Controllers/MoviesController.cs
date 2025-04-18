using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {       
            _moviesService = moviesService;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _moviesService.GetAll();
            return View(allMovies);
        }
    }
}
