using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class CinemasService: ICinemasService
    {
        private readonly AppDbContext _context;

        public CinemasService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Cinema actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetAll()
        {
            var data = await _context.Cinemas.ToListAsync();
            return data;
        }

        public Cinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cinema Update(int id, Cinema actor)
        {
            throw new NotImplementedException();
        }
    }
}
