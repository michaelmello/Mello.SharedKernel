namespace Mello.SharedKernel.Interfaces;

public interface IAsyncRepository<T, TId> where T : Entity<TId>, IAggregateRoot
{
    Task<T> GetByIdAsync(TId id);
    Task<List<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}