using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spaceship.Controllers;
using Spaceship.DataAccess;
using Spaceship.Services;
using System;

namespace Spaceship.Public.Tests
{
    [TestClass]
    public class CrewControllerTests
    {
        [TestMethod]
        public void GetById_Negative_ArgumentException()
        {
            //Arrange
            ICrewRepository crewRepository = new CrewRepository();
            ICrewService crewService = new CrewService(crewRepository);
            CrewController crewController = new CrewController(crewService);

            const int NegativeId = -1;

            //Act & Assert
            Assert.ThrowsExceptionAsync<ArgumentException>(() => crewController.GetById(NegativeId));
        }
    }
}