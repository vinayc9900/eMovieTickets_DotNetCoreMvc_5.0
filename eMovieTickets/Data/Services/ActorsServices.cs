using eMovieTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace eMovieTickets.Data.Services
{
    public class ActorsServices : IActorsServices
    {
        private readonly AppDbContext _context;

        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddActorAsync(Actor actor)
        {
          await _context.Actors.AddAsync(actor);
          await  _context.SaveChangesAsync();
        }

        public async Task  DeleteActorAsync(int id)
        {
            var deleteActor =await  _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            
            _context.Actors.Remove(deleteActor);
            await _context.SaveChangesAsync();

        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
           
                var actorDetails = await _context.Actors.FirstOrDefaultAsync(x=>x.Id==id);
                return actorDetails;

        }

        public async Task<IEnumerable<Actor>> GetActorsAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> UpdateActorAsync(int id, Actor newActor)
        {
            _context.Actors.Update(newActor);
           await  _context.SaveChangesAsync();
            return newActor;
        }

       
    }
}
