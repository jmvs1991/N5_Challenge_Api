using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5Challenge.Domain.Entities;
using N5Challenge.QueryApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N5Challenge.QueryApi.Controllers
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

        [HttpGet]
        public async Task<IEnumerable<PermissionsEntity>> Get()
        {
            return await _permissionService.Get();
        }

        [HttpGet("{id}")]
        public async Task<PermissionsEntity> Get(long id)
        {
            return await _permissionService.Get(id);
        }
    }
}
