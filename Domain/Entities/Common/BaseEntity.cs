using Domain.Entities.Abstracts;

namespace Domain.Entities.Common;

public abstract class BaseEntity : IEntity {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
