using Application.Pet.Commands.CreatePet;
using Application.Repositories;
using Domain.Entities;
using MediatR;
using Moq;
using NUnit.Framework;
using WebApi.Controllers;
using Assert = NUnit.Framework.Assert;

namespace UnitTest.Application
{
    [TestFixture]
    public class CreatePetCommandHandlerTest
    {
        private CreatePetCommandHandler _handler;
        private Mock<IPetRepository> _petRepository;

        [SetUp]
        public void Setup()
        {
            _petRepository = new Mock<IPetRepository>();
            _petRepository
                .Setup(c => c.AddAsync(It.IsAny<Pet>()))
                .ReturnsAsync(1);
            _handler = new CreatePetCommandHandler(_petRepository.Object);
        }

        [Fact]
        public async Task test2()
        {
            //Arrange

            //Act

            //Assert

            Assert.AreEqual(1, 1);
        }
    }
}
