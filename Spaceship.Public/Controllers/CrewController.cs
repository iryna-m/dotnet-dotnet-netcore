using Microsoft.AspNetCore.Mvc;
using Spaceship.Entities;
using Spaceship.Services;
using System.Threading.Tasks;

namespace Spaceship.Controllers
{
    public class CrewController : Controller
    {
        private ICrewService _crewService;

        public CrewController(ICrewService crewService)
        {
            _crewService = crewService;
        }
       
        [Route("/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Crew crew = await _crewService.GetById(id);

            ViewData["Message"] = $"Crew Id={crew.Id}, Name={crew.Name}";

            return View();
        }
    }
}
