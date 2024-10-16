namespace Core.Entities;

public class Entity<TId>
{
    public TId Id { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime? UpdateTime { get; set; }
}
