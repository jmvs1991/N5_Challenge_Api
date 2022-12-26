using N5Challenge.Domain.Entities;
using N5Challenge.Domain.Repositories;

namespace N5Challenge.Infrastructure.Repositories
{
    public class TypeRepository : GenericRepository<TypeEntity>, ITypeRepository
    {
        public TypeRepository(N5ChallengeContext dbContext) : base(dbContext)
        {
        }
    }
}
