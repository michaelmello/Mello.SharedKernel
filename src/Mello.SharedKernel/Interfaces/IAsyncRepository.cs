namespace Mello.SharedKernel.Interfaces;

public interface IAsyncRepository<T, TId> where T : Entity<TId>, IAggregateRoot
{
    Task<T> FindByIdAsync(TId id);
    Task<List<T>> FindAsync(ISpecification<T> specification);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}