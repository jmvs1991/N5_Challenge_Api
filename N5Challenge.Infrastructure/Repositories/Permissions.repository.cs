using N5Challenge.Domain.Entities;
using N5Challenge.Domain.Repositories;

namespace N5Challenge.Infrastructure.Repositories
{
    public class PermissionsRepository : GenericRepository<PermissionsEntity>, IPermissionsRepository
    {
        public PermissionsRepository(N5ChallengeContext dbContext) : base(dbContext)
        {
        }
    }
}
