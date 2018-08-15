using Spaceship.Entities;
using System.Threading.Tasks;

namespace Spaceship.Services
{
    public interface ICrewService
    {
        Task<Crew> GetById(int id);
    }
}
