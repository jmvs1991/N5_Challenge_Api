using Moq;
using N5Challenge.Domain.Entities;
using N5Challenge.QueryApi.Controllers;
using N5Challenge.QueryApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace N5Challenge.Test.UnitTest.N5Challenge.QueryApi
{
    public class PermissionControllerTest
    {
        private readonly Mock<IPermissionService> mockPermissionService;

        public PermissionControllerTest()
        {
            mockPermissionService = new Mock<IPermissionService>();
        }

        [Fact]
        public async Task Test_Get_All()
        {
            mockPermissionService.Reset();
            mockPermissionService.Setup(mock => mock.Get()).ReturnsAsync(new List<PermissionsEntity>());

            PermissionController permissionController = new PermissionController(mockPermissionService.Object);

            var types = await permissionController.Get();

            mockPermissionService.Verify(mock => mock.Get(), Times.Once());
            Assert.IsType<List<PermissionsEntity>>(types);
        }

        [Fact]
        public async Task Test_Get_By_Id()
        {
            mockPermissionService.Reset();
            mockPermissionService.Setup(mock => mock.Get(It.IsAny<long>())).ReturnsAsync(new PermissionsEntity());

            PermissionController permissionController = new PermissionController(mockPermissionService.Object);

            var type = await permissionController.Get(1);

            mockPermissionService.Verify(mock => mock.Get(It.IsAny<long>()), Times.Once());
            Assert.IsType<PermissionsEntity>(type);
        }
    }
}
