using Moq;
using N5Challenge.CommandApi.Controllers;
using N5Challenge.CommandApi.Dtos;
using N5Challenge.CommandApi.Services;
using System.Threading.Tasks;
using Xunit;

namespace N5Challenge.Test.UnitTest.N5Challenge.CommandApi
{
    public class PermissionControllerTest
    {
        private readonly Mock<IPermissionService> mockPermissionService;

        public PermissionControllerTest()
        {
            mockPermissionService = new Mock<IPermissionService>();
        }

        [Fact]
        public async Task Test_Add()
        {
            mockPermissionService.Reset();
            mockPermissionService.Setup(mock => mock.AddPermission(It.IsAny<PermissionDTO>())).Returns(Task.CompletedTask);
            PermissionDTO permission = new PermissionDTO();

            PermissionController permissionController = new PermissionController(mockPermissionService.Object);

            await permissionController.AddPermission(permission);

            mockPermissionService.Verify(mock => mock.AddPermission(It.IsAny<PermissionDTO>()), Times.Once());
        }

        [Fact]
        public async Task Test_Update()
        {
            mockPermissionService.Reset();
            mockPermissionService.Setup(mock => mock.UpdatePermission(It.IsAny<long>(), It.IsAny<PermissionDTO>())).Returns(Task.CompletedTask);
            PermissionDTO permission = new PermissionDTO();

            PermissionController permissionController = new PermissionController(mockPermissionService.Object);

            await permissionController.UpdatePermission(1, permission);

            mockPermissionService.Verify(mock => mock.UpdatePermission(It.IsAny<long>(), It.IsAny<PermissionDTO>()), Times.Once());
        }

        [Fact]
        public async Task Test_Delete()
        {
            mockPermissionService.Reset();
            mockPermissionService.Setup(mock => mock.DeletePermission(It.IsAny<long>())).Returns(Task.CompletedTask);
            PermissionDTO permission = new PermissionDTO();

            PermissionController permissionController = new PermissionController(mockPermissionService.Object);

            await permissionController.DeletePermission(1);

            mockPermissionService.Verify(mock => mock.DeletePermission(It.IsAny<long>()), Times.Once());
        }
    }
}
