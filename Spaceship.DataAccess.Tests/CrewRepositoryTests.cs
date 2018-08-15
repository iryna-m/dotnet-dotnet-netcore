using System;
using NUnit.Framework;
using Spaceship.DataAccess;
using Spaceship.Entities;
using System.Threading.Tasks;


namespace Spaceshift.DataAccess.Tests
{
    [TestFixture]
    public class CrewRepositoryTests
    {
        [Test]
        public void GetById_Negative_ArgumentException()
        {
            //Arrange
            ICrewRepository crewRepository = new CrewRepository();

            const int NegativeId = -1;

            //Act & Assert
            Assert.ThrowsAsync<ArgumentException>(() => crewRepository.GetById(NegativeId));
        }

        [Test]
        public async Task GetById_ValidId_ValidCrew()
        {
            //Arrange
            ICrewRepository crewRepository = new CrewRepository();

            Crew expectedCrew = new Crew { Id = 1, Name = "Main" };

            //Act
            Crew actualCrew = await crewRepository.GetById(expectedCrew.Id);

            //Assert
            Assert.AreEqual(expectedCrew.Id, actualCrew.Id);
            Assert.AreEqual(expectedCrew.Name, actualCrew.Name);
        }
    }
}
