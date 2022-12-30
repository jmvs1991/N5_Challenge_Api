using Moq;
using N5Challenge.CommandApi.Controllers;
using N5Challenge.CommandApi.Dtos;
using N5Challenge.CommandApi.Services;
using System.Threading.Tasks;
using Xunit;

namespace N5Challenge.Test.UnitTest.N5Challenge.CommandApi
{
    public class TypeControllerTest
    {
        private readonly Mock<ITypeService> mockTypeService;

        public TypeControllerTest()
        {
            mockTypeService = new Mock<ITypeService>();
        }

        [Fact]
        public async Task Test_Add()
        {
            mockTypeService.Reset();
            mockTypeService.Setup(mock => mock.AddType(It.IsAny<TypeDTO>())).Returns(Task.CompletedTask);
            TypeDTO type = new TypeDTO();

            TypeController typeController = new TypeController(mockTypeService.Object);

            await typeController.AddType(type);

            mockTypeService.Verify(mock => mock.AddType(It.IsAny<TypeDTO>()), Times.Once());
        }

        [Fact]
        public async Task Test_Update()
        {
            mockTypeService.Reset();
            mockTypeService.Setup(mock => mock.UpdateType(It.IsAny<long>(), It.IsAny<TypeDTO>())).Returns(Task.CompletedTask);
            TypeDTO type = new TypeDTO();

            TypeController typeController = new TypeController(mockTypeService.Object);

            await typeController.UpdateType(1, type);

            mockTypeService.Verify(mock => mock.UpdateType(It.IsAny<long>(), It.IsAny<TypeDTO>()), Times.Once());
        }

        [Fact]
        public async Task Test_Delete()
        {
            mockTypeService.Reset();
            mockTypeService.Setup(mock => mock.DeleteType(It.IsAny<long>())).Returns(Task.CompletedTask);
            TypeDTO type = new TypeDTO();

            TypeController typeController = new TypeController(mockTypeService.Object);

            await typeController.DeleteType(1);

            mockTypeService.Verify(mock => mock.DeleteType(It.IsAny<long>()), Times.Once());
        }
    }
}
