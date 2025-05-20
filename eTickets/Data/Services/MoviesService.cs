using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;

        public MoviesService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Movie actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {

            var data = await
                _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return data;
        }

        public async Task<Movie> GetByIdAsync(int id)
        {

            var movie = await _context.Movies.Include(m => m.Cinema)
                    .FirstOrDefaultAsync(m => m.Id == id);
            return movie;
        }

        public Movie Update(int id, Movie actor)
        {
            throw new NotImplementedException();
        }
    }
}