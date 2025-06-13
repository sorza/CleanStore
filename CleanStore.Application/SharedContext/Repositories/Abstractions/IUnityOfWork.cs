namespace CleanStore.Application.SharedContext.Repositories.Abstractions
{
    public interface IUnityOfWork
    {
        Task CommitAsync();
        Task RollbackAsync();
    }
}
