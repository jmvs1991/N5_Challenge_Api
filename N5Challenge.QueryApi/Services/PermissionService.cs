using N5Challenge.Domain.Entities;
using N5Challenge.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N5Challenge.QueryApi.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermissionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PermissionsEntity>> Get()
        {
            return await _unitOfWork.PermissionsRepository.GetAllAsync();
        }

        public async Task<PermissionsEntity> Get(long id)
        {
            return await _unitOfWork.PermissionsRepository.GetAsync(t => t.Id == id);
        }
    }
}
