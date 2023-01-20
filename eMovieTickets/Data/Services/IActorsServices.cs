using eMovieTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eMovieTickets.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> GetActors();
        Actor GetActorById(int id);
        void AddActor(Actor actor);
        Actor UpdateActor(int id, Actor newActor);
        void DeleteActor(int  id);
    }
}
