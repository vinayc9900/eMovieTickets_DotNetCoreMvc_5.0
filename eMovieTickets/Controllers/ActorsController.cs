using eMovieTickets.Data;
using eMovieTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _services;

        public ActorsController(IActorsServices services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _services.GetActors();
            return View(allActors);
        }
        //Get : Actors/create
        public IActionResult Create()
        {
            return View();
        }
    }
}
