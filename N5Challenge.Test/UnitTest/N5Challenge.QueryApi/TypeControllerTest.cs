using Moq;
using N5Challenge.Domain.Entities;
using N5Challenge.QueryApi.Controllers;
using N5Challenge.QueryApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace N5Challenge.Test.UnitTest.N5Challenge.QueryApi
{
    public class TypeControllerTest
    {
        private readonly Mock<ITypeService> mockTypeService;

        public TypeControllerTest()
        {
            mockTypeService = new Mock<ITypeService>();
        }

        [Fact]
        public async Task Test_Get_All()
        {
            mockTypeService.Reset();
            mockTypeService.Setup(mock => mock.Get()).ReturnsAsync(new List<TypeEntity>());

            TypeController typeController = new TypeController(mockTypeService.Object);

            var types = await typeController.Get();

            mockTypeService.Verify(mock => mock.Get(), Times.Once());
            Assert.IsType<List<TypeEntity>>(types);
        }

        [Fact]
        public async Task Test_Get_By_Id()
        {
            mockTypeService.Reset();
            mockTypeService.Setup(mock => mock.Get(It.IsAny<long>())).ReturnsAsync(new TypeEntity());

            TypeController typeController = new TypeController(mockTypeService.Object);

            var type = await typeController.Get(1);
            
            mockTypeService.Verify(mock => mock.Get(It.IsAny<long>()), Times.Once());
            Assert.IsType<TypeEntity>(type);
        }
    }
}
