using Microsoft.AspNetCore.Mvc;
using Spaceship.Entities;
using Spaceship.Services;
using System.Threading.Tasks;

namespace Spaceship.Admin.Controllers
{
    [Route("api")]
    public class CrewController : Controller
    {
        private ICrewService _crewService;

        public CrewController(ICrewService crewService)
        {
            _crewService = crewService;
        }

        // GET api/5
        [HttpGet("{id}")]
        public async Task<Crew> Get(int id) => await _crewService.GetById(id);
    }
}
