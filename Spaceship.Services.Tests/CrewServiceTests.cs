using Spaceship.DataAccess;
using Spaceship.Entities;
using System;
using Xunit;
using System.Threading.Tasks;

namespace Spaceship.Services.Tests
{
    public class CrewServiceTests
    {
        [Fact]
        public void GetById_Negative_ArgumentException()
        {
            //Arrange
            ICrewRepository crewRepository = new CrewRepository();
            ICrewService crewService = new CrewService(crewRepository);

            const int NegativeId = -1;

            //Act & Assert
            Assert.ThrowsAsync<ArgumentException>(() => crewService.GetById(NegativeId));
        }

        [Fact]
        public async Task GetById_ValidId_ValidCrew()
        {
            //Arrange
            ICrewRepository crewRepository = new CrewRepository();
            ICrewService crewService = new CrewService(crewRepository);

            Crew expectedCrew = new Crew { Id = 1, Name = "Main" };

            //Act
            Crew actualCrew = await crewService.GetById(expectedCrew.Id);

            //Assert
            Assert.Equal(expectedCrew.Id, actualCrew.Id);
            Assert.Equal(expectedCrew.Name, actualCrew.Name);
        }
    }
}