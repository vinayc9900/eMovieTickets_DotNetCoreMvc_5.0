using eMovieTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eMovieTickets.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> GetActorsAsync();
        Task<Actor> GetActorByIdAsync(int id);
        Task AddActorAsync(Actor actor);
        Task<Actor> UpdateActorAsync(int id, Actor newActor);
        Task DeleteActorAsync(int id);

	}
}
