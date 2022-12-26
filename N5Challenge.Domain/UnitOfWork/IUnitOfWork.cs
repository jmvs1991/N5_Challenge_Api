using N5Challenge.Domain.Repositories;

namespace N5Challenge.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPermissionsRepository PermissionsRepository { get; }
        ITypeRepository TypeRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
