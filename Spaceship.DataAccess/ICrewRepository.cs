using Spaceship.Entities;
using System.Threading.Tasks;

namespace Spaceship.DataAccess
{
    public interface ICrewRepository
    {
        Task<Crew> GetById(int id);
    }
}
