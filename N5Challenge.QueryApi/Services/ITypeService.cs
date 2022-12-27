using N5Challenge.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N5Challenge.QueryApi.Services
{
    public interface ITypeService
    {
        public Task<IEnumerable<TypeEntity>> Get();

        public Task<TypeEntity> Get(long id);
    }
}
