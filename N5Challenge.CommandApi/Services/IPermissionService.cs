using N5Challenge.CommandApi.Dtos;
using System.Threading.Tasks;

namespace N5Challenge.CommandApi.Services
{
    public interface IPermissionService
    {
        public Task AddPermission(PermissionDTO permissionDTO);

        public Task UpdatePermission(long id, PermissionDTO permissionDTO);

        public Task DeletePermission(long id);
    }
}
