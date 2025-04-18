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

        public async Task<IEnumerable<Movie>> GetAll()
        {

            var data = await 
                _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return data;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie Update(int id, Movie actor)
        {
            throw new NotImplementedException();
        }
    }
}
