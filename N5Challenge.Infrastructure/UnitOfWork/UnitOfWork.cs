using N5Challenge.Domain.Repositories;
using N5Challenge.Domain.UnitOfWork;
using N5Challenge.Infrastructure.Repositories;

namespace N5Challenge.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly N5ChallengeContext _dbContext;
        private IPermissionsRepository _permissionRepository;
        private ITypeRepository _typeRepository;

        public UnitOfWork(N5ChallengeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IPermissionsRepository PermissionsRepository
        {
            get { return _permissionRepository = _permissionRepository ?? new PermissionsRepository(_dbContext); }
        }

        public ITypeRepository TypeRepository
        {
            get { return _typeRepository = _typeRepository ?? new TypeRepository(_dbContext); }
        }

        public void Commit()
            => _dbContext.SaveChanges();


        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();


        public void Rollback()
            => _dbContext.Dispose();


        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
