using N5Challenge.CommandApi.Dtos;
using N5Challenge.Domain.Entities;
using N5Challenge.Domain.UnitOfWork;
using System.Threading.Tasks;

namespace N5Challenge.CommandApi.Services
{
    public class TypeService : ITypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddType(TypeDTO typeDTO)
        {
            var type = new TypeEntity
            {
                Description = typeDTO.Description,
            };

            _unitOfWork.TypeRepository.Add(type);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateType(long id, TypeDTO typeDTO)
        {
            TypeEntity type = _unitOfWork.TypeRepository.Get(t => t.Id == id);
            type.Description = typeDTO.Description;

            _unitOfWork.TypeRepository.Update(type);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteType(long id)
        {
            TypeEntity type = _unitOfWork.TypeRepository.Get(t => t.Id == id);

            _unitOfWork.TypeRepository.Remove(type);
            await _unitOfWork.CommitAsync();
        }

    }
}
