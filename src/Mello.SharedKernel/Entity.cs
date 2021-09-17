namespace Mello.SharedKernel;

public abstract class Entity<TId>
{
    public TId Id { get; set; } = default(TId)!;
}