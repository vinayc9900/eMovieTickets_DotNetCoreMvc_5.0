using eMovieTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        public void AddActor(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteActor(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor GetActorById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Actor UpdateActor(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }

       
    }
}
