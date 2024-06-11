namespace Domain.Entities.Abstracts;

public interface IEntity {
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
