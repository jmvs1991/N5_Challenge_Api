using N5Challenge.CommandApi.Dtos;
using System.Threading.Tasks;

namespace N5Challenge.CommandApi.Services
{
    public interface ITypeService
    {
        public Task AddType(TypeDTO typeDTO);
        public Task UpdateType(long id, TypeDTO typeDTO);
        public Task DeleteType(long id);
    }
}
