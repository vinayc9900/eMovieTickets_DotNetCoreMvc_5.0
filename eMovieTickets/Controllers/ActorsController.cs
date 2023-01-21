using eMovieTickets.Data;
using eMovieTickets.Data.Services;
using eMovieTickets.Models;
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
			var allActors = await _services.GetActorsAsync();
			return View(allActors);
		}
		//Get : Actors/create
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			await _services.AddActorAsync(actor);
			return RedirectToAction(nameof(Index));
			
		}
		//Get:Actors/Details/1
		public async Task<IActionResult> Details(int id)
		{
			var actorDetails =await _services.GetActorByIdAsync(id);
			if(actorDetails==null)
			{
				return View("NotFound");
			}
			return View(actorDetails);
		}
		//Get : Actors/Edit/1
		public async Task<IActionResult> Edit(int id)
		{
			var actorDetails = await _services.GetActorByIdAsync(id);
			if (actorDetails == null)
			{
				return View("NotFound");
			}
			return View(actorDetails);
		}
		[HttpPost]
		public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Bio")] Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			await _services.UpdateActorAsync(id, actor);
			return RedirectToAction(nameof(Index));

		}
		//Get : Actors/Delete/1
		public async Task<IActionResult> Delete(int id)
		{
			var actorDetails = await _services.GetActorByIdAsync(id);
			if (actorDetails == null)
			{
				return View("NotFound");
			}
			return View(actorDetails);
		}
		[HttpPost,ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var actorDetails = await _services.GetActorByIdAsync(id);
			if (actorDetails == null)
			{
				return View("NotFound");
			}
			await _services.DeleteActorAsync(id);
			return RedirectToAction(nameof(Index));

		}

	}
}
