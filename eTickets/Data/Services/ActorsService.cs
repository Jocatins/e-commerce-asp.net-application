using System.Diagnostics;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ActorsService> _logger;

        public ActorsService(AppDbContext context, ILogger<ActorsService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            Debug.WriteLine("Saving to DB...");
            await _context.SaveChangesAsync();
            Debug.WriteLine("Saved!");
            Debug.WriteLine($"Actor added with ID: {actor.Id}");
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var data = await _context.Actors.ToListAsync();
            return data;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
