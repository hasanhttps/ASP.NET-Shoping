using Domain.Entities.Common;
using Domain.Entities.Abstracts;

namespace Domain.Entities.Concretes;

public class Product : BaseEntity, IEntity {

    // Fields

    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }

    // Foreign Key Id

    public int CategoryId { get; set; }

    // Navigation Properties

    public virtual Category Category { get; set; }
    public virtual ICollection<Order> Orders {  get; set; }
}
