using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface ICinemasService
    {
        Task<IEnumerable<Cinema>> GetAll();

        Cinema GetById(int id);

        void Add(Cinema actor);

        Cinema Update(int id, Cinema actor);

        void Delete(int id);
    }
}
