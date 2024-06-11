using Domain.Entities.Common;
using Domain.Entities.Abstracts;

namespace Domain.Entities.Concretes;

public class Category : BaseEntity, IEntity {

    // Fields

    public string Name { get; set; }

    // Navigation Properties

    public virtual ICollection<Product> Products { get; set; }
}
