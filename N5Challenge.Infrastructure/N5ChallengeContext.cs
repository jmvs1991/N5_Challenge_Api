using Microsoft.EntityFrameworkCore;
using N5Challenge.Domain.Entities;

namespace N5Challenge.Infrastructure
{
    public class N5ChallengeContext : DbContext
    {
        public DbSet<PermissionsEntity> Permissions { get; set; }

        public DbSet<TypeEntity> Type { get; set; }
        
        public N5ChallengeContext(DbContextOptions<N5ChallengeContext> options) : base(options) { }

    }
}
