using N5Challenge.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N5Challenge.QueryApi.Services
{
    public interface IPermissionService
    {
        public Task<IEnumerable<PermissionsEntity>> Get();

        public Task<PermissionsEntity> Get(long id);
    }
}
