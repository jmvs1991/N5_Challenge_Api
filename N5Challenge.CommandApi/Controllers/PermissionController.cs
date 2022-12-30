using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5Challenge.CommandApi.Dtos;
using N5Challenge.CommandApi.Services;
using System.Threading.Tasks;

namespace N5Challenge.CommandApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpPost]
        public async Task AddPermission([FromBody] PermissionDTO permission)
        {
            await _permissionService.AddPermission(permission);
        }

        [HttpPut("{id}")]
        public async Task UpdatePermission(long id, [FromBody] PermissionDTO permission)
        {
            await _permissionService.UpdatePermission(id, permission);
        }

        [HttpDelete("{id}")]
        public async Task DeletePermission(long id)
        {
            await _permissionService.DeletePermission(id);
        }
    }
}
