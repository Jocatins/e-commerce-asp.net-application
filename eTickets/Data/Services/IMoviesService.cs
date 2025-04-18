using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAll();

        Movie GetById(int id);

        void Add(Movie actor);

        Movie Update(int id, Movie actor);

        void Delete(int id);
    }
}
