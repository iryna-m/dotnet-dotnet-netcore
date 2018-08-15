using Spaceship.DataAccess;
using Spaceship.Entities;
using System;
using System.Threading.Tasks;

namespace Spaceship.Services
{
    public class CrewService : ICrewService
    {
        private ICrewRepository _crewRepository;

        public CrewService(ICrewRepository crewRepository)
        {
            _crewRepository = crewRepository;
        }

        public Task<Crew> GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id must be more than 0");
            }

            return _crewRepository.GetById(id);
        }
    }
}