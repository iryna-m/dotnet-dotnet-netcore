using Spaceship.Entities;
using System;
using System.Threading.Tasks;

namespace Spaceship.DataAccess
{
    public class CrewRepository : ICrewRepository
    {
        public Task<Crew> GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id must be more than 0");
            }

            return Task.FromResult(new Crew
            {
                Id = id,
                Name = "Main"
            });
        }
    }
}