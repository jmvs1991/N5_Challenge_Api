using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5Challenge.CommandApi.Dtos;
using N5Challenge.CommandApi.Services;
using System.Threading.Tasks;

namespace N5Challenge.CommandApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ITypeService _typeService;

        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }
        
        [HttpPost]
        public async Task AddBook([FromBody] TypeDTO type)
        {
            await _typeService.AddType(type);
        }

        [HttpPut("{id}")]
        public async Task UpdateBook(long id, [FromBody] TypeDTO type)
        {
            await _typeService.UpdateType(id, type);
        }

        [HttpDelete("{id}")]
        public async Task DeleteBook(long id)
        {
            await _typeService.DeleteType(id);
        }
    }
}
